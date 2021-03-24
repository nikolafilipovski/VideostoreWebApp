using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Service.Interfaces
{
    public interface ITVshowService
    {
        void Add(TVshow tvshow);
        void Edit(TVshow tvshow);
        void Delete(TVshow tvshow);
        TVshow GetTVshowByID(int ID);
        IEnumerable<TVshow> GetTVshows();
    }
}
