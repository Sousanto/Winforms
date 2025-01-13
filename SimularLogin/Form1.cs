namespace SimularLogin
{
    /*
     * Form1:
	-Utilizador (textbox)
	-Palavra-Passe (textbox)
	-Mensagem (Label)
	Se o utilizador for igual a "admin" e a palavra-passe igual a cinel, fecha o form1 e abre o form "app"
 
app:
	-Menu com a opção "Sair" que lance uma messageBox e pergunta ao utilizador se pretende terminar a sessão (SIM/NÃO)
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string utilizador = tb_utilizador.Text;  // Obtém o texto do TextBox Utilizador
            string palavraPasse = tb_palavrapasse.Text;  // Obtém o texto do TextBox Palavra-Passe

            if (utilizador == "admin" && palavraPasse == "cinel")
            {
                // Abre o Form "App" e fecha o Form1
                App appForm = new App();
                appForm.Show();
                this.Hide();
            }
            else
            {
                lb_mensagem.Text = "Utilizador ou Palavra-Passe incorretos!";
                lb_mensagem.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
