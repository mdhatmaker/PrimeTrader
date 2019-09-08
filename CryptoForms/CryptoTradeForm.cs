using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Tools;
using GuiTools.Grid;
using static Tools.G;
using CryptoAPIs;
using CryptoAPIs.Exchange;
using CryptoAPIs.ExchangeX;

namespace CryptoForms
{
    
    public partial class CryptoTradeForm : Form
    {
        List<DynamicDisplayGridPanel> m_gridPanels = new List<DynamicDisplayGridPanel>();

        public CryptoTradeForm()
        {
            InitializeComponent();

            Crypto.InitializeExchanges();

            //Bittrex.Test();

            DynamicDisplayGridPanel gridPanel;

            /*gridPanel = new DynamicDisplayGridPanel(panelCrypto1, "CoinMarketCapTicker", Color.Gray, 15000);
            gridPanel.Initialize();
            gridPanel.InitializeColumns(CoinMarketCapTicker.Columns, Color.White);
            gridPanel.UpdateListFunction = UpdateCoinMarketCapTicker;
            m_gridPanels.Add(gridPanel);*/

            gridPanel = new DynamicDisplayGridPanel(panelCrypto2, "BlockchainInfoTicker", Color.Gray, 3000);
            gridPanel.Initialize();
            gridPanel.InitializeColumns(BlockchainInfoTicker.Columns, Color.White);
            gridPanel.UpdateDictionaryFunction = UpdateBlockchainInfoTicker;
            m_gridPanels.Add(gridPanel);

            gridPanel = new DynamicDisplayGridPanel(panelCrypto3, "BitCoinChartsWeightedPrices", Color.Gray, 5000);
            gridPanel.Initialize();
            gridPanel.InitializeColumns(BitcoinChartsWeightedPrices.Columns, Color.White);
            gridPanel.UpdateDictionaryFunction = UpdateBitcoinChartsWeightedPrices;
            m_gridPanels.Add(gridPanel);

            gridPanel = new DynamicDisplayGridPanel(panelCrypto4, "BitstampTicker", Color.Gray, 20000);
            gridPanel.Initialize();
            gridPanel.InitializeColumns(BitstampTicker.Columns, Color.White);
            gridPanel.UpdateListFunction = UpdateBitstampTicker;
            m_gridPanels.Add(gridPanel);

            m_gridPanels[0].EnableUpdates(true);
            m_gridPanels[1].EnableUpdates(true);
            m_gridPanels[2].EnableUpdates(true);
            //m_gridPanels[3].EnableUpdates(true);
        }


        private List<IDataRow> UpdateBitstampTicker()
        {
            var li = BitstampTicker.GetList();
            List<IDataRow> li2 = new List<IDataRow>();
            foreach (var item in li)
            {
                li2.Add(item as IDataRow);
            }
            return li2;
        }

        private Dictionary<string, IDataRow> UpdateBlockchainInfoTicker()
        {
            var dict = BlockchainInfoTicker.GetDictionary();
            Dictionary<string, IDataRow> d2 = new Dictionary<string, IDataRow>();
            foreach (var k in dict.Keys)
            {
                d2.Add(k, dict[k] as IDataRow);
            }
            return d2;
        }

        private List<IDataRow> UpdateCoinMarketCapTicker()
        {
            var li = CoinMarketCapTicker.GetList();
            List<IDataRow> li2 = new List<IDataRow>();
            foreach (var item in li)
            {
                li2.Add(item as IDataRow);
            }
            return li2;
        }

        private Dictionary<string, IDataRow> UpdateBitcoinChartsWeightedPrices()
        {
            var dict = BitcoinChartsWeightedPrices.GetDictionary();
            Dictionary<string, IDataRow> d2 = new Dictionary<string, IDataRow>();
            foreach (var k in dict.Keys)
            {
                d2.Add(k, dict[k] as IDataRow);
            }
            return d2;
        }

