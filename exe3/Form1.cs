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
                clb_modulos.Items.Add("Programa��o estruturada");
                clb_modulos.Items.Add("Programa��o Orientada a Objectos");
                clb_modulos.Items.Add("Base da dados");
            }
            else if (cbb_curso.SelectedItem.ToString() == "CET Redes")
            {                
                clb_modulos.Items.Add("Topologias de Rede");
                clb_modulos.Items.Add("Comunica��es");
                clb_modulos.Items.Add("Sistemas Operativos");
            }
            else if (cbb_curso.SelectedItem.ToString() == "CET Multim�dia")
            {
                clb_modulos.Items.Add("Desing Gr�fico");
                clb_modulos.Items.Add("Produ��o de Conte�dos");
                clb_modulos.Items.Add("Imagem Vectorial");
            }
            else if (cbb_curso.SelectedItem.ToString() == "EFA Rob�tica")
            {
                clb_modulos.Items.Add("Algoritmos");
                clb_modulos.Items.Add("Eletr�nica");
                clb_modulos.Items.Add("Microsoldadura");
            }


        }
    }
}
