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
                    // Verificar se a estrutura do XML est� correta
                    if (xmlDoc.Root.Name == "Catalogo" && xmlDoc.Root.Elements("Filmes").Any() && xmlDoc.Root.Elements("Musicas").Any())
                    {
                        MessageBox.Show("Ficheiro XML carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Ativar os menus
                        AtivarMenus(true);
                    }
                    else
                    {
                        MessageBox.Show("O ficheiro XML n�o tem a estrutura correta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Exibir o di�logo e verificar se o usu�rio selecionou um ficheiro
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

                    // Extrair m�sicas
                    var musicas = xmlDoc.Descendants("Musica").Select(m => new
                    {
                        Tipo = "M�sica",
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
                        rtb_quadro.AppendText($"T�tulo: {filme.Titulo}\n");
                        rtb_quadro.AppendText($"G�nero: {filme.Genero}\n");
                        rtb_quadro.AppendText($"Ano: {filme.Ano}\n");
                        rtb_quadro.AppendText("-----------------\n");
                    }

                    // Adicionar m�sicas ao RichTextBox
                    rtb_quadro.AppendText("=== M�sicas ===\n");
                    foreach (var musica in musicas)
                    {
                        rtb_quadro.AppendText($"Tipo: {musica.Tipo}\n");
                        rtb_quadro.AppendText($"T�tulo: {musica.Titulo}\n");
                        rtb_quadro.AppendText($"Artista: {musica.Artista}\n");
                        rtb_quadro.AppendText($"G�nero: {musica.Genero}\n");
                        rtb_quadro.AppendText("-----------------\n");
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro n�o puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usu�rio cancelou a sele��o do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sairDaAplica��oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apenasFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o di�logo e verificar se o usu�rio selecionou um ficheiro
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
                        rtb_quadro.AppendText($"T�tulo: {filme.Titulo}\n");
                        rtb_quadro.AppendText($"G�nero: {filme.Genero}\n");
                        rtb_quadro.AppendText($"Ano: {filme.Ano}\n");
                        rtb_quadro.AppendText("-----------------\n");
                    }

                    // Exibir o n�mero total de filmes
                    rtb_quadro.AppendText($"\nTotal de filmes: {filmes.Count}\n");
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro n�o puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usu�rio cancelou a sele��o do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void apenasM�sicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o di�logo e verificar se o usu�rio selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Extrair apenas m�sicas
                    var musicas = xmlDoc.Descendants("Musica").Select(m => new
                    {
                        Tipo = "M�sica",
                        Titulo = m.Element("Titulo").Value,
                        Artista = m.Element("Artista").Value,
                        Genero = m.Element("Genero").Value
                    }).ToList();

                    // Limpar o RichTextBox antes de adicionar novos dados
                    rtb_quadro.Clear();

                    // Adicionar m�sicas ao RichTextBox
                    rtb_quadro.AppendText("=== M�sicas ===\n");
                    foreach (var musica in musicas)
                    {
                        rtb_quadro.AppendText($"Tipo: {musica.Tipo}\n");
                        rtb_quadro.AppendText($"T�tulo: {musica.Titulo}\n");
                        rtb_quadro.AppendText($"Artista: {musica.Artista}\n");
                        rtb_quadro.AppendText($"G�nero: {musica.Genero}\n");
                        rtb_quadro.AppendText("-----------------\n");
                    }

                    // Exibir o n�mero total de m�sicas
                    rtb_quadro.AppendText($"\nTotal de m�sicas: {musicas.Count}\n");
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro n�o puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usu�rio cancelou a sele��o do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void filtrarM�sicasPorG�neroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o di�logo e verificar se o usu�rio selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Extrair todos os g�neros de m�sicas dispon�veis
                    var generosMusicas = xmlDoc.Descendants("Musica")
                                               .Select(m => m.Element("Genero").Value)
                                               .Distinct()
                                               .ToList();

                    // Criar uma caixa de di�logo para o usu�rio escolher um g�nero
                    using (Form dialogo = new Form())
                    {
                        dialogo.Text = "Selecione o g�nero da m�sica";
                        dialogo.Size = new System.Drawing.Size(300, 150);

                        // Criar uma ComboBox para selecionar o g�nero
                        ComboBox comboBoxGeneros = new ComboBox();
                        comboBoxGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
                        comboBoxGeneros.DataSource = generosMusicas;
                        comboBoxGeneros.Location = new System.Drawing.Point(20, 20);
                        comboBoxGeneros.Size = new System.Drawing.Size(200, 20);

                        // Criar um bot�o "OK"
                        Button botaoOK = new Button();
                        botaoOK.Text = "OK";
                        botaoOK.DialogResult = DialogResult.OK;
                        botaoOK.Location = new System.Drawing.Point(100, 60);

                        // Adicionar controles ao formul�rio
                        dialogo.Controls.Add(comboBoxGeneros);
                        dialogo.Controls.Add(botaoOK);

                        // Exibir o di�logo e verificar se o usu�rio selecionou um g�nero
                        if (dialogo.ShowDialog() == DialogResult.OK)
                        {
                            string generoSelecionado = comboBoxGeneros.SelectedItem.ToString();

                            // Filtrar m�sicas pelo g�nero selecionado
                            var musicasFiltradas = xmlDoc.Descendants("Musica")
                                                         .Where(m => m.Element("Genero").Value == generoSelecionado)
                                                         .Select(m => new
                                                         {
                                                             Tipo = "M�sica",
                                                             Titulo = m.Element("Titulo").Value,
                                                             Artista = m.Element("Artista").Value,
                                                             Genero = m.Element("Genero").Value
                                                         }).ToList();

                            // Limpar o RichTextBox antes de adicionar novos dados
                            rtb_quadro.Clear();

                            // Adicionar m�sicas filtradas ao RichTextBox
                            rtb_quadro.AppendText($"=== M�sicas do G�nero: {generoSelecionado} ===\n");
                            foreach (var musica in musicasFiltradas)
                            {
                                rtb_quadro.AppendText($"Tipo: {musica.Tipo}\n");
                                rtb_quadro.AppendText($"T�tulo: {musica.Titulo}\n");
                                rtb_quadro.AppendText($"Artista: {musica.Artista}\n");
                                rtb_quadro.AppendText($"G�nero: {musica.Genero}\n");
                                rtb_quadro.AppendText("-----------------\n");
                            }

                            // Exibir o n�mero total de m�sicas do g�nero selecionado
                            rtb_quadro.AppendText($"\nTotal de m�sicas do g�nero {generoSelecionado}: {musicasFiltradas.Count}\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro n�o puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usu�rio cancelou a sele��o do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void filtrarFilmesPorG�neroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o di�logo e verificar se o usu�rio selecionou um ficheiro
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar o ficheiro XML selecionado
                    XDocument xmlDoc = XDocument.Load(openFileDialog.FileName);

                    // Extrair todos os g�neros de filmes dispon�veis
                    var generosFilmes = xmlDoc.Descendants("Filme")
                                              .Select(f => f.Element("Genero").Value)
                                              .Distinct()
                                              .ToList();

                    // Criar uma caixa de di�logo para o usu�rio escolher um g�nero
                    using (Form dialogo = new Form())
                    {
                        dialogo.Text = "Selecione o g�nero do filme";
                        dialogo.Size = new System.Drawing.Size(300, 150);

                        // Criar uma ComboBox para selecionar o g�nero
                        ComboBox comboBoxGeneros = new ComboBox();
                        comboBoxGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
                        comboBoxGeneros.DataSource = generosFilmes;
                        comboBoxGeneros.Location = new System.Drawing.Point(20, 20);
                        comboBoxGeneros.Size = new System.Drawing.Size(200, 20);

                        // Criar um bot�o "OK"
                        Button botaoOK = new Button();
                        botaoOK.Text = "OK";
                        botaoOK.DialogResult = DialogResult.OK;
                        botaoOK.Location = new System.Drawing.Point(100, 60);

                        // Adicionar controles ao formul�rio
                        dialogo.Controls.Add(comboBoxGeneros);
                        dialogo.Controls.Add(botaoOK);

                        // Exibir o di�logo e verificar se o usu�rio selecionou um g�nero
                        if (dialogo.ShowDialog() == DialogResult.OK)
                        {
                            string generoSelecionado = comboBoxGeneros.SelectedItem.ToString();

                            // Filtrar filmes pelo g�nero selecionado
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
                            rtb_quadro.AppendText($"=== Filmes do G�nero: {generoSelecionado} ===\n");
                            foreach (var filme in filmesFiltrados)
                            {
                                rtb_quadro.AppendText($"Tipo: {filme.Tipo}\n");
                                rtb_quadro.AppendText($"T�tulo: {filme.Titulo}\n");
                                rtb_quadro.AppendText($"G�nero: {filme.Genero}\n");
                                rtb_quadro.AppendText($"Ano: {filme.Ano}\n");
                                rtb_quadro.AppendText("-----------------\n");
                            }

                            // Exibir o n�mero total de filmes do g�nero selecionado
                            rtb_quadro.AppendText($"\nTotal de filmes do g�nero {generoSelecionado}: {filmesFiltrados.Count}\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro n�o puder ser carregado
                    MessageBox.Show($"Erro ao carregar o ficheiro XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usu�rio cancelou a sele��o do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adicionarFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e exibir o formul�rio de adi��o de filme
            FormAdicionarFilme formAdicionarFilme = new FormAdicionarFilme();
            if (formAdicionarFilme.ShowDialog() == DialogResult.OK)
            {
                // Obter os dados do formul�rio
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

            // Exibir o di�logo e verificar se o usu�rio selecionou um ficheiro
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
                    // Exibir mensagem de erro se o ficheiro n�o puder ser carregado ou salvo
                    MessageBox.Show($"Erro ao adicionar o filme: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usu�rio cancelou a sele��o do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adicionarM�sicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar e exibir o formul�rio de adi��o de m�sica
            FormAdicionarMusica formAdicionarMusica = new FormAdicionarMusica();
            if (formAdicionarMusica.ShowDialog() == DialogResult.OK)
            {
                // Obter os dados do formul�rio
                string titulo = formAdicionarMusica.Titulo;
                string artista = formAdicionarMusica.Artista;
                string genero = formAdicionarMusica.Genero;

                // Adicionar a nova m�sica ao XML
                AdicionarMusicaAoXML(titulo, artista, genero);
            }
        }

        private void AdicionarMusicaAoXML(string titulo, string artista, string genero)
        {
            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecione o ficheiro XML";

            // Exibir o di�logo e verificar se o usu�rio selecionou um ficheiro
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

                    // Adicionar a nova m�sica ao elemento <Musicas>
                    xmlDoc.Element("Catalogo").Element("Musicas").Add(novaMusica);

                    // Salvar o ficheiro XML atualizado
                    xmlDoc.Save(openFileDialog.FileName);

                    // Exibir mensagem de sucesso
                    MessageBox.Show("M�sica adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro se o ficheiro n�o puder ser carregado ou salvo
                    MessageBox.Show($"Erro ao adicionar a m�sica: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // O usu�rio cancelou a sele��o do ficheiro
                MessageBox.Show("Nenhum ficheiro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
