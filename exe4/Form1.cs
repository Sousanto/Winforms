namespace exe4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            lb_formandos.Items.Add(tb_nome.Text);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lb_formandos.Items.Remove(lb_formandos.SelectedItem);
        }
    }
}
