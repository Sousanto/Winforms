namespace Avaliacao_30012025_Andre
{
    partial class FormAdicionarMusica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_titulo = new TextBox();
            tb_artista = new TextBox();
            tb_genero = new TextBox();
            tb_ano = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_adicionar = new Button();
            SuspendLayout();
            // 
            // tb_titulo
            // 
            tb_titulo.Location = new Point(304, 64);
            tb_titulo.Name = "tb_titulo";
            tb_titulo.Size = new Size(167, 27);
            tb_titulo.TabIndex = 0;
            // 
            // tb_artista
            // 
            tb_artista.Location = new Point(304, 107);
            tb_artista.Name = "tb_artista";
            tb_artista.Size = new Size(167, 27);
            tb_artista.TabIndex = 1;
            // 
            // tb_genero
            // 
            tb_genero.Location = new Point(304, 156);
            tb_genero.Name = "tb_genero";
            tb_genero.Size = new Size(167, 27);
            tb_genero.TabIndex = 2;
            // 
            // tb_ano
            // 
            tb_ano.Location = new Point(304, 203);
            tb_ano.Name = "tb_ano";
            tb_ano.Size = new Size(167, 27);
            tb_ano.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(222, 109);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 4;
            label1.Text = "Artista:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(222, 66);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 5;
            label2.Text = "Título:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(222, 158);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 6;
            label3.Text = "Género:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(222, 203);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 7;
            label4.Text = "Ano:";
            // 
            // btn_adicionar
            // 
            btn_adicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_adicionar.Location = new Point(517, 64);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(204, 53);
            btn_adicionar.TabIndex = 8;
            btn_adicionar.Text = "Adicionar Música";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // FormAdicionarMusica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_adicionar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_ano);
            Controls.Add(tb_genero);
            Controls.Add(tb_artista);
            Controls.Add(tb_titulo);
            Name = "FormAdicionarMusica";
            Text = "FormAdicionarMusica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_titulo;
        private TextBox tb_artista;
        private TextBox tb_genero;
        private TextBox tb_ano;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_adicionar;
    }
}