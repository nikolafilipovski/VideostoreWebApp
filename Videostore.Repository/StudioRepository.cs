using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class StudioRepository : IStudioRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<StudioRepository> _logger;

        public StudioRepository(DataContext context, ILogger<StudioRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Studio studio)
        {
            try
            {
                _context.Studios.Add(studio);
                _context.SaveChanges();
                _logger.LogInformation("New studio was created!");
            }
            catch (Exception exception)
            {
                _logger.LogError("An error occurred while creating a studio" + " | " + exception);
                throw;
            }
        }

        public void Delete(Studio studio)
        {
            try
            {
                _context.Studios.Remove(studio);
                _context.SaveChanges();
                _logger.LogInformation("Studio was deleted!");
            }
            catch (Exception exception)
            {
                _logger.LogError("An error occurred while deleting a studio" + " | " + exception);
                throw;
            }
        }

        public void Edit(Studio studio)
        {
            try
            {
                _context.Studios.Update(studio);
                _context.SaveChanges();
                _logger.LogInformation("Studio was updated!");
            }
            catch (Exception exception)
            {
                _logger.LogError("An error occurred while updating a studio" + " | " + exception);
                throw;
            }
        }

        public Studio GetStudioByID(int ID)
        {
            var result = _context.Studios.FirstOrDefault(x => x.studioID == ID);
            return result;
        }

        public IEnumerable<Studio> GetStudios()
        {
            var result = _context.Studios.AsEnumerable();
            return result;
        }
    }
}
