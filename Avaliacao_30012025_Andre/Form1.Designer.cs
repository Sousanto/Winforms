namespace Avaliacao_30012025_Andre
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
            menuStrip1 = new MenuStrip();
            ficheiroToolStripMenuItem = new ToolStripMenuItem();
            abrirXMLToolStripMenuItem = new ToolStripMenuItem();
            sairDaAplicaçãoToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            todosOsItensToolStripMenuItem = new ToolStripMenuItem();
            apenasFilmesToolStripMenuItem = new ToolStripMenuItem();
            apenasMúsicasToolStripMenuItem = new ToolStripMenuItem();
            filtrosToolStripMenuItem = new ToolStripMenuItem();
            filtrarMúsicasPorGéneroToolStripMenuItem = new ToolStripMenuItem();
            filtrarFilmesPorGéneroToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            adicionarFilmeToolStripMenuItem = new ToolStripMenuItem();
            adicionarMúsicaToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem = new ToolStripMenuItem();
            alterarFilmeToolStripMenuItem = new ToolStripMenuItem();
            alterarMúsicaToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            eliminarFilmeToolStripMenuItem = new ToolStripMenuItem();
            eliminarMúsicaToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            rtb_quadro = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ficheiroToolStripMenuItem, verToolStripMenuItem, filtrosToolStripMenuItem, adicionarToolStripMenuItem, alterarToolStripMenuItem, eliminarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            ficheiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirXMLToolStripMenuItem, sairDaAplicaçãoToolStripMenuItem });
            ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            ficheiroToolStripMenuItem.Size = new Size(75, 24);
            ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // abrirXMLToolStripMenuItem
            // 
            abrirXMLToolStripMenuItem.Name = "abrirXMLToolStripMenuItem";
            abrirXMLToolStripMenuItem.Size = new Size(206, 26);
            abrirXMLToolStripMenuItem.Text = "Abrir XML";
            abrirXMLToolStripMenuItem.Click += abrirXMLToolStripMenuItem_Click;
            // 
            // sairDaAplicaçãoToolStripMenuItem
            // 
            sairDaAplicaçãoToolStripMenuItem.Name = "sairDaAplicaçãoToolStripMenuItem";
            sairDaAplicaçãoToolStripMenuItem.Size = new Size(206, 26);
            sairDaAplicaçãoToolStripMenuItem.Text = "Sair da aplicação";
            sairDaAplicaçãoToolStripMenuItem.Click += sairDaAplicaçãoToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosOsItensToolStripMenuItem, apenasFilmesToolStripMenuItem, apenasMúsicasToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(44, 24);
            verToolStripMenuItem.Text = "Ver";
            // 
            // todosOsItensToolStripMenuItem
            // 
            todosOsItensToolStripMenuItem.Name = "todosOsItensToolStripMenuItem";
            todosOsItensToolStripMenuItem.Size = new Size(197, 26);
            todosOsItensToolStripMenuItem.Text = "Todos os itens";
            todosOsItensToolStripMenuItem.Click += todosOsItensToolStripMenuItem_Click;
            // 
            // apenasFilmesToolStripMenuItem
            // 
            apenasFilmesToolStripMenuItem.Name = "apenasFilmesToolStripMenuItem";
            apenasFilmesToolStripMenuItem.Size = new Size(197, 26);
            apenasFilmesToolStripMenuItem.Text = "Apenas filmes";
            apenasFilmesToolStripMenuItem.Click += apenasFilmesToolStripMenuItem_Click;
            // 
            // apenasMúsicasToolStripMenuItem
            // 
            apenasMúsicasToolStripMenuItem.Name = "apenasMúsicasToolStripMenuItem";
            apenasMúsicasToolStripMenuItem.Size = new Size(197, 26);
            apenasMúsicasToolStripMenuItem.Text = "Apenas músicas";
            apenasMúsicasToolStripMenuItem.Click += apenasMúsicasToolStripMenuItem_Click;
            // 
            // filtrosToolStripMenuItem
            // 
            filtrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filtrarMúsicasPorGéneroToolStripMenuItem, filtrarFilmesPorGéneroToolStripMenuItem });
            filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            filtrosToolStripMenuItem.Size = new Size(63, 24);
            filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // filtrarMúsicasPorGéneroToolStripMenuItem
            // 
            filtrarMúsicasPorGéneroToolStripMenuItem.Name = "filtrarMúsicasPorGéneroToolStripMenuItem";
            filtrarMúsicasPorGéneroToolStripMenuItem.Size = new Size(264, 26);
            filtrarMúsicasPorGéneroToolStripMenuItem.Text = "Filtrar músicas por género";
            filtrarMúsicasPorGéneroToolStripMenuItem.Click += filtrarMúsicasPorGéneroToolStripMenuItem_Click;
            // 
            // filtrarFilmesPorGéneroToolStripMenuItem
            // 
            filtrarFilmesPorGéneroToolStripMenuItem.Name = "filtrarFilmesPorGéneroToolStripMenuItem";
            filtrarFilmesPorGéneroToolStripMenuItem.Size = new Size(264, 26);
            filtrarFilmesPorGéneroToolStripMenuItem.Text = "Filtrar filmes por género";
            filtrarFilmesPorGéneroToolStripMenuItem.Click += filtrarFilmesPorGéneroToolStripMenuItem_Click;
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarFilmeToolStripMenuItem, adicionarMúsicaToolStripMenuItem });
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(87, 24);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // adicionarFilmeToolStripMenuItem
            // 
            adicionarFilmeToolStripMenuItem.Name = "adicionarFilmeToolStripMenuItem";
            adicionarFilmeToolStripMenuItem.Size = new Size(224, 26);
            adicionarFilmeToolStripMenuItem.Text = "Adicionar filme";
            adicionarFilmeToolStripMenuItem.Click += adicionarFilmeToolStripMenuItem_Click;
            // 
            // adicionarMúsicaToolStripMenuItem
            // 
            adicionarMúsicaToolStripMenuItem.Name = "adicionarMúsicaToolStripMenuItem";
            adicionarMúsicaToolStripMenuItem.Size = new Size(224, 26);
            adicionarMúsicaToolStripMenuItem.Text = "Adicionar música";
            adicionarMúsicaToolStripMenuItem.Click += adicionarMúsicaToolStripMenuItem_Click;
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarFilmeToolStripMenuItem, alterarMúsicaToolStripMenuItem });
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(68, 24);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // alterarFilmeToolStripMenuItem
            // 
            alterarFilmeToolStripMenuItem.Name = "alterarFilmeToolStripMenuItem";
            alterarFilmeToolStripMenuItem.Size = new Size(187, 26);
            alterarFilmeToolStripMenuItem.Text = "Alterar filme";
            // 
            // alterarMúsicaToolStripMenuItem
            // 
            alterarMúsicaToolStripMenuItem.Name = "alterarMúsicaToolStripMenuItem";
            alterarMúsicaToolStripMenuItem.Size = new Size(187, 26);
            alterarMúsicaToolStripMenuItem.Text = "Alterar música";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eliminarFilmeToolStripMenuItem, eliminarMúsicaToolStripMenuItem });
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(77, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarFilmeToolStripMenuItem
            // 
            eliminarFilmeToolStripMenuItem.Name = "eliminarFilmeToolStripMenuItem";
            eliminarFilmeToolStripMenuItem.Size = new Size(196, 26);
            eliminarFilmeToolStripMenuItem.Text = "Eliminar filme";
            // 
            // eliminarMúsicaToolStripMenuItem
            // 
            eliminarMúsicaToolStripMenuItem.Name = "eliminarMúsicaToolStripMenuItem";
            eliminarMúsicaToolStripMenuItem.Size = new Size(196, 26);
            eliminarMúsicaToolStripMenuItem.Text = "Eliminar música";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtb_quadro
            // 
            rtb_quadro.Location = new Point(12, 54);
            rtb_quadro.Name = "rtb_quadro";
            rtb_quadro.Size = new Size(578, 384);
            rtb_quadro.TabIndex = 1;
            rtb_quadro.Text = "";
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ficheiroToolStripMenuItem;
        private ToolStripMenuItem abrirXMLToolStripMenuItem;
        private ToolStripMenuItem sairDaAplicaçãoToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem todosOsItensToolStripMenuItem;
        private ToolStripMenuItem apenasFilmesToolStripMenuItem;
        private ToolStripMenuItem apenasMúsicasToolStripMenuItem;
        private ToolStripMenuItem filtrosToolStripMenuItem;
        private ToolStripMenuItem filtrarMúsicasPorGéneroToolStripMenuItem;
        private ToolStripMenuItem filtrarFilmesPorGéneroToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem adicionarFilmeToolStripMenuItem;
        private ToolStripMenuItem adicionarMúsicaToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem alterarFilmeToolStripMenuItem;
        private ToolStripMenuItem alterarMúsicaToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem eliminarFilmeToolStripMenuItem;
        private ToolStripMenuItem eliminarMúsicaToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private RichTextBox rtb_quadro;
    }
}
