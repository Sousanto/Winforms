namespace exe2_visibleEenable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_data_Click(object sender, EventArgs e)
        {

        }
        // Verifica se a opção selecionada no ComboBox é "Outro"
        private void cbb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_curso.SelectedItem.ToString() == "Outro")
            {
                panel1.Visible = true;// Exibe o painel1 se "Outro" for selecionado
                panel2.Enabled = true;// Habilita o painel2
            }
            else
            {
                panel1.Visible = false;// Oculta o painel1 para outras opções
                panel2.Enabled = false;// Desabilita o painel2
            }
        }
    }
}
