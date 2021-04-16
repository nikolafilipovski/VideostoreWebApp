using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Service.Interfaces
{
    public interface IDirectorService
    {
        void Add(Director director);
        void Edit(Director director);
        void Delete(Director director);
        Director GetDirectorByID(int ID);
        IEnumerable<Director> GetDirectors();
        IEnumerable<SelectListItem> dropdownDirectors(IEnumerable<Director> directors);

    }
}
