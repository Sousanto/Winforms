namespace exe5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
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
        }
    }
}
