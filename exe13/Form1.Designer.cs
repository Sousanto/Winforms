namespace exe13
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
            label1 = new Label();
            tb_caminho = new TextBox();
            btn_escolher = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            lb_imagens = new ListBox();
            btn_validar = new Button();
            label2 = new Label();
            tb_id = new TextBox();
            label3 = new Label();
            tb_descricao = new TextBox();
            tb_ficheiro = new TextBox();
            label4 = new Label();
            btn_alterar = new Button();
            btn_inserir = new Button();
            btn_iliminar = new Button();
            btn_contar = new Button();
            label5 = new Label();
            tb_formato = new TextBox();
            cb_formato = new ComboBox();
            btn_filtrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 0;
            label1.Text = "Ficheiro";
            // 
            // tb_caminho
            // 
            tb_caminho.Location = new Point(95, 27);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.Size = new Size(593, 27);
            tb_caminho.TabIndex = 1;
            // 
            // btn_escolher
            // 
            btn_escolher.Location = new Point(694, 25);
            btn_escolher.Name = "btn_escolher";
            btn_escolher.Size = new Size(94, 29);
            btn_escolher.TabIndex = 2;
            btn_escolher.Text = "Escolher";
            btn_escolher.UseVisualStyleBackColor = true;
            btn_escolher.Click += btn_escolher_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_imagens);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 321);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagens existentes";
            // 
            // lb_imagens
            // 
            lb_imagens.FormattingEnabled = true;
            lb_imagens.Location = new Point(45, 44);
            lb_imagens.Name = "lb_imagens";
            lb_imagens.Size = new Size(217, 264);
            lb_imagens.TabIndex = 0;
            //lb_imagens.SelectedIndexChanged += lb_imagens_SelectedIndexChanged;
            // 
            // btn_validar
            // 
            btn_validar.Location = new Point(443, 61);
            btn_validar.Name = "btn_validar";
            btn_validar.Size = new Size(162, 48);
            btn_validar.TabIndex = 4;
            btn_validar.Text = "Validar";
            btn_validar.UseVisualStyleBackColor = true;
            btn_validar.Click += btn_validar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(394, 147);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 5;
            label2.Text = "Id:";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(443, 144);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(162, 27);
            tb_id.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(394, 193);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 7;
            label3.Text = "Descrição:";
            // 
            // tb_descricao
            // 
            tb_descricao.Location = new Point(480, 190);
            tb_descricao.Name = "tb_descricao";
            tb_descricao.Size = new Size(125, 27);
            tb_descricao.TabIndex = 8;
            // 
            // tb_ficheiro
            // 
            tb_ficheiro.Location = new Point(480, 237);
            tb_ficheiro.Name = "tb_ficheiro";
            tb_ficheiro.Size = new Size(125, 27);
            tb_ficheiro.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(394, 244);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 10;
            label4.Text = "Ficheiro:";
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(394, 332);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(115, 55);
            btn_alterar.TabIndex = 11;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_inserir
            // 
            btn_inserir.Location = new Point(532, 332);
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Size = new Size(117, 55);
            btn_inserir.TabIndex = 12;
            btn_inserir.Text = "Inserir";
            btn_inserir.UseVisualStyleBackColor = true;
            btn_inserir.Click += btn_inserir_Click;
            // 
            // btn_iliminar
            // 
            btn_iliminar.Location = new Point(670, 332);
            btn_iliminar.Name = "btn_iliminar";
            btn_iliminar.Size = new Size(117, 55);
            btn_iliminar.TabIndex = 13;
            btn_iliminar.Text = "Eliminar";
            btn_iliminar.UseVisualStyleBackColor = true;
            btn_iliminar.Click += btn_iliminar_Click;
            // 
            // btn_contar
            // 
            btn_contar.Location = new Point(671, 190);
            btn_contar.Name = "btn_contar";
            btn_contar.Size = new Size(117, 49);
            btn_contar.TabIndex = 14;
            btn_contar.Text = "Contar";
            btn_contar.UseVisualStyleBackColor = true;
            btn_contar.Click += btn_contar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(394, 287);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 16;
            label5.Text = "Formato:";
            // 
            // tb_formato
            // 
            tb_formato.Location = new Point(480, 280);
            tb_formato.Name = "tb_formato";
            tb_formato.Size = new Size(125, 27);
            tb_formato.TabIndex = 17;
            // 
            // cb_formato
            // 
            cb_formato.Location = new Point(672, 123);
            cb_formato.Name = "cb_formato";
            cb_formato.Size = new Size(121, 28);
            cb_formato.TabIndex = 0;
            // 
            // btn_filtrar
            // 
            btn_filtrar.Location = new Point(672, 61);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(116, 48);
            btn_filtrar.TabIndex = 18;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_filtrar);
            Controls.Add(cb_formato);
            Controls.Add(tb_formato);
            Controls.Add(label5);
            Controls.Add(btn_contar);
            Controls.Add(btn_iliminar);
            Controls.Add(btn_inserir);
            Controls.Add(btn_alterar);
            Controls.Add(label4);
            Controls.Add(tb_ficheiro);
            Controls.Add(tb_descricao);
            Controls.Add(label3);
            Controls.Add(tb_id);
            Controls.Add(label2);
            Controls.Add(btn_validar);
            Controls.Add(groupBox1);
            Controls.Add(btn_escolher);
            Controls.Add(tb_caminho);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_caminho;
        private Button btn_escolher;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private ListBox lb_imagens;
        private Button btn_validar;
        private Label label2;
        private TextBox tb_id;
        private Label label3;
        private TextBox tb_descricao;
        private TextBox tb_ficheiro;
        private Label label4;
        private Button btn_alterar;
        private Button btn_inserir;
        private Button btn_iliminar;
        private Button btn_contar;
        private Label label5;
        private TextBox tb_formato;
        private ComboBox cb_formato;
        private Button btn_filtrar;
    }
}
