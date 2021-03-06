using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Service.Interfaces
{
    public interface IRentService
    {
        void Add(Rent rent);
        void Edit(Rent rent);
        void Delete(Rent rent);
        Rent GetRentByID(int ID);
        IEnumerable<Rent> GetRents();
    }
}
