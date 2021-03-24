using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;
using Videostore.Repository.Interfaces;
using Videostore.Service.Interfaces;

namespace Videostore.Service
{
    public class RentService : IRentService
    {
        private readonly IRentRepository _rentRepository;

        public RentService(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }

        public void Add(Rent rent)
        {
            _rentRepository.Add(rent);
        }

        public void Delete(Rent rent)
        {
            _rentRepository.Delete(rent);
        }

        public void Edit(Rent rent)
        {
            _rentRepository.Edit(rent);
        }

        public Rent GetRentByID(int ID)
        {
            var result = _rentRepository.GetRentByID(ID);
            return result;
        }

        public IEnumerable<Rent> GetRents()
        {
            var result = _rentRepository.GetRents();
            return result;
        }
    }
}
