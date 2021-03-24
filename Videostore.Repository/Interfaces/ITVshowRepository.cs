using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Repository.Interfaces
{
    public interface ITVshowRepository
    {
        void Add(TVshow tvshow);
        void Edit(TVshow tvshow);
        void Delete(TVshow tvshow);
        TVshow GetTVshowByID(int ID);
        IEnumerable<TVshow> GetTVshows();



    }
}
