using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;
using Videostore.Repository.Interfaces;
using Videostore.Service.Interfaces;

namespace Videostore.Service
{
    public class StudioService : IStudioService
    {
        private readonly IStudioRepository _studioRepository;
        private readonly ILogger<StudioService> _logger;

        public StudioService(IStudioRepository studioRepository, ILogger<StudioService> logger)
        {
            _studioRepository = studioRepository;
            _logger = logger;
        }

        public void Add(Studio studio)
        {
            try
            {
                _studioRepository.Add(studio);
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
                _studioRepository.Delete(studio);
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
                _studioRepository.Edit(studio);
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
            var result = _studioRepository.GetStudioByID(ID);
            return result;
        }

        public IEnumerable<Studio> GetStudios()
        {
            var result = _studioRepository.GetStudios();
            return result;
        }
    }
}
