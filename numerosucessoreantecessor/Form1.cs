namespace numerosucessoreantecessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt16(tbnumero.Text);
            int antecessor = numero - 1;
            int sucessor = numero + 1;
            label4.Text = antecessor.ToString();
            label5.Text = sucessor.ToString();
        }
    }
}