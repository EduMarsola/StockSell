using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSell
{
    public partial class Vendas : Form
    {
        StockSellHub hub;
        public Vendas(StockSellHub hubVolta)
        {
            InitializeComponent();
            hub = hubVolta;
        }
    }
}
