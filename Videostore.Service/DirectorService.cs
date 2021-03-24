using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;
using Videostore.Repository.Interfaces;
using Videostore.Service.Interfaces;

namespace Videostore.Service
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public void Add(Director director)
        {
            _directorRepository.Add(director);
        }

        public void Delete(Director director)
        {
            _directorRepository.Delete(director);
        }

        public void Edit(Director director)
        {
            _directorRepository.Edit(director);
        }

        public Director GetDirectorByID(int ID)
        {
            var result = _directorRepository.GetDirectorByID(ID);
            return result;
        }

        public IEnumerable<Director> GetDirectors()
        {
            var result = _directorRepository.GetDirectors();
            return result;
        }
    }
}
