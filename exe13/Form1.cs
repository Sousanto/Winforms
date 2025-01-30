

//using System.Diagnostics.Eventing.Reader;
//using System.Xml;

//namespace exe13
//{
//    public partial class Form1 : Form
//    {
//        // Objeto para manipular o arquivo XML
//        XmlDocument doc;

//        public Form1()
//        {
//            InitializeComponent();
//        }

//        // M�todo para selecionar um arquivo XML
//        private void btn_escolher_Click(object sender, EventArgs e)
//        {
//            openFileDialog1.Title = "Escolhe o ficheiro XML para a galeria de emagens";
//            openFileDialog1.Filter = "Ficheiros XML|*.xml";// Filtra apenas arquivos XML

//            if (openFileDialog1.ShowDialog() == DialogResult.OK)
//            {
//                // Atualiza o caminho selecionado na TextBox
//                tb_caminho.Text = openFileDialog1.FileName;
//            }
//        }

//        // M�todo para validar e carregar o XML
//        private void btn_validar_Click(object sender, EventArgs e)
//        {
//            // Verifica se o caminho do arquivo foi selecionado
//            if (tb_caminho.Text == "")
//            {
//                MessageBox.Show("Escolha o ficheiro XML antes de validar !!!");
//            }
//            else
//            {
//                // Carrega o XML no objeto `XmlDocument`
//                doc = new XmlDocument();
//                doc.Load(tb_caminho.Text);

//                // Seleciona todos os elementos <imagem> no XML
//                XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

//                // Adiciona as descri��es das imagens � ListBox
//                foreach (XmlNode no in nodeList)
//                {
//                    XmlElement elemento = no as XmlElement;
//                    lb_imagens.Items.Add(elemento.Attributes.GetNamedItem("descricao").Value);
//                }
//            }
//        }






//        // M�todo executado quando o usu�rio seleciona um item da ListBox
//        private void lb_imagens_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Obt�m a lista de n�s <imagem>
//            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

//            // Seleciona o n� correspondente ao �ndice selecionado
//            XmlNode no = nodeList.Item(lb_imagens.SelectedIndex);
//            XmlElement elemento = no as XmlElement;

//            // Preenche os campos com os atributos do elemento selecionado
//            tb_id.Text = elemento.Attributes.GetNamedItem("id").Value;
//            tb_descricao.Text = elemento.Attributes.GetNamedItem("descricao").Value;
//            tb_ficheiro.Text = elemento.Attributes.GetNamedItem("ficheiro").Value;
//            tb_formato.Text = elemento.Attributes.GetNamedItem("formato").Value; // Adicionado campo de formato
//        }

//        // M�todo para alterar os dados de um item selecionado
//        private void btn_alterar_Click(object sender, EventArgs e)
//        {
//            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

//            // Seleciona o n� correspondente ao �ndice selecionado
//            XmlNode no = nodeList.Item(lb_imagens.SelectedIndex);
//            XmlElement elemento = no as XmlElement;

//            // Atualiza os atributos do n� com os valores dos campos de texto
//            elemento.Attributes.GetNamedItem("id").Value = tb_id.Text;
//            elemento.Attributes.GetNamedItem("descricao").Value = tb_descricao.Text;
//            elemento.Attributes.GetNamedItem("ficheiro").Value = tb_ficheiro.Text;
//            elemento.Attributes.GetNamedItem("formato").Value = tb_formato.Text;

//            // Salva o documento XML com as altera��es
//            doc.Save(tb_caminho.Text);

//            // Atualiza a ListBox para refletir as altera��es
//            int posicao = lb_imagens.SelectedIndex;

//            lb_imagens.Items.Clear();

//            XmlNodeList nodeList2 = doc.SelectNodes(@"/galeria/imagem");

//            foreach (XmlNode no2 in nodeList2)
//            {
//                XmlElement elemento2 = no2 as XmlElement;
//                lb_imagens.Items.Add(elemento2.Attributes.GetNamedItem("descricao").Value);
//            }

//            // Mant�m a sele��o do item alterado
//            lb_imagens.SelectedIndex = posicao;
//        }

//        // M�todo para inserir um novo item no XML
//        private void btn_inserir_Click(object sender, EventArgs e)
//        {
//            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

//            // Cria um novo elemento <imagem> com os atributos informados
//            XmlNode no = doc.SelectSingleNode("/galeria");
//            XmlElement elemento = doc.CreateElement("imagem");

//            elemento.SetAttribute("id", tb_id.Text);
//            elemento.SetAttribute("descricao", tb_descricao.Text);
//            elemento.SetAttribute("ficheiro", tb_ficheiro.Text);
//            elemento.SetAttribute("formato", tb_formato.Text);

