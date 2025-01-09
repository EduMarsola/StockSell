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
        ControleDoBanco controle = new ControleDoBanco();
        //database StockSellMaster
        /*tabela cliente
         * create table clientes(
            CPF varchar(11) not null unique,
            NomeCompleto text,
            DataNascimento date,
            primary key(CPF)
            );
        */

        /*tabela venda
           create table vendas(
            idVenda integer auto_increment,
            idProduto integer not null,
            qtd integer not null,
            dataVenda date,
            primary key(idVenda)
            );
         */

        /*tabela Produto
           create table produtos(
            idProduto integer not null,
            nomeProduto varchar(50),
            qtd integer not null,
            dataEntrada date,
            primary key(idProduto)
            );
         */
        public StockSellHub()
        {
            InitializeComponent();
    

        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(this, controle);
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
            controle.FecharConexao();
            MessageBox.Show("conexão fechada");
        }

        private void button1_Click(object sender, EventArgs e)
        {

    
   
        }


        }
}
