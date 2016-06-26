using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    /// <summary>
    /// 
    /// </summary>
    public enum Stock { Equity,Bond }
    /// <summary>
    /// a sum of money saved or made available for a particular purpose
    /// </summary>
    public class Fund : IFund
    {
        public int Id { get; set; }

        public Stock Stock { get; set; }

        public string StockName { get; set; }
         
        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public decimal MarketValue
        {
            get { return (Price !=0  && Quantity != 0) ? Price * Quantity : 0; }
        }

        public decimal TransactionCost
        {
            get { return (Stock==Stock.Equity) ? MarketValue * 0.005m : MarketValue * 0.02m; }

        }
        public decimal StockWeight { get; set; }



    }
}
