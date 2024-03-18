namespace StockSell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VendaButton_Click(object sender, EventArgs e)
        {
            Venda Ven = new Venda(this);
            Ven.Show();
            this.Hide();
        }

        private void CadastroButton_Click(object sender, EventArgs e)
        {
            Cadastro Cad = new Cadastro(this);
            Cad.Show();
            this.Hide();
        }

        private void RemessaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
