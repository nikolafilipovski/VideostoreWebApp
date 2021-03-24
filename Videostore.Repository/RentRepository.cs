using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Videostore.Data;
using Videostore.Entities;
using Videostore.Repository.Interfaces;

namespace Videostore.Repository
{
    public class RentRepository : IRentRepository
    {
        private readonly DataContext _context;

        public RentRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Rent rent)
        {
            _context.Rents.Add(rent);
            _context.SaveChanges();
        }

        public void Delete(Rent rent)
        {
            _context.Rents.Remove(rent);
            _context.SaveChanges();
        }

        public void Edit(Rent rent)
        {
            _context.Rents.Update(rent);
            _context.SaveChanges();
        }

        public Rent GetRentByID(int ID)
        {
            var result = _context.Rents.FirstOrDefault(x => x.rentID == ID);
            return result;
        }

        public IEnumerable<Rent> GetRents()
        {
            var result = _context.Rents.AsEnumerable();
            return result;
        }
    }
}
