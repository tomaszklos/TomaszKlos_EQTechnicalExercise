using Common.Interfaces;
using Common.Models;
using Common.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace TomaszKlos_EQTechnicalExercise.Presenters
{
    /// <summary>
    /// Business logic here
    /// </summary>
    public class FundPresenter : IPresenter
    {
        private IMainView m_View;

        private IList<Fund> funds;

        private IFundRepository FundRepository = null;

        public FundPresenter(IMainView view, IFundRepository fundRepository)
        {
            m_View = view;
            FundRepository = fundRepository;
            funds = FundRepository.FindAll();
            m_View.LoadFunds(FundRepository.FindAll());
            FundSummary();
            m_View.DataSourceChange += M_View_DataSourceChange;

        }
        public IMainView View
        {
            get { return m_View; }
        }

        public IList<Fund> FindAll()
        {
            return funds;
        }

        private void M_View_DataSourceChange()
        {
            DataSourceChange();

            LoadFunds(funds);
        }

        public void LoadFunds(IList<Fund> funds)
        {
            m_View.LoadFunds(funds);
        }

        public void DataSourceChange()
        {
            var fund = m_View.GetFund();
            fund.Id = Total + 1;
            fund.StockName = fund.Stock == Stock.Equity ? ("Equity" + (Equity+1).ToString()) : ("Bond" + (Bond+1).ToString());
            funds.Add(fund);

            foreach (var f in funds)
                f.StockWeight = (TotalMarketValue != 0) ? (f.MarketValue * 100 / TotalMarketValue) : 0;

            FundSummary();
        }

        private void FundSummary()
        {
            m_View.EquityTotal = Equity.ToString();
            m_View.EquityTotalStockWeight = EquityTotalStockWeight.ToString();
            m_View.EquityTotalMarketValue = EquityTotalMarketValue.ToString();
            m_View.BondTotal = Bond.ToString();
            m_View.BondTotalStockWeight = BondTotalStockWeight.ToString();
            m_View.BondTotalMarketValue = BondTotalMarketValue.ToString();
            m_View.Total = Total.ToString();
            m_View.TotalStockWeight = TotalStockWeight.ToString();
            m_View.TotalMarketValue = TotalMarketValue.ToString();
        }

        private int Equity
        {
            get { return (funds != null ? funds.Count(x => x.Stock == Stock.Equity) : 0); }
        }
        private decimal EquityTotalStockWeight
        {
            get { return (funds != null ? funds.Where(x => x.Stock == Stock.Equity).Sum(x=>x.StockWeight) : 0); }
        }
        private decimal EquityTotalMarketValue
        {
            get { return (funds != null ? funds.Where(x => x.Stock == Stock.Equity).Sum(x => x.MarketValue) : 0); }
        }


        private int Bond
        {
            get { return (funds != null ? funds.Count(x => x.Stock == Stock.Bond) : 0); }
        }
        private decimal BondTotalStockWeight
        {
            get { return (funds != null ? funds.Where(x => x.Stock == Stock.Bond).Sum(x=>x.StockWeight) : 0); }
        }
        private decimal BondTotalMarketValue
        {
            get { return (funds != null ? funds.Where(x => x.Stock == Stock.Bond).Sum(x => x.MarketValue) : 0); }
        }

        public int Total
        {
            get { return (funds != null ? funds.Count() : 0); }
        }
        private decimal TotalStockWeight
        {
            get { return (funds != null ? funds.Sum(x => x.StockWeight) : 0); }
        }
        private decimal TotalMarketValue
        {
            get { return (funds != null ? funds.Sum(x => x.MarketValue) : 0); }
        }

    }
}
