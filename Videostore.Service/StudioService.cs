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

        public StudioService(IStudioRepository studioRepository)
        {
            _studioRepository = studioRepository;
        }

        public void Add(Studio studio)
        {
            _studioRepository.Add(studio);
        }

        public void Delete(Studio studio)
        {
            _studioRepository.Delete(studio);
        }

        public void Edit(Studio studio)
        {
            _studioRepository.Edit(studio);
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
