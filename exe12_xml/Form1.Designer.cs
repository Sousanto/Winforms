namespace exe12_xml
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
            tb_caminho = new TextBox();
            btn_escolher = new Button();
            openFileDialog1 = new OpenFileDialog();
            rtb_conteudo = new RichTextBox();
            btn_todos = new Button();
            cbb_plataforma = new ComboBox();
            btn_filtrar = new Button();
            label1 = new Label();
            btn_total = new Button();
            SuspendLayout();
            // 
            // tb_caminho
            // 
            tb_caminho.Location = new Point(37, 21);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.Size = new Size(581, 27);
            tb_caminho.TabIndex = 0;
            // 
            // btn_escolher
            // 
            btn_escolher.Location = new Point(624, 12);
            btn_escolher.Name = "btn_escolher";
            btn_escolher.Size = new Size(141, 36);
            btn_escolher.TabIndex = 1;
            btn_escolher.Text = "Escolher";
            btn_escolher.UseVisualStyleBackColor = true;
            btn_escolher.Click += btn_escolher_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtb_conteudo
            // 
            rtb_conteudo.Location = new Point(37, 130);
            rtb_conteudo.Name = "rtb_conteudo";
            rtb_conteudo.Size = new Size(728, 205);
            rtb_conteudo.TabIndex = 2;
            rtb_conteudo.Text = "";
            // 
            // btn_todos
            // 
            btn_todos.Location = new Point(623, 54);
            btn_todos.Name = "btn_todos";
            btn_todos.Size = new Size(142, 44);
            btn_todos.TabIndex = 3;
            btn_todos.Text = "Listar todos os jogos";
            btn_todos.UseVisualStyleBackColor = true;
            btn_todos.Click += btn_todos_Click;
            // 
            // cbb_plataforma
            // 
            cbb_plataforma.Font = new Font("Segoe UI", 9F);
            cbb_plataforma.FormattingEnabled = true;
            cbb_plataforma.Location = new Point(157, 73);
            cbb_plataforma.Name = "cbb_plataforma";
            cbb_plataforma.Size = new Size(170, 28);
            cbb_plataforma.TabIndex = 4;
            // 
            // btn_filtrar
            // 
            btn_filtrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_filtrar.Location = new Point(392, 73);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(105, 42);
            btn_filtrar.TabIndex = 5;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(37, 73);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 6;
            label1.Text = "Plataforma:";
            // 
            // btn_total
            // 
            btn_total.Location = new Point(290, 350);
            btn_total.Name = "btn_total";
            btn_total.Size = new Size(263, 45);
            btn_total.TabIndex = 7;
            btn_total.Text = "Total de Jogos";
            btn_total.UseVisualStyleBackColor = true;
            btn_total.Click += btn_total_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_total);
            Controls.Add(label1);
            Controls.Add(btn_filtrar);
            Controls.Add(cbb_plataforma);
            Controls.Add(btn_todos);
            Controls.Add(rtb_conteudo);
            Controls.Add(btn_escolher);
            Controls.Add(tb_caminho);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_caminho;
        private Button btn_escolher;
        private OpenFileDialog openFileDialog1;
        private RichTextBox rtb_conteudo;
        private Button btn_todos;
        private ComboBox cbb_plataforma;
        private Button btn_filtrar;
        private Label label1;
        private Button btn_total;
    }
}
