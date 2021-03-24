using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Repository.Interfaces
{
    public interface IDirectorRepository
    {
        void Add(Director director);
        void Edit(Director director);
        void Delete(Director director);
        Director GetDirectorByID(int ID);
        IEnumerable<Director> GetDirectors();




    }
}
