namespace CryptoForms
{
    partial class CryptoTradeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoTradeForm));
            this.cryptoTimer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusCryptoMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCryptoRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCrypto1 = new System.Windows.Forms.Panel();
            this.gridBalances = new System.Windows.Forms.DataGridView();
            this.LeftColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangeButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BidSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AskSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSymbols = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSellQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuyQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.rdoBitstamp = new System.Windows.Forms.RadioButton();
            this.panelCrypto2 = new System.Windows.Forms.Panel();
            this.panelCrypto3 = new System.Windows.Forms.Panel();
            this.panelCrypto4 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelCrypto1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSymbols)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cryptoTimer1
            // 
            this.cryptoTimer1.Interval = 1000;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusCryptoMain,
            this.statusCryptoRight});
            this.statusStrip1.Location = new System.Drawing.Point(0, 987);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1428, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusCryptoMain
            // 
            this.statusCryptoMain.Name = "statusCryptoMain";
            this.statusCryptoMain.Size = new System.Drawing.Size(1233, 25);
            this.statusCryptoMain.Spring = true;
            // 
            // statusCryptoRight
            // 
            this.statusCryptoRight.AutoSize = false;
            this.statusCryptoRight.BackColor = System.Drawing.Color.Silver;
            this.statusCryptoRight.Name = "statusCryptoRight";
            this.statusCryptoRight.Size = new System.Drawing.Size(179, 25);
            this.statusCryptoRight.Text = "?";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1428, 975);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1420, 946);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelCrypto1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelCrypto2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelCrypto3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelCrypto4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1399, 930);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelCrypto1
            // 
            this.panelCrypto1.Controls.Add(this.lblSymbol);
            this.panelCrypto1.Controls.Add(this.gridBalances);
            this.panelCrypto1.Controls.Add(this.gridSymbols);
            this.panelCrypto1.Controls.Add(this.panel2);
            this.panelCrypto1.Controls.Add(this.panel1);
            this.panelCrypto1.Controls.Add(this.rdoBitstamp);
            this.panelCrypto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrypto1.Location = new System.Drawing.Point(3, 1);
            this.panelCrypto1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelCrypto1.Name = "panelCrypto1";
            this.panelCrypto1.Size = new System.Drawing.Size(1393, 323);
            this.panelCrypto1.TabIndex = 1;
            // 
            // gridBalances
            // 
            this.gridBalances.AllowUserToAddRows = false;
            this.gridBalances.AllowUserToDeleteRows = false;
            this.gridBalances.AllowUserToResizeColumns = false;
            this.gridBalances.AllowUserToResizeRows = false;
            this.gridBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBalances.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridBalances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBalances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBalances.ColumnHeadersVisible = false;
            this.gridBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeftColumn,
            this.RightColumn,
            this.ExchangeButtonColumn,
            this.BidSizeColumn,
            this.BidColumn,
            this.AskColumn,
            this.AskSizeColumn});
            this.gridBalances.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridBalances.Location = new System.Drawing.Point(4, 3);
            this.gridBalances.MultiSelect = false;
            this.gridBalances.Name = "gridBalances";
            this.gridBalances.ReadOnly = true;
            this.gridBalances.RowHeadersVisible = false;
            this.gridBalances.RowTemplate.Height = 28;
            this.gridBalances.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridBalances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridBalances.Size = new System.Drawing.Size(483, 313);
            this.gridBalances.TabIndex = 21;
            this.gridBalances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBalances_CellContentClick);
            // 
            // LeftColumn
            // 
            this.LeftColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LeftColumn.FillWeight = 35F;
            this.LeftColumn.HeaderText = "LeftBalance";
            this.LeftColumn.Name = "LeftColumn";
            this.LeftColumn.ReadOnly = true;
            this.LeftColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RightColumn
            // 
            this.RightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RightColumn.FillWeight = 35F;
            this.RightColumn.HeaderText = "RightBalance";
            this.RightColumn.Name = "RightColumn";
            this.RightColumn.ReadOnly = true;
            this.RightColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ExchangeButtonColumn
            // 
            this.ExchangeButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ExchangeButtonColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ExchangeButtonColumn.HeaderText = "ExchangeButton";
            this.ExchangeButtonColumn.Name = "ExchangeButtonColumn";
            this.ExchangeButtonColumn.ReadOnly = true;
            this.ExchangeButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExchangeButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BidSizeColumn
            // 
            this.BidSizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BidSizeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.BidSizeColumn.FillWeight = 80F;
            this.BidSizeColumn.HeaderText = "BidSize";
            this.BidSizeColumn.Name = "BidSizeColumn";
            this.BidSizeColumn.ReadOnly = true;
            this.BidSizeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BidColumn
            // 
            this.BidColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BidColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.BidColumn.FillWeight = 80F;
            this.BidColumn.HeaderText = "Bid";
            this.BidColumn.Name = "BidColumn";
            this.BidColumn.ReadOnly = true;
            this.BidColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AskColumn
            // 
            this.AskColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AskColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.AskColumn.FillWeight = 80F;
            this.AskColumn.HeaderText = "Ask";
            this.AskColumn.Name = "AskColumn";
            this.AskColumn.ReadOnly = true;
            this.AskColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AskSizeColumn
            // 
            this.AskSizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AskSizeColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.AskSizeColumn.FillWeight = 80F;
            this.AskSizeColumn.HeaderText = "AskSize";
            this.AskSizeColumn.Name = "AskSizeColumn";
            this.AskSizeColumn.ReadOnly = true;
            this.AskSizeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gridSymbols
            // 
            this.gridSymbols.AllowUserToAddRows = false;
            this.gridSymbols.AllowUserToDeleteRows = false;
            this.gridSymbols.AllowUserToResizeColumns = false;
            this.gridSymbols.AllowUserToResizeRows = false;
            this.gridSymbols.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSymbols.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSymbols.BackgroundColor = System.Drawing.Color.White;
            this.gridSymbols.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSymbols.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSymbols.ColumnHeadersVisible = false;
            this.gridSymbols.EnableHeadersVisualStyles = false;
            this.gridSymbols.Location = new System.Drawing.Point(503, 8);
            this.gridSymbols.MultiSelect = false;
            this.gridSymbols.Name = "gridSymbols";
            this.gridSymbols.ReadOnly = true;
            this.gridSymbols.RowHeadersVisible = false;
            this.gridSymbols.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSymbols.RowTemplate.Height = 24;
            this.gridSymbols.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridSymbols.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridSymbols.Size = new System.Drawing.Size(883, 90);
            this.gridSymbols.TabIndex = 20;
            this.gridSymbols.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSymbols_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.txtSellQty);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSellPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSell);
            this.panel2.Location = new System.Drawing.Point(1054, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 209);
            this.panel2.TabIndex = 16;
            // 
            // txtSellQty
            // 
            this.txtSellQty.Location = new System.Drawing.Point(105, 93);
            this.txtSellQty.Name = "txtSellQty";
            this.txtSellQty.Size = new System.Drawing.Size(118, 22);
            this.txtSellQty.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Qty";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(105, 65);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(118, 22);
            this.txtSellPrice.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price";
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Red;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(105, 145);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(118, 39);
            this.btnSell.TabIndex = 3;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.txtBuyQty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBuyPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Location = new System.Drawing.Point(704, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 209);
            this.panel1.TabIndex = 15;
            // 
            // txtBuyQty
            // 
            this.txtBuyQty.Location = new System.Drawing.Point(101, 95);
            this.txtBuyQty.Name = "txtBuyQty";
            this.txtBuyQty.Size = new System.Drawing.Size(118, 22);
            this.txtBuyQty.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Qty";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(101, 67);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(118, 22);
            this.txtBuyPrice.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Price";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Blue;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(101, 145);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(118, 39);
            this.btnBuy.TabIndex = 8;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // rdoBitstamp
            // 
            this.rdoBitstamp.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoBitstamp.Location = new System.Drawing.Point(513, 278);
            this.rdoBitstamp.Name = "rdoBitstamp";
            this.rdoBitstamp.Size = new System.Drawing.Size(70, 35);
            this.rdoBitstamp.TabIndex = 11;
            this.rdoBitstamp.TabStop = true;
            this.rdoBitstamp.Text = "Bitstamp";
            this.rdoBitstamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBitstamp.UseVisualStyleBackColor = true;
            this.rdoBitstamp.CheckedChanged += new System.EventHandler(this.rdoBitstamp_CheckedChanged);
            // 
            // panelCrypto2
            // 
            this.panelCrypto2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrypto2.Location = new System.Drawing.Point(3, 326);
            this.panelCrypto2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelCrypto2.Name = "panelCrypto2";
            this.panelCrypto2.Size = new System.Drawing.Size(1393, 202);
            this.panelCrypto2.TabIndex = 5;
            // 
            // panelCrypto3
            // 
            this.panelCrypto3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrypto3.Location = new System.Drawing.Point(3, 533);
            this.panelCrypto3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCrypto3.Name = "panelCrypto3";
            this.panelCrypto3.Size = new System.Drawing.Size(1393, 187);
            this.panelCrypto3.TabIndex = 6;
            // 
            // panelCrypto4
            // 
            this.panelCrypto4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrypto4.Location = new System.Drawing.Point(3, 725);
            this.panelCrypto4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelCrypto4.Name = "panelCrypto4";
            this.panelCrypto4.Size = new System.Drawing.Size(1393, 204);
            this.panelCrypto4.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1316, 946);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSymbol
            // 
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(522, 139);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(151, 54);
            this.lblSymbol.TabIndex = 22;
            this.lblSymbol.Text = "BTC_USD";
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CryptoTradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 1017);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CryptoTradeForm";
            this.Text = "Crypto Trader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CryptoPricesForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelCrypto1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSymbols)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer cryptoTimer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusCryptoMain;
        private System.Windows.Forms.ToolStripStatusLabel statusCryptoRight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelCrypto1;
        private System.Windows.Forms.Panel panelCrypto2;
        private System.Windows.Forms.Panel panelCrypto3;
        private System.Windows.Forms.Panel panelCrypto4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.RadioButton rdoBitstamp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuyQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSellQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridBalances;
        private System.Windows.Forms.DataGridView gridSymbols;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ExchangeButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AskSizeColumn;
        private System.Windows.Forms.Label lblSymbol;
    }
}