        private void CryptoPricesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private static string[] m_exchangeNames = { "Bitstamp", "Bitfinex", "Kraken", "ItBit", "GDAX", "Bittrex", "BitFlyer", "Poloniex", "Binance" };
        private static Dictionary<string, CryptoExchange> m_exchanges = new Dictionary<string, CryptoExchange>();
        private static Dictionary<string, ZCurrencyPair> m_pairs = new Dictionary<string, ZCurrencyPair>();
        List<string> m_uniqueLefts, m_uniqueRights;

        // After this method, we should have all the CryptoExchanges stored in m_exchanges dictionary (key by name, ex: "Bitstamp")
        // We should also have m_symbols containing the set of UNIQUE symbols within ALL these exchanges
        private void PopulateExchanges()
        {
            // Get top 20 market caps using CoinMarketCap API
            var caps = CoinMarketCap.Instance.GetTickers(20);
            var top20 = caps.Select(c => c.symbol).ToList();

            m_pairs.Clear();
            foreach (var name in m_exchangeNames)
            {
                if (name == "GDAX") continue;
                cout("Processing exchange {0}", name);
                var exchange = new CryptoExchange(name);
                m_exchanges[name] = exchange;
                foreach (var p in exchange.Pairs.Values)
                {
                    // Let's do a little filter here—for top 20 market cap, for instance (both Left and Right currency have to be in top 20)
                    if (top20.Contains(p.Left) && top20.Contains(p.Right))
                        m_pairs[p.Symbol] = p;
                }
            }

            m_uniqueLefts = m_pairs.Select(p => p.Value.Left).OrderBy(s => s).ToList().Distinct().ToList();
            m_uniqueRights = m_pairs.Select(p => p.Value.Right).OrderBy(s => s).ToList().Distinct().ToList();
            //m_pairs.Select(p => p.Value.Left).OrderBy(s => s).ToList().Distinct().ToList().ForEach(s => cout("{0}", s));           
            //m_pairs.Select(p => p.Value.Right).OrderBy(s => s).ToList().Distinct().ToList().ForEach(s => cout("{0}", s));
            //m_symbols.OrderBy(s => s).ToList().ForEach(s => cout("{0}", s));
        }

        private void PopulateCurrencyGrid()
        {
            // BALANCES grid
            int N = 9;
            gridBalances.Rows.Clear();
            gridBalances.Rows.Add(N);                           // create (add) 9 rows to the grid
            for (int i = 0; i < N; ++i)
            {
                gridBalances.Rows[i].Cells[0].Value = 0;
                gridBalances.Rows[i].Cells[1].Value = 1;
                gridBalances.Rows[i].Cells[2].Value = m_exchangeNames[i];
                gridBalances.Rows[i].Cells[3].Value = 32.011;
                gridBalances.Rows[i].Cells[4].Value = 0.004562;
                gridBalances.Rows[i].Cells[5].Value = 0.004571;
                gridBalances.Rows[i].Cells[6].Value = 28.245;
            }

            // SYMBOLS grid
            int max = Math.Max(m_uniqueLefts.Count, m_uniqueRights.Count);  // add columns to the grid (based on Left/Right currency counts)
            gridSymbols.Columns.Clear();
            for (int i = 0; i < max; ++i)
            {
                gridSymbols.Columns.Add(i.ToString(), i.ToString());
            }
            int n = 4;
            gridSymbols.Rows.Clear();
            gridSymbols.Rows.Add(n);                            // create (add) 4 rows to the grid
            for (int i = 0; i < m_uniqueLefts.Count; ++i)       // add the "Left" currency symbols to the top row
            {
                gridSymbols[i, 0].Value = m_uniqueLefts[i];
            }
            for (int i = 0; i < m_uniqueRights.Count; ++i)      // add the "Right" currency symbols to the bottom row
            {
                gridSymbols[i, 1].Value = m_uniqueRights[i];
            }
        }

        private void unboldAllExchangeButtons()
        {
            rdoBitstamp.Font = new Font(rdoBitstamp.Font, FontStyle.Regular);
            //rdoBitfinex.Font = new Font(rdoBitfinex.Font, FontStyle.Regular);
        }
        private void rdoBitstamp_CheckedChanged(object sender, EventArgs e)
        {
            cout("Populating CryptoExchange objects...");
            PopulateExchanges();
            PopulateCurrencyGrid();
            unboldAllExchangeButtons();
            rdoBitstamp.Font = new Font(rdoBitstamp.Font, FontStyle.Bold);
        }

