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
    public partial class ProdExpose : Form
    {
        public ProdExpose()
        {
            InitializeComponent();
            Populate();
        }
        private void Populate()
        {
            panel1.Controls.Add(new Prod());
        }
    }
}
