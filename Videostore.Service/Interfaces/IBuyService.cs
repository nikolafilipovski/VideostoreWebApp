using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Service.Interfaces
{
    public interface IBuyService
    {
        void Add(Buy buy);
        void Edit(Buy buy);
        void Delete(Buy buy);
        Buy GetBuyByID(int ID);
        IEnumerable<Buy> GetBuys();
    }
}
