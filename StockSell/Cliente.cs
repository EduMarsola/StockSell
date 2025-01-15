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
        private ControleDoBanco controle;
        public Cliente(StockSellHub hubVolta, ControleDoBanco con)
        {
            InitializeComponent();
            hub = hubVolta;
            controle = con;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            hub.Show();
            this.Dispose();
        }

        private void buttonCadastrarCadastro_Click(object sender, EventArgs e)
        {
            if(ChecarDados())
            {
                controle.MudarComando(" insert into Clientes " +
                    "(CPF, NomeCompleto, DataNascimento) " +
                    "values ("+maskedTextBoxCPF.Text+", "+textBoxNome.Text+", "+textBoxNascimento.Text+");");
                try { controle.Execultar(); }
                catch (Exception ex) { controle.FecharConexao(); MessageBox.Show("Erro ao cadastrar" + ex); };
            }
            
        }

        private bool ChecarDados()
        {
            if(textBoxNome.Text == "" || textBoxNome.Text == null) { MessageBox.Show("Nome em branco"); }
            if(textBoxNascimento.Text == "" || textBoxNascimento.Text == null) { MessageBox.Show("Data de nascimento vazia"); }
            if(maskedTextBoxCPF.Text == "" || maskedTextBoxCPF.Text == null || !CPFValidado())
            {
                MessageBox.Show("CPF não pode estar em branco");
                return false;
            }
            else { return true; }

        }

        private bool CPFValidado()
        {
            return true;
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            try { MySqlDataReader rd = controle.ExecultarReceber("select * from Cliente"); }
            catch(Exception ex) { MessageBox.Show(ex.Message); } 

        }
    }
}