//            // Adiciona o novo elemento ao n� <galeria>
//            no.AppendChild(elemento);

//            // Salva o XML com o novo elemento
//            doc.Save(tb_caminho.Text);

//            int posicao = lb_imagens.SelectedIndex;

//            // Atualiza a ListBox para incluir o novo item
//            lb_imagens.Items.Clear();

//            XmlNodeList nodeList2 = doc.SelectNodes(@"/galeria/imagem");

//            foreach (XmlNode no2 in nodeList2)
//            {
//                XmlElement elemento2 = no2 as XmlElement;
//                lb_imagens.Items.Add(elemento2.Attributes.GetNamedItem("descricao").Value);
//            }
//        }

//        // M�todo para remover um item selecionado do XML
//        private void btn_iliminar_Click(object sender, EventArgs e)
//        {
//            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");
//            XmlNode no = nodeList.Item(lb_imagens.SelectedIndex);
//            XmlElement elemento = no as XmlElement;

//            elemento.ParentNode.RemoveChild(no);

//            doc.Save(tb_caminho.Text);


//            lb_imagens.Items.Clear();

//            XmlNodeList nodeList2 = doc.SelectNodes(@"/galeria/imagem");

//            foreach (XmlNode no2 in nodeList2)
//            {
//                XmlElement elemento2 = no2 as XmlElement;
//                lb_imagens.Items.Add(elemento2.Attributes.GetNamedItem("descricao").Value);
//            }
//        }

//        private void btn_contar_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show($"Existem {lb_imagens.Items.Count} imagens no ficheiro");
//        }

//        // Evento de mudan�a de sele��o no ComboBox
//        private void cb_formato_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            btn_filtrar.PerformClick(); // Chama o filtro automaticamente
//        }


//        private void btn_filtrar_Click(object sender, EventArgs e)
//        {
//            if (cb_formato.SelectedIndex == -1) // Verifica se h� uma sele��o v�lida
//            {
//                MessageBox.Show("Por favor, selecione um formato antes de aplicar o filtro.");
//                return;
//            }



//            //lb_imagens.Items.Clear();



//            // Obtem o formato selecionado do ComboBox
//            string formatoSelecionado = cb_formato.Text.ToLower();

//            // Verifica se o formato � v�lido
//            if (formatoSelecionado == "gif" || formatoSelecionado == "jpg" || formatoSelecionado == "png")
//            {
//                // Filtra as imagens pelo formato selecionado
//                lb_imagens.Items.Clear();
//                XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

//                foreach (XmlNode no in nodeList)
//                {
//                    XmlElement elemento = no as XmlElement;

//                    // Verifica se o formato do elemento corresponde ao selecionado
//                    if (elemento.Attributes["formato"].Value.ToLower() == formatoSelecionado)
//                    {
//                        lb_imagens.Items.Add(elemento.Attributes["descricao"].Value);
//                    }
//                }

//                // Caso nenhuma imagem seja encontrada no formato selecionado
//                if (lb_imagens.Items.Count == 0)
//                {
//                    MessageBox.Show($"Nenhuma imagem no formato {formatoSelecionado.ToUpper()} foi encontrada.");
//                }

//                else
//                {
//                    // Mensagem para formatos inv�lidos
//                    MessageBox.Show("Por favor, selecione um formato v�lido (GIF, JPG ou PNG).");
//                }
//            }
//        }


//    }

//}



///*****************************************
///

using System.Diagnostics.Eventing.Reader;
using System.Xml;

namespace exe13
{
    public partial class Form1 : Form
    {
        // Objeto para manipular o arquivo XML
        XmlDocument doc;

        public Form1()
        {
            InitializeComponent();
            PopulateComboBox(); // Garante que os formatos estejam dispon�veis no ComboBox ao iniciar o formul�rio
        }

        // M�todo para preencher o ComboBox com os formatos
        private void PopulateComboBox()
        {
            cb_formato.Items.Clear();
            cb_formato.Items.AddRange(new string[] { "GIF", "JPG", "PNG" }); // Adiciona os formatos poss�veis
        }

