using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;
using Videostore.Repository.Interfaces;
using Videostore.Service.Interfaces;

namespace Videostore.Service
{
    public class TVshowService : ITVshowService
    {
        private readonly ITVshowRepository _tvShowRepository;

        public TVshowService(ITVshowRepository tvShowRepository)
        {
            _tvShowRepository = tvShowRepository;
        }

        public void Add(TVshow tvshow)
        {
            _tvShowRepository.Add(tvshow);
        }

        public void Delete(TVshow tvshow)
        {
            _tvShowRepository.Delete(tvshow);
        }

        public void Edit(TVshow tvshow)
        {
            _tvShowRepository.Edit(tvshow);
        }

        public TVshow GetTVshowByID(int ID)
        {
            var result = _tvShowRepository.GetTVshowByID(ID);
            return result;
        }

        public IEnumerable<TVshow> GetTVshows()
        {
            var result = _tvShowRepository.GetTVshows();
            return result;
        }
    }
}
