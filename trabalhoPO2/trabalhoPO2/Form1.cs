namespace trabalhoPO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void byn_definirvalor_Click(object sender, EventArgs e)
        {
            if((Decimal.Parse(tb_Valor.Text) >= numericUpDown1.Minimum) & (Decimal.Parse(tb_Valor.Text) <= numericUpDown1.Maximum))
            numericUpDown1.Value = Decimal.Parse(tb_Valor.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}