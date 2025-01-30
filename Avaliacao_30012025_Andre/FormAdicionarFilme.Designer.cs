namespace Avaliacao_30012025_Andre
{
    partial class FormAdicionarFilme
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
            btn_adicionarFilme = new Button();
            label1 = new Label();
            tb_tituloFilme = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_anoFilme = new TextBox();
            tb_generoFilme = new TextBox();
            SuspendLayout();
            // 
            // btn_adicionarFilme
            // 
            btn_adicionarFilme.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_adicionarFilme.Location = new Point(516, 94);
            btn_adicionarFilme.Name = "btn_adicionarFilme";
            btn_adicionarFilme.Size = new Size(200, 49);
            btn_adicionarFilme.TabIndex = 0;
            btn_adicionarFilme.Text = "Adicionar Filme";
            btn_adicionarFilme.UseVisualStyleBackColor = true;
            btn_adicionarFilme.Click += btn_adicionarFilme_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(141, 96);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 1;
            label1.Text = "Título:";
            // 
            // tb_tituloFilme
            // 
            tb_tituloFilme.Location = new Point(245, 94);
            tb_tituloFilme.Name = "tb_tituloFilme";
            tb_tituloFilme.Size = new Size(163, 27);
            tb_tituloFilme.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(141, 187);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Ano:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(141, 140);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 5;
            label4.Text = "Género:";
            // 
            // tb_anoFilme
            // 
            tb_anoFilme.Location = new Point(245, 185);
            tb_anoFilme.Name = "tb_anoFilme";
            tb_anoFilme.Size = new Size(163, 27);
            tb_anoFilme.TabIndex = 7;
            // 
            // tb_generoFilme
            // 
            tb_generoFilme.Location = new Point(245, 138);
            tb_generoFilme.Name = "tb_generoFilme";
            tb_generoFilme.Size = new Size(163, 27);
            tb_generoFilme.TabIndex = 8;
            // 
            // FormAdicionarFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_generoFilme);
            Controls.Add(tb_anoFilme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_tituloFilme);
            Controls.Add(label1);
            Controls.Add(btn_adicionarFilme);
            Name = "FormAdicionarFilme";
            Text = "FormAdicionarFilme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionarFilme;
        private Label label1;
        private TextBox tb_tituloFilme;
        private Label label3;
        private Label label4;
        private TextBox tb_anoFilme;
        private TextBox tb_generoFilme;
    }
}