        private void gridBalances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)   // Click an EXCHANGE BUTTON
            {
                string text = senderGrid[e.ColumnIndex, e.RowIndex].Value as string;                // This has the EXCHANGE NAME (ex: "Binance")
                //Console.WriteLine("{0} {1} {2}", e.RowIndex, e.ColumnIndex, text);
            }
            else if (e.RowIndex >= 0)                                                               // Click any other column (but NOT a header)
            {
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5)                                       // Click either BID or ASK column
                {
                    txtBuyPrice.Text = senderGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                    txtSellPrice.Text = senderGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 3 || e.ColumnIndex == 6)                                  // Click either BIDSIZE or ASKSIZE column
                {
                    txtBuyQty.Text = senderGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                    txtSellQty.Text = senderGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                }

            }

        }

        int[] m_boldColumn = { -1, -1 };
        private void gridSymbols_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)                                                                    // Click the SYMBOLS grid (but NOT a header)
            {
                string text = senderGrid[e.ColumnIndex, e.RowIndex].Value as string;                // This has the EXCHANGE NAME (ex: "Binance")
                Console.WriteLine("{0} {1} {2}", e.RowIndex, e.ColumnIndex, text);
                unboldSymbolsGrid(e.RowIndex);
                if (m_boldColumn[e.RowIndex] >= 0)
                    boldSymbolsGrid(e.RowIndex, m_boldColumn[e.RowIndex], false);
                boldSymbolsGrid(e.RowIndex, e.ColumnIndex, true);                                   // Make the symbol clicked on BOLD
                m_boldColumn[e.RowIndex] = e.ColumnIndex;
            }
        }

        private void unboldSymbolsGrid(int row)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(gridSymbols.Font, FontStyle.Regular);
            gridSymbols.Rows[row].DefaultCellStyle.ApplyStyle(style);
            //gridSymbols.Rows[row].DefaultCellStyle = style;
            /*var fontRegular = new Font(gridSymbols[0, 0].Style.Font, FontStyle.Regular);
            for (int i = 0; i < gridSymbols.Columns.Count; ++i)
            {
                gridSymbols[i, row].Style.Font = fontRegular;
            }*/
        }

        private void boldSymbolsGrid(int row, int col, bool bold)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            if (bold)
                style.Font = new Font(gridSymbols.Font.FontFamily, gridSymbols.Font.Size, FontStyle.Bold);
            else
                style.Font = new Font(gridSymbols.Font.FontFamily, gridSymbols.Font.Size, FontStyle.Regular);
            gridSymbols[col, row].Style.ApplyStyle(style);
            /*var fontBold = new Font(gridSymbols[0, 0].Style.Font, FontStyle.Bold);
            for (int i = 0; i < gridSymbols.Columns.Count; ++i)
            {
                gridSymbols[i, row].Style.Font = fontBold;
            }*/
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }
    } // end of CLASS


    public class CryptoExchange
    {
        public string Name { get; private set; }
        public CryptoExch Exch { get; private set; }
        public BaseExchange Exchange { get; private set; }
        public SortedDictionary<string, ZCurrencyPair> Pairs { get { return m_pairs; } }

        private SortedDictionary<string, ZCurrencyPair> m_pairs = new SortedDictionary<string, ZCurrencyPair>();
        
        public CryptoExchange(string name)
        {
            Name = name;
            Exch = Crypto.GetExch(name);
            Exchange = Crypto.Exchanges[Exch];
            var symbols = Exchange.GetSymbolList(false);
            foreach (var s in symbols)
            {
                var pair = ZCurrencyPair.FromSymbol(s, Exch);
                m_pairs[pair.Symbol] = pair;                            // Use the OneChain format symbol (ex: "BTC_USD")
            }
        }

        // Does this Exchange trade the given symbol? (in OneChain format, ex: "NEO_ETH")
        public bool HasPair(string symbol)
        {
            return m_pairs.ContainsKey(symbol);
        }


    } // end of class CryptoExchange

} // end of NAMESPACE