        // M�todo para selecionar um arquivo XML
        private void btn_escolher_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolhe o ficheiro XML para a galeria de imagens";
            openFileDialog1.Filter = "Ficheiros XML|*.xml"; // Filtra apenas arquivos XML

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_caminho.Text = openFileDialog1.FileName; // Atualiza o caminho selecionado na TextBox
            }
        }

        // M�todo para validar e carregar o XML
        private void btn_validar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb_caminho.Text))
            {
                MessageBox.Show("Escolha o ficheiro XML antes de validar!");
                return;
            }

            try
            {
                doc = new XmlDocument();
                doc.Load(tb_caminho.Text); // Carrega o arquivo XML

                XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

                lb_imagens.Items.Clear(); // Limpa a ListBox antes de preench�-la

                foreach (XmlNode no in nodeList)
                {
                    XmlElement elemento = no as XmlElement;

                    if (elemento.Attributes["descricao"] != null) // Verifica se o atributo existe
                    {
                        lb_imagens.Items.Add(elemento.Attributes["descricao"].Value); // Adiciona as descri��es � ListBox
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao validar o ficheiro XML: {ex.Message}");
            }


        }

        // M�todo para filtrar imagens pelo formato selecionado no ComboBox
        private void btn_filtrar_Click(object sender, EventArgs e)
        {

            // Verifica se h� uma sele��o v�lida no ComboBox
            if (cb_formato.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um formato antes de aplicar o filtro.");
                return;
            }

            // Verifica se o arquivo XML foi carregado
            if (doc == null)
            {
                MessageBox.Show("Por favor, carregue e valide um ficheiro XML antes de filtrar.");
                return;
            }

            // Obt�m o formato selecionado do ComboBox
            string formatoSelecionado = cb_formato.Text.ToLower();

            // Limpa a ListBox antes de filtrar
            lb_imagens.Items.Clear();

            try
            {
                // Seleciona os elementos <imagem> no XML
                XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

                // Filtra as imagens pelo formato selecionado
                foreach (XmlNode no in nodeList)
                {
                    XmlElement elemento = no as XmlElement;

                    // Verifica se o formato do elemento corresponde ao selecionado
                    if (elemento.Attributes["formato"] != null &&
                        elemento.Attributes["formato"].Value.ToLower() == formatoSelecionado)
                    {
                        lb_imagens.Items.Add(elemento.Attributes["descricao"].Value); // Adiciona � ListBox
                    }
                }

                // Caso nenhuma imagem seja encontrada
                if (lb_imagens.Items.Count == 0)
                {
                    MessageBox.Show($"Nenhuma imagem no formato {formatoSelecionado.ToUpper()} foi encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao filtrar imagens: {ex.Message}");
            }
       



        }

        // M�todo para alterar os dados de um item selecionado
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (lb_imagens.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item para alterar.");
                return;
            }

            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

            XmlNode no = nodeList.Item(lb_imagens.SelectedIndex);
            XmlElement elemento = no as XmlElement;

            elemento.Attributes["id"].Value = tb_id.Text;
            elemento.Attributes["descricao"].Value = tb_descricao.Text;
            elemento.Attributes["ficheiro"].Value = tb_ficheiro.Text;
            elemento.Attributes["formato"].Value = tb_formato.Text;

            doc.Save(tb_caminho.Text); // Salva as altera��es no arquivo XML

            // Atualiza a ListBox para refletir as altera��es
            lb_imagens.Items[lb_imagens.SelectedIndex] = tb_descricao.Text;
        }

        // M�todo para inserir um novo item no XML
        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (doc == null)
            {
                MessageBox.Show("Carregue e valide um ficheiro XML antes de inserir novos itens.");
                return;
            }

            XmlNode galeriaNode = doc.SelectSingleNode("/galeria");

            XmlElement novoElemento = doc.CreateElement("imagem");

            novoElemento.SetAttribute("id", tb_id.Text);
            novoElemento.SetAttribute("descricao", tb_descricao.Text);
            novoElemento.SetAttribute("ficheiro", tb_ficheiro.Text);
            novoElemento.SetAttribute("formato", tb_formato.Text);

            galeriaNode.AppendChild(novoElemento);

            doc.Save(tb_caminho.Text); // Salva o XML atualizado

            lb_imagens.Items.Add(tb_descricao.Text); // Atualiza a ListBox
        }

        // M�todo para remover um item selecionado do XML
        private void btn_iliminar_Click(object sender, EventArgs e)
        {
            if (lb_imagens.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item para remover.");
                return;
            }

            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

            XmlNode no = nodeList.Item(lb_imagens.SelectedIndex);

            no.ParentNode.RemoveChild(no);

            doc.Save(tb_caminho.Text); // Salva o XML atualizado

            lb_imagens.Items.RemoveAt(lb_imagens.SelectedIndex); // Atualiza a ListBox
        }

        private void btn_contar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Existem {lb_imagens.Items.Count} imagens no ficheiro.");
        }

        // Evento para acionar o filtro automaticamente ao alterar a sele��o no ComboBox
        private void cb_formato_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_filtrar.PerformClick();
        }
    }
}