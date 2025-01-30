using System.Diagnostics;
using System.Text;

namespace exe11_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc");
        }

        private void exploradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtb_quadro.SelectionFont = fd.Font;
            }
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtb_quadro.SelectionColor = cd.Color;
            }
        }

        private void retrocederUndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_quadro.Undo();
        }

        private void refazerRedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_quadro.Redo();
        }

        private void cortarCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_quadro.Cut();
        }

        private void copiarCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_quadro.Copy();
        }

        private void colarPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_quadro.Paste();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_quadro.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Escolher ficheiro de texto";
            ofd.Filter = "Escolher ficheiro TXT| *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string textolido = File.ReadAllText(ofd.FileName);
                rtb_quadro.Text = textolido;
            }
        }

        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Gravar ficheiro de texto";
            sfd.Filter = "Escolher ficheiro TXT| *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                rtb_quadro.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
