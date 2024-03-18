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

namespace StockSell
{
    public partial class Cadastro : Form
    {
        Form1 BackForm;
        public Cadastro(Form1 fr)
        {
            InitializeComponent();
            BackForm = fr;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            BackForm.Show();
            this.Dispose();
        }

        private void QtdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
            }
        }

        private void EnviarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
