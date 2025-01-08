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
        static string stringConnection = "server=localhost; database=StockSellMaster; port=3306; user id=root; password=0";
        private MySqlConnection conn = new MySqlConnection(stringConnection);
        //database StockSellMaster
        /*tabela cliente
         * create table clientes(" +
            "CPF varchar(11) not null unique," +
            "NomeCompleto text," +
            "DataNascimento date," +
            "primary key(CPF)" +
            ");
        */

        /*tabela Produtos
           create table produtos(
            idVenda integer autoincrement,
            idProduto integer not null,
            
            )
         */
public StockSellHub()
{
    InitializeComponent();
    conn.Open();

}

private void buttonCliente_Click(object sender, EventArgs e)
{
    Cliente cliente = new Cliente(this, conn);
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

private void StockSellHub_FormClosing(object sender, FormClosingEventArgs e)
{
    conn.Close();
    MessageBox.Show("conexão fechada");
}

private void button1_Click(object sender, EventArgs e)
{

    MySqlCommand cmd = new MySqlCommand("create table clientes(" +
                                            "CPF varchar(11) not null unique," +
                                            "NomeCompleto text," +
                                            "DataNascimento date," +
                                            "primary key(CPF)" +
                                            ");", conn);
    try
    {
        cmd.ExecuteNonQuery();
        MessageBox.Show("Database criada");
    }
    catch(ArgumentException ex)
    {
        MessageBox.Show(ex.ToString());
    }
}


}
}
