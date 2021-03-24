using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;
using Videostore.Repository.Interfaces;
using Videostore.Service.Interfaces;

namespace Videostore.Service
{
    public class BuyService : IBuyService
    {
        private readonly IBuyRepository _buyRepository;

        public BuyService(IBuyRepository buyRepository)
        {
            _buyRepository = buyRepository;
        }

        public void Add(Buy buy)
        {
            _buyRepository.Add(buy);
        }

        public void Delete(Buy buy)
        {
            _buyRepository.Delete(buy);
        }

        public void Edit(Buy buy)
        {
            _buyRepository.Edit(buy);
        }

        public Buy GetBuyByID(int ID)
        {
            var result = _buyRepository.GetBuyByID(ID);
            return result;
        }

        public IEnumerable<Buy> GetBuys()
        {
            var result = _buyRepository.GetBuys();
            return result;
        }
    }
}
