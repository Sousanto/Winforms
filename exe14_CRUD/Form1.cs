using System.Xml;
using System.Xml.Linq;

namespace exe14_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            

            openFileDialog1.Title = "Escolhe o ficheiro XML para a galeria de imagens";
            openFileDialog1.Filter = "Ficheiros XML|*.xml"; // Filtra apenas arquivos XML

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_caminho.Text = openFileDialog1.FileName; // Atualiza o caminho selecionado na TextBox
                CarregarVeiculos();
            }

        }
        private void CarregarVeiculos()
        {
            if (string.IsNullOrWhiteSpace(tb_caminho.Text))
            {
                MessageBox.Show("Selecione um arquivo XML primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);
                lb_automoveis.Items.Clear();

               
                string filtro = cbb_filtro.SelectedItem?.ToString();
                var veiculos = xmlDoc.Descendants("veiculo")
                    .Where(v => filtro == "Todos" ||
                                (filtro == "Novos" && v.Parent?.Attribute("id")?.Value == "novo") ||
                                (filtro == "Usados" && v.Parent?.Attribute("id")?.Value == "usado"))
                    .Select(v => new
                    {
                        Id = v.Attribute("id")?.Value,
                        Marca = v.Element("marca")?.Value,
                        Modelo = v.Element("modelo")?.Value,
                        Preco = v.Element("preco")?.Value,
                        Motor = v.Element("motor")?.Value,
                        Potencia = v.Element("potencia")?.Value,
                        Kms = v.Element("kms")?.Value,
                        Matricula = v.Element("matricula")?.Value
                    })
                    .ToList();

                // Exibe os veículos no ListBox
                foreach (var veiculo in veiculos)
                {
                    lb_automoveis.Items.Add($"{veiculo.Id} - {veiculo.Marca} - {veiculo.Modelo} - {veiculo.Preco}€ - {veiculo.Motor}L - {veiculo.Potencia} - {veiculo.Kms} kms - {veiculo.Matricula}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo XML: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_caminho.Text))
            {
                MessageBox.Show("Selecione um arquivo XML primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_id.Text))
            {
                MessageBox.Show("Por favor, introduza um ID para o veículo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

                // Verifica se o ID já existe
                string novoId = tb_id.Text.Trim();
                bool idExiste = xmlDoc.Descendants("veiculo")
                                      .Any(v => v.Attribute("id")?.Value == novoId);

                if (idExiste)
                {
                    MessageBox.Show("Este ID já está em uso! Escolha outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cria um novo veículo
                XElement novoVeiculo = new XElement("veiculo",
                    new XAttribute("id", novoId), // ID manual inserido pelo utilizador
                    new XElement("marca", tb_marca.Text),
                    new XElement("modelo", tb_modelo.Text),
                    new XElement("preco", tb_preco.Text),
                    new XElement("motor", tb_motor.Text),
                    new XElement("potencia", tb_potencia.Text),
                    new XElement("kms", tb_kms.Text),
                    new XElement("matricula", tb_matricula.Text)
                );

                // Adiciona o veículo à seção correta (novo ou usado)
                string situacao = rb_novo.Checked ? "novo" : "usado";
                XElement categoria = xmlDoc.Descendants("situacao")
                                           .FirstOrDefault(s => s.Attribute("id")?.Value == situacao);

                if (categoria != null)
                {
                    categoria.Add(novoVeiculo);
                }
                else
                {
                    MessageBox.Show("Erro: A categoria 'novo' ou 'usado' não foi encontrada no XML.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Salva o arquivo XML
                xmlDoc.Save(tb_caminho.Text);
                MessageBox.Show("Veículo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a lista de veículos
                CarregarVeiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar veículo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (lb_automoveis.SelectedItem == null)
            {
                MessageBox.Show("Selecione um veículo para alterar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

                // Obtém o ID do veículo selecionado
                string idSelecionado = lb_automoveis.SelectedItem.ToString().Split('-')[0].Trim();

                // Encontra o veículo no XML
                XElement veiculo = xmlDoc.Descendants("veiculo")
                                         .FirstOrDefault(v => v.Attribute("id")?.Value == idSelecionado);

                if (veiculo != null)
                {
                    // Atualiza os dados do veículo
                    veiculo.Element("marca").Value = tb_marca.Text;
                    veiculo.Element("modelo").Value = tb_modelo.Text;
                    veiculo.Element("preco").Value = tb_preco.Text;
                    veiculo.Element("motor").Value = tb_motor.Text;
                    veiculo.Element("potencia").Value = tb_potencia.Text;
                    veiculo.Element("kms").Value = tb_kms.Text;
                    veiculo.Element("matricula").Value = tb_matricula.Text;

                    // Salva o arquivo XML
                    xmlDoc.Save(tb_caminho.Text);
                    MessageBox.Show("Veículo alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza a lista de veículos
                    CarregarVeiculos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar veículo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lb_automoveis.SelectedItem == null)
            {
                MessageBox.Show("Selecione um veículo para eliminar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

                // Obtém o ID do veículo selecionado
                //string idSelecionado = lb_automoveis.SelectedItem.ToString().Split('-')[0].Trim();


                string idSelecionado = tb_id.Text;

                // Encontra e remove o veículo
                XElement veiculo = xmlDoc.Descendants("veiculo")
                                         .FirstOrDefault(v => v.Attribute("id")?.Value == idSelecionado);

                if (veiculo != null)
                {
                    veiculo.Remove();
                    xmlDoc.Save(tb_caminho.Text);
                    MessageBox.Show("Veículo eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza a lista de veículos
                    CarregarVeiculos();
                }


                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar veículo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }

        private void lb_automoveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_automoveis.SelectedItem == null)
                return;

            try
            {
                XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

                // Obtém o ID do veículo selecionado
                string idSelecionado = lb_automoveis.SelectedItem.ToString().Split('-')[0].Trim();

                // Encontra o veículo no XML
                XElement veiculo = xmlDoc.Descendants("veiculo")
                                         .FirstOrDefault(v => v.Attribute("id")?.Value == idSelecionado);

                if (veiculo != null)
                {
                    // Preenche as TextBoxes com os dados do veículo
                    tb_id.Text = veiculo.Attribute("id")?.Value;
                    tb_marca.Text = veiculo.Element("marca")?.Value;
                    tb_modelo.Text = veiculo.Element("modelo")?.Value;
                    tb_preco.Text = veiculo.Element("preco")?.Value;
                    tb_motor.Text = veiculo.Element("motor")?.Value;
                    tb_potencia.Text = veiculo.Element("potencia")?.Value;
                    tb_kms.Text = veiculo.Element("kms")?.Value;
                    tb_matricula.Text = veiculo.Element("matricula")?.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes do veículo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
