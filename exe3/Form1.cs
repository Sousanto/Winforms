namespace exe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     

        private void cbb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            clb_modulos.Items.Clear();

            if(cbb_curso.SelectedItem.ToString() == "CET TPSI")
            {
                clb_modulos.Items.Add("Algoritmos");
                clb_modulos.Items.Add("Programação estruturada");
                clb_modulos.Items.Add("Programação Orientada a Objectos");
                clb_modulos.Items.Add("Base da dados");
            }
            else if (cbb_curso.SelectedItem.ToString() == "CET Redes")
            {                
                clb_modulos.Items.Add("Topologias de Rede");
                clb_modulos.Items.Add("Comunicações");
                clb_modulos.Items.Add("Sistemas Operativos");
            }
            else if (cbb_curso.SelectedItem.ToString() == "CET Multimédia")
            {
                clb_modulos.Items.Add("Desing Gráfico");
                clb_modulos.Items.Add("Produção de Conteúdos");
                clb_modulos.Items.Add("Imagem Vectorial");
            }
            else if (cbb_curso.SelectedItem.ToString() == "EFA Robótica")
            {
                clb_modulos.Items.Add("Algoritmos");
                clb_modulos.Items.Add("Eletrónica");
                clb_modulos.Items.Add("Microsoldadura");
            }


        }
    }
}
