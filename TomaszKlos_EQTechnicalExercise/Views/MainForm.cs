using Common.Interfaces;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TomaszKlos_EQTechnicalExercise.Presenters;
using System.Linq;
using TomaszKlos_EQTechnicalExercise.Views;
using System.Drawing;

namespace TomaszKlos_EQTechnicalExercise
{
    /// <summary>
    /// Fund form
    /// </summary>
    public partial class MainForm : Form, IMainView
    {
        public readonly int BondTolerance = 100;

        public readonly int EquityTolerance = 200;

        public event Action DataSourceChange;

        public IPresenter Presenter = null;

        public MainForm(IFundRepository fundRepository)
        {         
            InitializeComponent();
            Initialize();
            Presenter = new FundPresenter(this, fundRepository);
            gvFunds.DataSourceChanged += GvFunds_DataSourceChanged;
        }

        private void GvFunds_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gvFunds.Rows)
            {
                if (Stock.Equity.Equals(row.Cells[1].Value))
                {
                    if (((decimal)row.Cells[6].Value > EquityTolerance) || ((decimal)row.Cells[5].Value < 0))
                        row.Cells[2].Style.BackColor = Color.Red;
                }
                else
                {
                    if (((decimal)row.Cells[6].Value > BondTolerance) || ((decimal)row.Cells[5].Value < 0))
                        row.Cells[2].Style.BackColor = Color.Red;
                }
            }
        }
        public IList<Fund> Funds
        {
            get { return gvFunds.DataSource as IList<Fund>; }
        }

        public void LoadFunds(IList<Fund> funds)
        {
            gvFunds.DataSource = null;
            gvFunds.DataSource = funds;
         }

        public Fund GetFund()
        {
            var fund = new Fund();
            fund.Stock = (Stock)(cbxStockType.SelectedItem as ComboboxItem).Value;
            fund.Price = nPrice.Value;
            fund.Quantity = nQuantity.Value;

            return fund;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                DataSourceChange?.Invoke();
            }
            else
            {
                MessageBox.Show("Validation", "Price / Quantity are mandatory fields.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public new bool Validate()
        {
            if (!string.IsNullOrEmpty(nPrice.Text) &&
                !string.IsNullOrEmpty(nQuantity.Text) &&
                nPrice.Value != 0 &&
                nQuantity.Value != 0)
            {
                return true;
            }
            return false;
        }

        public string EquityTotal
        {
            get { return tbxEquityTotal.Text; }
            set { tbxEquityTotal.Text = value; }
        }
        public string EquityTotalStockWeight
        {
            get { return tbxEquityTotalStockWeight.Text; }
            set { tbxEquityTotalStockWeight.Text = value; }
        }
        public string EquityTotalMarketValue
        {
            get { return tbxEquityTotalMarketValue.Text; }
            set { tbxEquityTotalMarketValue.Text = value; }
        }
        public string BondTotal
        {
            get { return tbxBondTotal.Text; }
            set { tbxBondTotal.Text = value; }
        }
        public string BondTotalStockWeight
        {
            get { return tbxBondTotalStockWeight.Text; }
            set { tbxBondTotalStockWeight.Text = value; }
        }
        public string BondTotalMarketValue
        {
            get { return tbxBondTotalMarketValue.Text; }
            set { tbxBondTotalMarketValue.Text = value; }
        }
        public string Total
        {
            get { return tbxTotal.Text; }
            set { tbxTotal.Text = value; }
        }
        public string TotalStockWeight
        {
            get { return tbxTotalStockWeight.Text; }
            set { tbxTotalStockWeight.Text = value; }
        }
        public string TotalMarketValue
        {
            get { return tbxTotalMarketValue.Text; }
            set { tbxTotalMarketValue.Text = value; }
        }

        private void Initialize()
        {
            gvFunds.DataSource = new List<Fund>();

            ComboboxItem equity = new ComboboxItem();
            equity.Text = "Equity";
            equity.Value = Stock.Equity;
            cbxStockType.Items.Add(equity);


            ComboboxItem bond = new ComboboxItem();
            bond.Text = "Bond";
            bond.Value = Stock.Bond;
            cbxStockType.Items.Add(bond);

            cbxStockType.SelectedIndex = 0;

            nPrice.Maximum = Decimal.MaxValue;
            nQuantity.Maximum = Decimal.MaxValue;

            nPrice.Minimum = Decimal.MinValue;
            nQuantity.Minimum = 0;
        }
    }

}
