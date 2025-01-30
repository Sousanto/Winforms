using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Avaliacao_30012025_Andre
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    // Carregar o XML e verificar a estrutura
                    XDocument xmlDoc = XDocument.Load(filePath);
                    // Verificar se a estrutura do XML está correta
                    if (xmlDoc.Root.Name == "Catalogo" && xmlDoc.Root.Elements("Filmes").Any() && xmlDoc.Root.Elements("Musicas").Any())
                    {
                        MessageBox.Show("Ficheiro XML carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Ativar os menus
                        AtivarMenus(true);
                    }
                    else
                    {
                        MessageBox.Show("O ficheiro XML não tem a estrutura correta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o ficheiro XML: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AtivarMenus(bool ativar)
        {
            verToolStripMenuItem.Enabled = ativar;
            filtrosToolStripMenuItem.Enabled = ativar;
            adicionarToolStripMenuItem.Enabled = ativar;
            alterarToolStripMenuItem.Enabled = ativar;
            eliminarToolStripMenuItem.Enabled = ativar;
        }

        private void todosOsItensToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml"; // Filtro para selecionar apenas ficheiros XML
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o diálogo e verificar se o usuário selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Extrair filmes
                    var filmes = xmlDoc.Descendants("Filme").Select(f => new
                    {
                        Tipo = "Filme",
                        Titulo = f.Element("Titulo").Value,
                        Genero = f.Element("Genero").Value,
                        Ano = f.Element("Ano").Value
                    }).ToList();

                    // Extrair músicas
                    var musicas = xmlDoc.Descendants("Musica").Select(m => new
                    {
                        Tipo = "Música",
                        Titulo = m.Element("Titulo").Value,
                        Artista = m.Element("Artista").Value,
                        Genero = m.Element("Genero").Value
                    }).ToList();

                    // Limpar o RichTextBox antes de adicionar novos dados
                    rtb_quadro.Clear();

                    // Adicionar filmes ao RichTextBox
                    rtb_quadro.AppendText("=== Filmes ===\n");
                    foreach (var filme in filmes)
                    {
                        rtb_quadro.AppendText($"Tipo: {filme.Tipo}\n");
                        rtb_quadro.AppendText($"Título: {filme.Titulo}\n");
                        rtb_quadro.AppendText($"Gênero: {filme.Genero}\n");
                        rtb_quadro.AppendText($"Ano: {filme.Ano}\n");
                        rtb_quadro.AppendText("-----------------\n");
                    }

                    // Adicionar músicas ao RichTextBox
                    rtb_quadro.AppendText("=== Músicas ===\n");
                    foreach (var musica in musicas)
                    {
                        rtb_quadro.AppendText($"Tipo: {musica.Tipo}\n");
                        rtb_quadro.AppendText($"Título: {musica.Titulo}\n");
                        rtb_quadro.AppendText($"Artista: {musica.Artista}\n");
                        rtb_quadro.AppendText($"Gênero: {musica.Genero}\n");
                        rtb_quadro.AppendText("-----------------\n");
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro não puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usuário cancelou a seleção do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sairDaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apenasFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o diálogo e verificar se o usuário selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Extrair apenas filmes
                    var filmes = xmlDoc.Descendants("Filme").Select(f => new
                    {
                        Tipo = "Filme",
                        Titulo = f.Element("Titulo").Value,
                        Genero = f.Element("Genero").Value,
                        Ano = f.Element("Ano").Value
                    }).ToList();

                    // Limpar o RichTextBox antes de adicionar novos dados
                    rtb_quadro.Clear();

                    // Adicionar filmes ao RichTextBox
                    rtb_quadro.AppendText("=== Filmes ===\n");
                    foreach (var filme in filmes)
                    {
                        rtb_quadro.AppendText($"Tipo: {filme.Tipo}\n");
                        rtb_quadro.AppendText($"Título: {filme.Titulo}\n");
                        rtb_quadro.AppendText($"Gênero: {filme.Genero}\n");
                        rtb_quadro.AppendText($"Ano: {filme.Ano}\n");
                        rtb_quadro.AppendText("-----------------\n");
                    }

                    // Exibir o número total de filmes
                    rtb_quadro.AppendText($"\nTotal de filmes: {filmes.Count}\n");
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro não puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usuário cancelou a seleção do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void apenasMúsicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o diálogo e verificar se o usuário selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Extrair apenas músicas
                    var musicas = xmlDoc.Descendants("Musica").Select(m => new
                    {
                        Tipo = "Música",
                        Titulo = m.Element("Titulo").Value,
                        Artista = m.Element("Artista").Value,
                        Genero = m.Element("Genero").Value
                    }).ToList();

                    // Limpar o RichTextBox antes de adicionar novos dados
                    rtb_quadro.Clear();

                    // Adicionar músicas ao RichTextBox
                    rtb_quadro.AppendText("=== Músicas ===\n");
                    foreach (var musica in musicas)
                    {
                        rtb_quadro.AppendText($"Tipo: {musica.Tipo}\n");
                        rtb_quadro.AppendText($"Título: {musica.Titulo}\n");
                        rtb_quadro.AppendText($"Artista: {musica.Artista}\n");
                        rtb_quadro.AppendText($"Gênero: {musica.Genero}\n");
                        rtb_quadro.AppendText("-----------------\n");
                    }

                    // Exibir o número total de músicas
                    rtb_quadro.AppendText($"\nTotal de músicas: {musicas.Count}\n");
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro não puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usuário cancelou a seleção do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void filtrarMúsicasPorGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o diálogo e verificar se o usuário selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Extrair todos os géneros de músicas disponíveis
                    var generosMusicas = xmlDoc.Descendants("Musica")
                                               .Select(m => m.Element("Genero").Value)
                                               .Distinct()
                                               .ToList();

                    // Criar uma caixa de diálogo para o usuário escolher um género
                    using (Form dialogo = new Form())
                    {
                        dialogo.Text = "Selecione o género da música";
                        dialogo.Size = new System.Drawing.Size(300, 150);

                        // Criar uma ComboBox para selecionar o género
                        ComboBox comboBoxGeneros = new ComboBox();
                        comboBoxGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
                        comboBoxGeneros.DataSource = generosMusicas;
                        comboBoxGeneros.Location = new System.Drawing.Point(20, 20);
                        comboBoxGeneros.Size = new System.Drawing.Size(200, 20);

                        // Criar um botão "OK"
                        Button botaoOK = new Button();
                        botaoOK.Text = "OK";
                        botaoOK.DialogResult = DialogResult.OK;
                        botaoOK.Location = new System.Drawing.Point(100, 60);

                        // Adicionar controles ao formulário
                        dialogo.Controls.Add(comboBoxGeneros);
                        dialogo.Controls.Add(botaoOK);

                        // Exibir o diálogo e verificar se o usuário selecionou um género
                        if (dialogo.ShowDialog() == DialogResult.OK)
                        {
                            string generoSelecionado = comboBoxGeneros.SelectedItem.ToString();

                            // Filtrar músicas pelo género selecionado
                            var musicasFiltradas = xmlDoc.Descendants("Musica")
                                                         .Where(m => m.Element("Genero").Value == generoSelecionado)
                                                         .Select(m => new
                                                         {
                                                             Tipo = "Música",
                                                             Titulo = m.Element("Titulo").Value,
                                                             Artista = m.Element("Artista").Value,
                                                             Genero = m.Element("Genero").Value
                                                         }).ToList();

                            // Limpar o RichTextBox antes de adicionar novos dados
                            rtb_quadro.Clear();

                            // Adicionar músicas filtradas ao RichTextBox
                            rtb_quadro.AppendText($"=== Músicas do Género: {generoSelecionado} ===\n");
                            foreach (var musica in musicasFiltradas)
                            {
                                rtb_quadro.AppendText($"Tipo: {musica.Tipo}\n");
                                rtb_quadro.AppendText($"Título: {musica.Titulo}\n");
                                rtb_quadro.AppendText($"Artista: {musica.Artista}\n");
                                rtb_quadro.AppendText($"Gênero: {musica.Genero}\n");
                                rtb_quadro.AppendText("-----------------\n");
                            }

                            // Exibir o número total de músicas do género selecionado
                            rtb_quadro.AppendText($"\nTotal de músicas do género {generoSelecionado}: {musicasFiltradas.Count}\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro não puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usuário cancelou a seleção do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void filtrarFilmesPorGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o diálogo e verificar se o usuário selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Extrair todos os géneros de filmes disponíveis
                    var generosFilmes = xmlDoc.Descendants("Filme")
                                              .Select(f => f.Element("Genero").Value)
                                              .Distinct()
                                              .ToList();

                    // Criar uma caixa de diálogo para o usuário escolher um género
                    using (Form dialogo = new Form())
                    {
                        dialogo.Text = "Selecione o género do filme";
                        dialogo.Size = new System.Drawing.Size(300, 150);

                        // Criar uma ComboBox para selecionar o género
                        ComboBox comboBoxGeneros = new ComboBox();
                        comboBoxGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
                        comboBoxGeneros.DataSource = generosFilmes;
                        comboBoxGeneros.Location = new System.Drawing.Point(20, 20);
                        comboBoxGeneros.Size = new System.Drawing.Size(200, 20);

                        // Criar um botão "OK"
                        Button botaoOK = new Button();
                        botaoOK.Text = "OK";
                        botaoOK.DialogResult = DialogResult.OK;
                        botaoOK.Location = new System.Drawing.Point(100, 60);

                        // Adicionar controles ao formulário
                        dialogo.Controls.Add(comboBoxGeneros);
                        dialogo.Controls.Add(botaoOK);

                        // Exibir o diálogo e verificar se o usuário selecionou um género
                        if (dialogo.ShowDialog() == DialogResult.OK)
                        {
                            string generoSelecionado = comboBoxGeneros.SelectedItem.ToString();

                            // Filtrar filmes pelo género selecionado
                            var filmesFiltrados = xmlDoc.Descendants("Filme")
                                                        .Where(f => f.Element("Genero").Value == generoSelecionado)
                                                        .Select(f => new
                                                        {
                                                            Tipo = "Filme",
                                                            Titulo = f.Element("Titulo").Value,
                                                            Genero = f.Element("Genero").Value,
                                                            Ano = f.Element("Ano").Value
                                                        }).ToList();

                            // Limpar o RichTextBox antes de adicionar novos dados
                            rtb_quadro.Clear();

                            // Adicionar filmes filtrados ao RichTextBox
                            rtb_quadro.AppendText($"=== Filmes do Género: {generoSelecionado} ===\n");
                            foreach (var filme in filmesFiltrados)
                            {
                                rtb_quadro.AppendText($"Tipo: {filme.Tipo}\n");
                                rtb_quadro.AppendText($"Título: {filme.Titulo}\n");
                                rtb_quadro.AppendText($"Gênero: {filme.Genero}\n");
                                rtb_quadro.AppendText($"Ano: {filme.Ano}\n");
                                rtb_quadro.AppendText("-----------------\n");
                            }

                            // Exibir o número total de filmes do género selecionado
                            rtb_quadro.AppendText($"\nTotal de filmes do género {generoSelecionado}: {filmesFiltrados.Count}\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro não puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usuário cancelou a seleção do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adicionarFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e exibir o formulário de adição de filme
            FormAdicionarFilme formAdicionarFilme = new FormAdicionarFilme();
            if (formAdicionarFilme.ShowDialog() == DialogResult.OK)
            {
                // Obter os dados do formulário
                string titulo = formAdicionarFilme.Titulo;
                string genero = formAdicionarFilme.Genero;
                string ano = formAdicionarFilme.Ano;

                // Adicionar o novo filme ao XML
                AdicionarFilmeAoXML(titulo, genero, ano);
            }
        }

        private void AdicionarFilmeAoXML(string titulo, string genero, string ano)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o diálogo e verificar se o usuário selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Criar um novo elemento <Filme>
                    XElement novoFilme = new XElement("Filme",
                        new XElement("Titulo", titulo),
                        new XElement("Genero", genero),
                        new XElement("Ano", ano)
                    );

                    // Adicionar o novo filme ao elemento <Filmes>
                    xmlDoc.Element("Catalogo").Element("Filmes").Add(novoFilme);

                    // Salvar o ficheiro XML atualizado
                    xmlDoc.Save(openFileDialog.FileName);

                    // Exibir mensagem de sucesso
                    MessageBox.Show("Filme adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro não puder ser carregado ou salvo
                    MessageBox.Show($"Erro ao adicionar o filme: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usuário cancelou a seleção do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adicionarMúsicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e exibir o formulário de adição de música
            FormAdicionarMusica formAdicionarMusica = new FormAdicionarMusica();
            if (formAdicionarMusica.ShowDialog() == DialogResult.OK)
            {
                // Obter os dados do formulário
                string titulo = formAdicionarMusica.Titulo;
                string artista = formAdicionarMusica.Artista;
                string genero = formAdicionarMusica.Genero;

                // Adicionar a nova música ao XML
                AdicionarMusicaAoXML(titulo, artista, genero);
            }
        }

        private void AdicionarMusicaAoXML(string titulo, string artista, string genero)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o diálogo e verificar se o usuário selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Criar um novo elemento <Musica>
                    XElement novaMusica = new XElement("Musica",
                        new XElement("Titulo", titulo),
                        new XElement("Artista", artista),
                        new XElement("Genero", genero)
                    );

                    // Adicionar a nova música ao elemento <Musicas>
                    xmlDoc.Element("Catalogo").Element("Musicas").Add(novaMusica);

                    // Salvar o ficheiro XML atualizado
                    xmlDoc.Save(openFileDialog.FileName);

                    // Exibir mensagem de sucesso
                    MessageBox.Show("Música adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro não puder ser carregado ou salvo
                    MessageBox.Show($"Erro ao adicionar a música: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usuário cancelou a seleção do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
