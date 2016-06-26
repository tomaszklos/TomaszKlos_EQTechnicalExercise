using Common.Interfaces;

namespace TomaszKlos_EQTechnicalExercise
{
    partial class MainForm : IMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpAll = new System.Windows.Forms.TableLayoutPanel();
            this.gbFund = new System.Windows.Forms.GroupBox();
            this.gvFunds = new System.Windows.Forms.DataGridView();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.tlpStock = new System.Windows.Forms.TableLayoutPanel();
            this.lStockType = new System.Windows.Forms.Label();
            this.cbxStockType = new System.Windows.Forms.ComboBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.lQuantity = new System.Windows.Forms.Label();
            this.nQuantity = new System.Windows.Forms.NumericUpDown();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.tlpSummary = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxBondTotalMarketValue = new System.Windows.Forms.TextBox();
            this.tbxBondTotalStockWeight = new System.Windows.Forms.TextBox();
            this.tbxBondTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lEquityTotal = new System.Windows.Forms.Label();
            this.tbxEquityTotal = new System.Windows.Forms.TextBox();
            this.tbxEquityTotalStockWeight = new System.Windows.Forms.TextBox();
            this.tbxEquityTotalMarketValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.tbxTotalStockWeight = new System.Windows.Forms.TextBox();
            this.tbxTotalMarketValue = new System.Windows.Forms.TextBox();
            this.tlpAll.SuspendLayout();
            this.gbFund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFunds)).BeginInit();
            this.gbAdd.SuspendLayout();
            this.tlpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            this.gbSummary.SuspendLayout();
            this.tlpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAll
            // 
            this.tlpAll.ColumnCount = 2;
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.14554F));
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.85446F));
            this.tlpAll.Controls.Add(this.gbFund, 0, 1);
            this.tlpAll.Controls.Add(this.gbAdd, 0, 0);
            this.tlpAll.Controls.Add(this.gbSummary, 1, 1);
            this.tlpAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAll.Location = new System.Drawing.Point(0, 0);
            this.tlpAll.Name = "tlpAll";
            this.tlpAll.RowCount = 2;
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAll.Size = new System.Drawing.Size(1151, 480);
            this.tlpAll.TabIndex = 0;
            // 
            // gbFund
            // 
            this.gbFund.Controls.Add(this.gvFunds);
            this.gbFund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFund.Location = new System.Drawing.Point(3, 123);
            this.gbFund.Name = "gbFund";
            this.gbFund.Size = new System.Drawing.Size(835, 354);
            this.gbFund.TabIndex = 0;
            this.gbFund.TabStop = false;
            this.gbFund.Text = "Fund";
            // 
            // gvFunds
            // 
            this.gvFunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFunds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFunds.Location = new System.Drawing.Point(3, 16);
            this.gvFunds.Name = "gvFunds";
            this.gvFunds.Size = new System.Drawing.Size(829, 335);
            this.gvFunds.TabIndex = 0;
            // 
            // gbAdd
            // 
            this.tlpAll.SetColumnSpan(this.gbAdd, 2);
            this.gbAdd.Controls.Add(this.tlpStock);
            this.gbAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAdd.Location = new System.Drawing.Point(3, 3);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(1145, 114);
            this.gbAdd.TabIndex = 1;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add";
            // 
            // tlpStock
            // 
            this.tlpStock.ColumnCount = 7;
            this.tlpStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tlpStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tlpStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 491F));
            this.tlpStock.Controls.Add(this.lStockType, 0, 0);
            this.tlpStock.Controls.Add(this.cbxStockType, 1, 0);
            this.tlpStock.Controls.Add(this.lPrice, 2, 0);
            this.tlpStock.Controls.Add(this.lQuantity, 4, 0);
            this.tlpStock.Controls.Add(this.nQuantity, 5, 0);
            this.tlpStock.Controls.Add(this.nPrice, 3, 0);
            this.tlpStock.Controls.Add(this.btnAdd, 0, 1);
            this.tlpStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStock.Location = new System.Drawing.Point(3, 16);
            this.tlpStock.Name = "tlpStock";
            this.tlpStock.RowCount = 2;
            this.tlpStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStock.Size = new System.Drawing.Size(1139, 95);
            this.tlpStock.TabIndex = 0;
            // 
            // lStockType
            // 
            this.lStockType.AutoSize = true;
            this.lStockType.Location = new System.Drawing.Point(3, 0);
            this.lStockType.Name = "lStockType";
            this.lStockType.Size = new System.Drawing.Size(68, 13);
            this.lStockType.TabIndex = 0;
            this.lStockType.Text = "Stock Type :";
            // 
            // cbxStockType
            // 
            this.cbxStockType.FormattingEnabled = true;
            this.cbxStockType.Location = new System.Drawing.Point(83, 3);
            this.cbxStockType.Name = "cbxStockType";
            this.cbxStockType.Size = new System.Drawing.Size(74, 21);
            this.cbxStockType.TabIndex = 1;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(163, 0);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(37, 13);
            this.lPrice.TabIndex = 2;
            this.lPrice.Text = "Price :";
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Location = new System.Drawing.Point(329, 0);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(52, 13);
            this.lQuantity.TabIndex = 3;
            this.lQuantity.Text = "Quantity :";
            // 
            // nQuantity
            // 
            this.nQuantity.Location = new System.Drawing.Point(392, 3);
            this.nQuantity.Name = "nQuantity";
            this.nQuantity.Size = new System.Drawing.Size(120, 20);
            this.nQuantity.TabIndex = 6;
            // 
            // nPrice
            // 
            this.nPrice.DecimalPlaces = 2;
            this.nPrice.Location = new System.Drawing.Point(210, 3);
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(113, 20);
            this.nPrice.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.tlpSummary);
            this.gbSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSummary.Location = new System.Drawing.Point(844, 123);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(304, 354);
            this.gbSummary.TabIndex = 2;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Summary";
            // 
            // tlpSummary
            // 
            this.tlpSummary.ColumnCount = 2;
            this.tlpSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.18518F));
            this.tlpSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.81482F));
            this.tlpSummary.Controls.Add(this.label8, 0, 8);
            this.tlpSummary.Controls.Add(this.tbxBondTotalMarketValue, 1, 5);
            this.tlpSummary.Controls.Add(this.tbxBondTotalStockWeight, 1, 4);
            this.tlpSummary.Controls.Add(this.tbxBondTotal, 1, 3);
            this.tlpSummary.Controls.Add(this.label3, 0, 3);
            this.tlpSummary.Controls.Add(this.label2, 0, 2);
            this.tlpSummary.Controls.Add(this.label1, 0, 1);
            this.tlpSummary.Controls.Add(this.lEquityTotal, 0, 0);
            this.tlpSummary.Controls.Add(this.tbxEquityTotal, 1, 0);
            this.tlpSummary.Controls.Add(this.tbxEquityTotalStockWeight, 1, 1);
            this.tlpSummary.Controls.Add(this.tbxEquityTotalMarketValue, 1, 2);
            this.tlpSummary.Controls.Add(this.label4, 0, 4);
            this.tlpSummary.Controls.Add(this.label5, 0, 5);
            this.tlpSummary.Controls.Add(this.label6, 0, 6);
            this.tlpSummary.Controls.Add(this.label7, 0, 7);
            this.tlpSummary.Controls.Add(this.tbxTotal, 1, 6);
            this.tlpSummary.Controls.Add(this.tbxTotalStockWeight, 1, 7);
            this.tlpSummary.Controls.Add(this.tbxTotalMarketValue, 1, 8);
            this.tlpSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSummary.Location = new System.Drawing.Point(3, 16);
            this.tlpSummary.Name = "tlpSummary";
            this.tlpSummary.RowCount = 9;
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSummary.Size = new System.Drawing.Size(298, 335);
            this.tlpSummary.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Market Value:";
            // 
            // tbxBondTotalMarketValue
            // 
            this.tbxBondTotalMarketValue.Location = new System.Drawing.Point(167, 153);
            this.tbxBondTotalMarketValue.Name = "tbxBondTotalMarketValue";
            this.tbxBondTotalMarketValue.ReadOnly = true;
            this.tbxBondTotalMarketValue.Size = new System.Drawing.Size(116, 20);
            this.tbxBondTotalMarketValue.TabIndex = 11;
            // 
            // tbxBondTotalStockWeight
            // 
            this.tbxBondTotalStockWeight.Location = new System.Drawing.Point(167, 123);
            this.tbxBondTotalStockWeight.Name = "tbxBondTotalStockWeight";
            this.tbxBondTotalStockWeight.ReadOnly = true;
            this.tbxBondTotalStockWeight.Size = new System.Drawing.Size(116, 20);
            this.tbxBondTotalStockWeight.TabIndex = 10;
            // 
            // tbxBondTotal
            // 
            this.tbxBondTotal.Location = new System.Drawing.Point(167, 93);
            this.tbxBondTotal.Name = "tbxBondTotal";
            this.tbxBondTotal.ReadOnly = true;
            this.tbxBondTotal.Size = new System.Drawing.Size(116, 20);
            this.tbxBondTotal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bond - Total Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equity - Total Market Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equity - Total Stock Weight:";
            // 
            // lEquityTotal
            // 
            this.lEquityTotal.AutoSize = true;
            this.lEquityTotal.Location = new System.Drawing.Point(3, 0);
            this.lEquityTotal.Name = "lEquityTotal";
            this.lEquityTotal.Size = new System.Drawing.Size(112, 13);
            this.lEquityTotal.TabIndex = 0;
            this.lEquityTotal.Text = "Equity - Total Number:";
            // 
            // tbxEquityTotal
            // 
            this.tbxEquityTotal.Location = new System.Drawing.Point(167, 3);
            this.tbxEquityTotal.Name = "tbxEquityTotal";
            this.tbxEquityTotal.ReadOnly = true;
            this.tbxEquityTotal.Size = new System.Drawing.Size(116, 20);
            this.tbxEquityTotal.TabIndex = 1;
            // 
            // tbxEquityTotalStockWeight
            // 
            this.tbxEquityTotalStockWeight.Location = new System.Drawing.Point(167, 33);
            this.tbxEquityTotalStockWeight.Name = "tbxEquityTotalStockWeight";
            this.tbxEquityTotalStockWeight.ReadOnly = true;
            this.tbxEquityTotalStockWeight.Size = new System.Drawing.Size(116, 20);
            this.tbxEquityTotalStockWeight.TabIndex = 3;
            // 
            // tbxEquityTotalMarketValue
            // 
            this.tbxEquityTotalMarketValue.Location = new System.Drawing.Point(167, 63);
            this.tbxEquityTotalMarketValue.Name = "tbxEquityTotalMarketValue";
            this.tbxEquityTotalMarketValue.ReadOnly = true;
            this.tbxEquityTotalMarketValue.Size = new System.Drawing.Size(116, 20);
            this.tbxEquityTotalMarketValue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bond - Total Stock Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bond - Total Market Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Stock Weight:";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(167, 183);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(116, 20);
            this.tbxTotal.TabIndex = 15;
            // 
            // tbxTotalStockWeight
            // 
            this.tbxTotalStockWeight.Location = new System.Drawing.Point(167, 213);
            this.tbxTotalStockWeight.Name = "tbxTotalStockWeight";
            this.tbxTotalStockWeight.ReadOnly = true;
            this.tbxTotalStockWeight.Size = new System.Drawing.Size(116, 20);
            this.tbxTotalStockWeight.TabIndex = 16;
            // 
            // tbxTotalMarketValue
            // 
            this.tbxTotalMarketValue.Location = new System.Drawing.Point(167, 243);
            this.tbxTotalMarketValue.Name = "tbxTotalMarketValue";
            this.tbxTotalMarketValue.ReadOnly = true;
            this.tbxTotalMarketValue.Size = new System.Drawing.Size(116, 20);
            this.tbxTotalMarketValue.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 480);
            this.Controls.Add(this.tlpAll);
            this.Name = "MainForm";
            this.Text = "EQ Technical Exercise";
            this.tlpAll.ResumeLayout(false);
            this.gbFund.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFunds)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.tlpStock.ResumeLayout(false);
            this.tlpStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            this.gbSummary.ResumeLayout(false);
            this.tlpSummary.ResumeLayout(false);
            this.tlpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAll;
        private System.Windows.Forms.GroupBox gbFund;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.DataGridView gvFunds;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.TableLayoutPanel tlpStock;
        private System.Windows.Forms.TableLayoutPanel tlpSummary;
        private System.Windows.Forms.Label lStockType;
        private System.Windows.Forms.ComboBox cbxStockType;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nQuantity;
        private System.Windows.Forms.Label lEquityTotal;
        private System.Windows.Forms.TextBox tbxEquityTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEquityTotalStockWeight;
        private System.Windows.Forms.TextBox tbxEquityTotalMarketValue;
        private System.Windows.Forms.TextBox tbxBondTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxBondTotalMarketValue;
        private System.Windows.Forms.TextBox tbxBondTotalStockWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.TextBox tbxTotalStockWeight;
        private System.Windows.Forms.TextBox tbxTotalMarketValue;
        private System.Windows.Forms.NumericUpDown nPrice;
    }
}

