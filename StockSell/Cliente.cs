using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockSell
{
    public partial class Cliente : Form
    {
        private StockSellHub hub;
        private MySqlConnection conn;
        public Cliente(StockSellHub hubVolta, MySqlConnection con)
        {
            InitializeComponent();
            hub = hubVolta;
            conn = con;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            hub.Show();
            this.Dispose();
        }
    }
}
