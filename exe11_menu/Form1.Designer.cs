namespace exe11_menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtb_quadro = new RichTextBox();
            menuStrip1 = new MenuStrip();
            ficheiroToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            gravarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            retrocederUndoToolStripMenuItem = new ToolStripMenuItem();
            refazerRedoToolStripMenuItem = new ToolStripMenuItem();
            cortarCutToolStripMenuItem = new ToolStripMenuItem();
            copiarCopyToolStripMenuItem = new ToolStripMenuItem();
            colarPasteToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            fonteToolStripMenuItem = new ToolStripMenuItem();
            corToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            exploradorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtb_quadro
            // 
            rtb_quadro.Location = new Point(52, 81);
            rtb_quadro.Name = "rtb_quadro";
            rtb_quadro.Size = new Size(729, 358);
            rtb_quadro.TabIndex = 0;
            rtb_quadro.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ficheiroToolStripMenuItem, editarToolStripMenuItem, formatarToolStripMenuItem, ferramentasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            ficheiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, gravarToolStripMenuItem, sairToolStripMenuItem });
            ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            ficheiroToolStripMenuItem.Size = new Size(75, 24);
            ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(224, 26);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(224, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // gravarToolStripMenuItem
            // 
            gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            gravarToolStripMenuItem.Size = new Size(224, 26);
            gravarToolStripMenuItem.Text = "Gravar";
            gravarToolStripMenuItem.Click += gravarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { retrocederUndoToolStripMenuItem, refazerRedoToolStripMenuItem, cortarCutToolStripMenuItem, copiarCopyToolStripMenuItem, colarPasteToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // retrocederUndoToolStripMenuItem
            // 
            retrocederUndoToolStripMenuItem.Name = "retrocederUndoToolStripMenuItem";
            retrocederUndoToolStripMenuItem.Size = new Size(207, 26);
            retrocederUndoToolStripMenuItem.Text = "Retroceder/Undo";
            retrocederUndoToolStripMenuItem.Click += retrocederUndoToolStripMenuItem_Click;
            // 
            // refazerRedoToolStripMenuItem
            // 
            refazerRedoToolStripMenuItem.Name = "refazerRedoToolStripMenuItem";
            refazerRedoToolStripMenuItem.Size = new Size(207, 26);
            refazerRedoToolStripMenuItem.Text = "Refazer/Redo";
            refazerRedoToolStripMenuItem.Click += refazerRedoToolStripMenuItem_Click;
            // 
            // cortarCutToolStripMenuItem
            // 
            cortarCutToolStripMenuItem.Name = "cortarCutToolStripMenuItem";
            cortarCutToolStripMenuItem.Size = new Size(207, 26);
            cortarCutToolStripMenuItem.Text = "Cortar/Cut";
            cortarCutToolStripMenuItem.Click += cortarCutToolStripMenuItem_Click;
            // 
            // copiarCopyToolStripMenuItem
            // 
            copiarCopyToolStripMenuItem.Name = "copiarCopyToolStripMenuItem";
            copiarCopyToolStripMenuItem.Size = new Size(207, 26);
            copiarCopyToolStripMenuItem.Text = "Copiar/Copy";
            copiarCopyToolStripMenuItem.Click += copiarCopyToolStripMenuItem_Click;
            // 
            // colarPasteToolStripMenuItem
            // 
            colarPasteToolStripMenuItem.Name = "colarPasteToolStripMenuItem";
            colarPasteToolStripMenuItem.Size = new Size(207, 26);
            colarPasteToolStripMenuItem.Text = "Colar/Paste";
            colarPasteToolStripMenuItem.Click += colarPasteToolStripMenuItem_Click;
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fonteToolStripMenuItem, corToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(83, 24);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            fonteToolStripMenuItem.Size = new Size(129, 26);
            fonteToolStripMenuItem.Text = "Fonte";
            fonteToolStripMenuItem.Click += fonteToolStripMenuItem_Click;
            // 
            // corToolStripMenuItem
            // 
            corToolStripMenuItem.Name = "corToolStripMenuItem";
            corToolStripMenuItem.Size = new Size(129, 26);
            corToolStripMenuItem.Text = "Cor";
            corToolStripMenuItem.Click += corToolStripMenuItem_Click;
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, exploradorToolStripMenuItem });
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(104, 24);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(171, 26);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // exploradorToolStripMenuItem
            // 
            exploradorToolStripMenuItem.Name = "exploradorToolStripMenuItem";
            exploradorToolStripMenuItem.Size = new Size(171, 26);
            exploradorToolStripMenuItem.Text = "Explorador";
            exploradorToolStripMenuItem.Click += exploradorToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_quadro);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_quadro;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ficheiroToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem gravarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem retrocederUndoToolStripMenuItem;
        private ToolStripMenuItem refazerRedoToolStripMenuItem;
        private ToolStripMenuItem cortarCutToolStripMenuItem;
        private ToolStripMenuItem copiarCopyToolStripMenuItem;
        private ToolStripMenuItem colarPasteToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem fonteToolStripMenuItem;
        private ToolStripMenuItem corToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem exploradorToolStripMenuItem;
    }
}
