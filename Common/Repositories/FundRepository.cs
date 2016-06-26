using Common.Interfaces;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class FundRepository : IFundRepository
    {

        private IList<Fund> funds = new List<Fund>()
        {
            new Fund { Id=1,Stock = Stock.Equity, StockName = "Equity1", Price=10,Quantity=10,StockWeight=10 },
            new Fund { Id=2,Stock = Stock.Bond, StockName = "Bond1", Price=5,Quantity=5,StockWeight=5 },
            new Fund { Id=3,Stock = Stock.Bond, StockName = "Equity2", Price=20,Quantity=100,StockWeight=90 },
        };

        public Fund GetbyId(int id)
        {
            foreach (Fund fund in funds)
            {
                if (fund.Id == id)
                {
                    return fund;
                }
            }

            return null;
        }

        public IList<Fund> FindAll()
        {
            return funds;
        }
    }
}
