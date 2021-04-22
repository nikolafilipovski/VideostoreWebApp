using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Repository.Interfaces
{
    public interface IStudioRepository
    {
        void Add(Studio studio);
        void Edit(Studio studio);
        void Delete(Studio studio);
        Studio GetStudioByID(int ID);
        IEnumerable<Studio> GetStudios();

    }
}
