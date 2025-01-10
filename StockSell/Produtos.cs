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
    public partial class Produtos : Form
    {
        StockSellHub hub;
        ControleDoBanco controle;
        public Produtos(StockSellHub hubVolta, ControleDoBanco con)
        {
            InitializeComponent();
            hub = hubVolta;
            controle = con;
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            if (ChecarDados())
            {
                controle.AbrirConexao();
                controle.MudarComando("insert into produtos " +
                    "(nomeProduto, qtd) " +
                    "values (" + textBoxNome.Text + ", " + Convert.ToInt64(maskedTextBoxQuatidade.Text) + ");");
                try { controle.ExecultarFechar(); }
                catch (Exception ex) { controle.FecharConexao(); MessageBox.Show("Erro ao cadastrar" + ex); };

            }
           
        }
        private bool ChecarDados()
        {
            if(maskedTextBoxQuatidade.Text == "" || maskedTextBoxQuatidade.Text == null) { return false; }
            else { return true; }
        }

        private void buttonCancelarConsulta_Click(object sender, EventArgs e)
        {
            hub.Show();
            this.Dispose();
        }
    }
}
