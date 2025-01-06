namespace exe6_manipularImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolher a imagem a apresentar";
            openFileDialog1.Filter = "Ficheiros PNG|*.png|Ficheiros JPG|*.jpg|Ficheiros GIF|*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pb_imagem.Image = new Bitmap(openFileDialog1.OpenFile());
                pb_imagem.SizeMode = PictureBoxSizeMode.StretchImage;
                tb_caminho.Text = openFileDialog1.FileName;
            }
            openFileDialog1.Dispose();
        }
    }
}
