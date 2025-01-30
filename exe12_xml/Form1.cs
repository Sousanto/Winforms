using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;

namespace exe12_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolhe o ficheiro XML com os jogos";
            openFileDialog1.Filter = "Ficheiros XML|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_caminho.Text = openFileDialog1.FileName;
            }
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

            var jogos = from jogo in xmlDoc.Descendants("Game")

                        select new
                        {
                            Titulo = jogo.Element("Title").Value,
                            Plataforma = jogo.Element("Platform").Value,
                        };

            foreach (var jogo in jogos)
            {
                rtb_conteudo.Text += jogo.Titulo + " - " + jogo.Plataforma + "\n";
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(tb_caminho.Text);

            XmlNodeList nodeList = doc.SelectNodes("VGames/Game");

            foreach (XmlNode no in nodeList)
            {
                if (!cbb_plataforma.Items.Contains(no.SelectSingleNode("Platform").InnerText))
                {
                    cbb_plataforma.Items.Add(no.SelectSingleNode("Platform").InnerText);
                }

            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            rtb_conteudo.Text = "";
            XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

            var jogos = from jogo in xmlDoc.Descendants("Game")
                        where jogo.Element("Platform").Value == cbb_plataforma.SelectedItem.ToString()
                        select new
                        {
                            Titulo = jogo.Element("Title").Value,
                            Plataforma = jogo.Element("Platform").Value,
                        };

            foreach (var jogo in jogos)
            {
                rtb_conteudo.Text += jogo.Titulo + " - " + jogo.Plataforma + "\n";
            }


        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_caminho.Text))
                {
                    MessageBox.Show("Selecione um arquivo XML primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

                int totalJogos = xmlDoc.Descendants("Game").Count();

                MessageBox.Show($"Total de jogos: {totalJogos}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao contar os jogos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
