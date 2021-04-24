using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videostore.Models;
using Videostore.Service.Interfaces;

namespace Videostore.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPasswordHasher<IdentityUser> _passwordHasher;
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IPasswordHasher<IdentityUser> passwordHasher,
            ILogger<UserController> logger,
            IUserService userService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _passwordHasher = passwordHasher;
            _logger = logger;
            _userService = userService;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            var users = _userManager.Users;
            _logger.LogInformation("All users are listed!");
            return View(users);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            var roles = _roleManager.Roles;
            var userModel = new UserModel();
            userModel.roles = GetRoles(roles, null);

            return View(userModel);
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserModel user)
        {
            if (ModelState.IsValid)
            {
                IdentityUser appUser = new IdentityUser
                {
                    UserName = user.name,
                    Email = user.email,
                    EmailConfirmed = true
                };

                IdentityResult result = await _userManager.CreateAsync(appUser, user.password);
                _logger.LogInformation("User was created!");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, user.roleName);
                    _logger.LogInformation("Role was added to user!");

                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    _logger.LogError("Error a");
                }
            }
            return View(user);
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        private IQueryable<SelectListItem> GetRoles(IQueryable<IdentityRole> roles, string? currentRoleName)
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem
            {
                Value = "0",
                Text = "Select role...",
                Selected = false
            });
            foreach (var item in roles)
            {
                if (currentRoleName != null)
                {
                    if (item.Name.Equals(currentRoleName))
                    {
                        selectList.Add(new SelectListItem
                        {
                            Value = item.Id,
                            Text = item.Name,
                            Selected = true
                        });
                    }
                    else
                    {
                        selectList.Add(new SelectListItem
                        {
                            Value = item.Id,
                            Text = item.Name,
                            Selected = false
                        });
                    }
                }
                else
                {
                    selectList.Add(new SelectListItem
                    {
                        Value = item.Id,
                        Text = item.Name,
                        Selected = false
                    });
                }
            }
            return selectList.AsQueryable();
        }
    }
}
