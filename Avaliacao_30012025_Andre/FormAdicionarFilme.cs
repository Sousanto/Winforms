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
    public partial class FormAdicionarFilme : Form
    {
        public string Titulo { get; private set; }
        public string Genero { get; private set; }
        public string Ano { get; private set; }
        public FormAdicionarFilme()
        {
            InitializeComponent();
        }

        private void btn_adicionarFilme_Click(object sender, EventArgs e)
        {
            // Validar os dados inseridos
            if (string.IsNullOrWhiteSpace(tb_tituloFilme.Text) ||
                string.IsNullOrWhiteSpace(tb_generoFilme.Text) ||
                string.IsNullOrWhiteSpace(tb_anoFilme.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atribuir os valores às propriedades
            Titulo = tb_tituloFilme.Text;
            Genero = tb_generoFilme.Text;
            Ano = tb_anoFilme.Text;

            // Fechar o formulário com resultado OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
