using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IMainView 
    {
        event Action DataSourceChange;

        void LoadFunds(IList<Fund> funds);

        IList<Fund> Funds { get; }

        Fund GetFund();

        string EquityTotal { get; set; }

        string EquityTotalStockWeight { get; set; }

        string EquityTotalMarketValue { get; set; }

        string BondTotal { get; set; }

        string BondTotalStockWeight { get; set; }

        string BondTotalMarketValue { get; set; }

        string Total { get; set; }

        string TotalStockWeight { get; set; }

        string TotalMarketValue { get; set; }

        bool Validate();

    }
}
