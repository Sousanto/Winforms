namespace exe7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            int resposta = Convert.ToInt32(MessageBox.Show("Pretende SAIR ?", "Mensagem",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (resposta == 6) 
            {
                Application.Exit();
            }
        }
    }
}
