namespace exe5
{
    public partial class Form1 : Form
    {
        private int saldo = 1000; // Inicializa o saldo com 1000
        public Form1()
        {
            InitializeComponent();
            lbl_saldo.Text = saldo.ToString(); // Atualiza o rótulo com o saldo inicial
        }

        
        private void btn_jogar_Click(object sender, EventArgs e)
        {
            if (saldo < 50)
            {
                MessageBox.Show("Game Over! Você não tem mais saldo.", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai da função e impede de continuar jogando
            }
            Random aleatorio = new Random();

            for (int i = 0; i < 10; i++) 
            { 
                lbl_num1.Text = aleatorio.Next(0, 10).ToString();
                lbl_num1.Refresh();

                lbl_num2.Text = aleatorio.Next(0, 10).ToString();
                lbl_num2.Refresh();

                lbl_num3.Text = aleatorio.Next(0, 10).ToString();
                lbl_num3.Refresh();

                System.Threading.Thread.Sleep(100);
            }

            // Reduz saldo por jogada
            saldo -= 50;

            // Verifica ganhos
            if (lbl_num1.Text == lbl_num2.Text && lbl_num1.Text == lbl_num3.Text) // 3 iguais
            {
                saldo += 2500;
                MessageBox.Show("Parabéns! Você ganhou 2500!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lbl_num1.Text == lbl_num2.Text || lbl_num1.Text == lbl_num3.Text || lbl_num2.Text == lbl_num3.Text) // 2 iguais
            {
                saldo += 500;
                MessageBox.Show("Você ganhou 500!", "Ganhou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Atualiza o saldo na tela
            lbl_saldo.Text = saldo.ToString();

            // Verifica se o saldo chegou a zero
            if (saldo < 50)
            {
                MessageBox.Show("Game Over! Você ficou sem saldo.", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
