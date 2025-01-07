using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StockSell
{
    public partial class StockSellHub : Form
    {
        static string stringConnection = "SERVER=localhost; PORT = 3306; user id=root; PWD=0; DATABASE=StockSell ";
        private MySqlConnection con = new MySqlConnection(stringConnection);
        public StockSellHub()
        {
            InitializeComponent();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(this);
            cliente.Show();
        }

        private void buttonVenda_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas(this);
            vendas.Show();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos(this);
            produtos.Show();
        }
    }
}
