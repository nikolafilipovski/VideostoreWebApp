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
            var users = _userManager.Users;
            _logger.LogInformation("All users are listed!");
            return View(users);
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);

            return View(user);
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
        public async Task<ActionResult> Edit(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            var roles = _roleManager.Roles; 

            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var userModel = new UserModel
                {
                    ID = user.Id,
                    email = user.Email,
                    roles = GetRoles(roles, userRoles[0])
                };

                var selectedRoleId = roles.Where(x => x.Name == userRoles[0]).SingleOrDefault().Id;
                userModel.roleID = selectedRoleId;
                return View(userModel);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, string email, string password, string roleName)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var getUserOldRole = _roleManager.FindByNameAsync(userRoles[0]);

                if (!string.IsNullOrEmpty(email))
                {
                    user.Email = email;
                }
                else
                {
                    ModelState.AddModelError("", "Email cannot be empty!");
                }

                if (!string.IsNullOrEmpty(password))
                {
                    user.PasswordHash = _passwordHasher.HashPassword(user, password);
                }
                else
                {
                    ModelState.AddModelError("", "Password cannot be empty!");
                }

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        await _userManager.RemoveFromRoleAsync(user, getUserOldRole.Result.Name); 
                        await _userManager.AddToRoleAsync(user, roleName); 
                        _logger.LogInformation("User updated!");
                        _logger.LogInformation("User role added!");

                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        Errors(result);
                        _logger.LogError("Model state invalid!");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
                _logger.LogWarning("User not found!");
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            IdentityResult result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                _logger.LogInformation("User deleted!");
                return RedirectToAction(nameof(Index));
            }
            else
            {
                Errors(result);
                _logger.LogInformation("An error occured while deleting a user!");
            }
            return View(nameof(Index), _userManager.Users);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Deleted(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User deleted!");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    Errors(result);
                    _logger.LogInformation("An error occured while deleting a user!");
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found!");
                _logger.LogWarning("User not found!");
            }
            return View(nameof(Index), _userManager.Users);
        }

        #region Helper methods

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

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        #endregion

    }
}
