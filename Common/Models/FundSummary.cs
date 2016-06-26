using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    /// <summary>
    /// summary
    /// </summary>
    public class FundSummary : IFundSummary
    {
        public decimal Equity { get; set; }

        public decimal Boud { get; set; }

        public decimal All { get; set; }

    }
}
