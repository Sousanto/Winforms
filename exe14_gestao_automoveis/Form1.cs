using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace exe14_gestao_automoveis
{
//    /*
//     Exercício prático
//O objetivo será o desenvolvimento de uma aplicação em Windows Forms que permita a
//gestão de um stand de automóveis existente no ficheiro de XML
//“ListaAutomoveis.xml”.
//Funcionalidades a desenvolver:
//• Ficheiro:
//o Abrir XML
//o Sair da aplicação
//• Ver
//o Todos os veículos existentes no ficheiro XML (novos e usados)
//o Apenas os veículos novos
//o Apenas os veículos usados
//• Adicionar
//o Possibilidade de adicionar um veículo ao XML
//• Alterar
//o Possibilidade de alterar um veículo no XML
//• Eliminar
//o Possibilidade de eliminar um veículo no XML
//     */

    public partial class Form1 : Form
   {
       public Form1()
       {
           InitializeComponent();
       }

      private void btn_escolher_Click(object sender, EventArgs e)
       {
            openFileDialog1.Title = "Escolhe o ficheiro XML com a lista de automóveis";
           openFileDialog1.Filter = "Ficheiros XML|*.xml";

          if (openFileDialog1.ShowDialog() == DialogResult.OK)
          {
               tb_caminho.Text = openFileDialog1.FileName;
           }     }

        private void btn_sair_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

        private void btn_ver_Click(object sender, EventArgs e)
       {
            if (string.IsNullOrWhiteSpace(tb_caminho.Text))
            {
                MessageBox.Show("Por favor, escolha um arquivo XML primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }

            try
            {
                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

                // Obtém todos os veículos
                var automoveis = xmlDoc.Descendants("veiculo")
                    .Select(automovel => new
                    {
                        Id = automovel.Attribute("id")?.Value,
                        Marca = automovel.Element("marca")?.Value,
                        Modelo = automovel.Element("modelo")?.Value,
                        Preco = automovel.Element("preco")?.Value,
                        Motor = automovel.Element("motor")?.Value,
                        Potencia = automovel.Element("potencia")?.Value,
                        Kms = automovel.Element("kms")?.Value,
                        Matricula = automovel.Element("matricula")?.Value
                    })
                    .ToList();

                // Exibe os veículos corretamente
                lb_automoveis.Items.Clear();  // Se for um ListBox
                foreach (var automovel in automoveis)
                {
                    string veiculoInfo = $"{automovel.Id} - {automovel.Marca} - {automovel.Modelo} - {automovel.Preco}€ - {automovel.Motor}L - {automovel.Potencia} - {automovel.Kms} kms - {automovel.Matricula}";
                    lb_automoveis.Items.Add(veiculoInfo);
                }

                // Atualiza a ComboBox com as matrículas dos veículos usados
                cbb_veiculos.Items.Clear();
                var matriculas = xmlDoc.Descendants("situacao")
                    .Where(s => s.Attribute("id")?.Value == "usado")
                    .Descendants("veiculo")
                    .Select(v => v.Element("matricula")?.Value)
                    .Where(m => !string.IsNullOrWhiteSpace(m))
                    .Distinct();

                foreach (var mat in matriculas)
                {
                    cbb_veiculos.Items.Add(mat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo XML:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_caminho.Text))
            {
                MessageBox.Show("Por favor, escolha um arquivo XML primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

                // Cria um novo veículo
                XElement novoVeiculo = new XElement("veiculo",
                    new XAttribute("id", Guid.NewGuid().ToString()),
                   new XElement("marca", tb_marca.Text),
                    new XElement("modelo", tb_modelo.Text),
                    new XElement("preco", tb_preco.Text),
                    new XElement("motor", tb_motor.Text),
                    new XElement("potencia", tb_potencia.Text),
                    new XElement("kms", tb_kms.Text),
                    new XElement("matricula", tb_matriculas.Text)
                );

                // Adiciona o veículo à situação correta (novo ou usado)
                string situacao = rb_novo.Checked ? "novo" : "usado";
                xmlDoc.Descendants("situacao")
                      .FirstOrDefault(s => s.Attribute("id")?.Value == situacao)?
                      .Add(novoVeiculo);

                // Salva o arquivo XML
                xmlDoc.Save(tb_caminho.Text);
                MessageBox.Show("Veículo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a lista de veículos
                btn_ver_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar veículo:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_iliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_caminho.Text))
            {
                MessageBox.Show("Por favor, escolha um arquivo XML primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lb_automoveis.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um veículo para eliminar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

                // Obtém o ID do veículo selecionado
                string idSelecionado = lb_automoveis.SelectedItem.ToString().Split('-')[0].Trim();

                // Encontra o veículo no XML e remove
                XElement veiculo = xmlDoc.Descendants("veiculo")
                                         .FirstOrDefault(v => v.Attribute("id")?.Value == idSelecionado);

                if (veiculo != null)
                {
                    veiculo.Remove();
                    xmlDoc.Save(tb_caminho.Text);
                    MessageBox.Show("Veículo eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza a lista de veículos
                    btn_ver_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar veículo:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}



