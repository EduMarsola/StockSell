using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockSell
{
    public class Prod
    {
        int id;
        string Nome;
        int Quantidade;

        public Prod(int id, string nome, int quantidade)
        {
            this.id = id;
            this.Nome = nome;
            this.Quantidade = quantidade;
        }
    }
    public partial class Venda : Form
    {
        Form1 BackForm;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rd;
        List<Prod> ListaProdutos = new List<Prod>();
        string seDlectItem, sqlBase = "use StockSellMaster";
        string sqlQueue = "insert into Produtos(Nome, Quantidade) Values ('Teste', 30)";
        string sqlQueue1 = "select * from Produtos;";
        string sqlQueue2 = "update Produtos set Quantidade = @Qtd where id = 1";



        public Venda(Form1 fr)
        {
            InitializeComponent();
            BackForm = fr;
            string connectString = "server=localhost; user id=root; password=root; database=StockSellMaster;";
            conn = new MySqlConnection(connectString);
            cmd = new MySqlCommand(sqlQueue1, conn);
            //cmd.Parameters.AddWithValue("@Qtd", int.Parse(QtdTextBox.Text));
            conn.Open();
            rd = cmd.ExecuteReader();
            rd.Read();
            Prod Item = new Prod(0,"",0);
            ListaProdutos.Add(Item);
            rd.NextResult();
            
            rd.Close();
            PreencherLista();
            comboBox1.SelectedIndex = 0;
        }

        private void EnviarButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {

            }
            else
            {
                Error("nonSelect");
            }

        }

        private void Error(string Tipo)
        {
            if (Tipo == "nonSelect")
            {
                labelErro.Text = "Item não selecionado";
            }
        }

        private void PreencherLista()
        {
            try
            {
                cmd = new MySqlCommand("select id from Produtos", conn);
                rd = cmd.ExecuteReader();
                rd.Read();
                comboBox1.Items.Add(rd["id"].ToString());
                rd.Close();
            }
            catch
            {

            }
        }

        private void Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            BackForm.Show();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("select * from Produtos Where id="+comboBox1.SelectedItem.ToString()+";", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            NomeTextBox.Text = rd.GetString("Nome");
            NomeTextBox.Text = rd["Nome"].ToString();
            QtdTextBox.Text = rd["Quantidade"].ToString();
            rd.Close();
        }
    }
}
