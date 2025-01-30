using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao_30012025_Andre
{
    public partial class FormAdicionarMusica : Form
    {
        public string Titulo { get; private set; }
        public string Artista { get; private set; }
        public string Genero { get; private set; }
        public string Ano { get; private set; }
        public FormAdicionarMusica()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            // Validar os dados inseridos
            if (string.IsNullOrWhiteSpace(tb_titulo.Text) ||
                string.IsNullOrWhiteSpace(tb_artista.Text) ||
                string.IsNullOrWhiteSpace(tb_genero.Text) ||
                string.IsNullOrWhiteSpace(tb_ano.Text)) 
                
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atribuir os valores às propriedades
            Titulo = tb_titulo.Text;
            Artista = tb_artista.Text;
            Genero = tb_genero.Text;
            Ano = tb_ano.Text;

            // Fechar o formulário com resultado OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
    
}
