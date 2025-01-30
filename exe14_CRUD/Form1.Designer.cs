namespace exe14_CRUD
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
            label1 = new Label();
            btn_abrir = new Button();
            btn_sair = new Button();
            cbb_filtro = new ComboBox();
            lb_automoveis = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tb_marca = new TextBox();
            tb_modelo = new TextBox();
            tb_preco = new TextBox();
            tb_motor = new TextBox();
            tb_potencia = new TextBox();
            tb_kms = new TextBox();
            tb_matricula = new TextBox();
            rb_novo = new RadioButton();
            rb_usado = new RadioButton();
            btn_adicionar = new Button();
            btn_alterar = new Button();
            btn_eliminar = new Button();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            tb_id = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_caminho
            // 
            tb_caminho.Location = new Point(80, 9);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.Size = new Size(631, 27);
            tb_caminho.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(-2, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 1;
            label1.Text = "Ficheiro:";
            // 
            // btn_abrir
            // 
            btn_abrir.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_abrir.Location = new Point(717, 0);
            btn_abrir.Name = "btn_abrir";
            btn_abrir.Size = new Size(71, 44);
            btn_abrir.TabIndex = 2;
            btn_abrir.Text = "Abrir";
            btn_abrir.UseVisualStyleBackColor = true;
            btn_abrir.Click += btn_abrir_Click;
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_sair.Location = new Point(726, 404);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(71, 44);
            btn_sair.TabIndex = 3;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // cbb_filtro
            // 
            cbb_filtro.FormattingEnabled = true;
            cbb_filtro.Items.AddRange(new object[] { "Todos", "Novos", "Usados" });
            cbb_filtro.Location = new Point(416, 50);
            cbb_filtro.Name = "cbb_filtro";
            cbb_filtro.Size = new Size(270, 28);
            cbb_filtro.TabIndex = 4;
            cbb_filtro.SelectedIndexChanged += cbb_filtro_SelectedIndexChanged;
            // 
            // lb_automoveis
            // 
            lb_automoveis.FormattingEnabled = true;
            lb_automoveis.Location = new Point(14, 34);
            lb_automoveis.Name = "lb_automoveis";
            lb_automoveis.Size = new Size(379, 324);
            lb_automoveis.TabIndex = 5;
            lb_automoveis.SelectedIndexChanged += lb_automoveis_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(416, 119);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 6;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(415, 152);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 7;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(415, 180);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 8;
            label4.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(482, 352);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(414, 213);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 10;
            label6.Text = "Motor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(414, 246);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 11;
            label7.Text = "Potência:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(416, 283);
            label8.Name = "label8";
            label8.Size = new Size(55, 28);
            label8.TabIndex = 12;
            label8.Text = "kms:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(416, 320);
            label9.Name = "label9";
            label9.Size = new Size(108, 28);
            label9.TabIndex = 13;
            label9.Text = "Matrícula:";
            // 
            // tb_marca
            // 
            tb_marca.Location = new Point(525, 114);
            tb_marca.Name = "tb_marca";
            tb_marca.Size = new Size(125, 27);
            tb_marca.TabIndex = 14;
            // 
            // tb_modelo
            // 
            tb_modelo.Location = new Point(525, 147);
            tb_modelo.Name = "tb_modelo";
            tb_modelo.Size = new Size(125, 27);
            tb_modelo.TabIndex = 15;
            // 
            // tb_preco
            // 
            tb_preco.Location = new Point(525, 180);
            tb_preco.Name = "tb_preco";
            tb_preco.Size = new Size(125, 27);
            tb_preco.TabIndex = 16;
            // 
            // tb_motor
            // 
            tb_motor.Location = new Point(525, 213);
            tb_motor.Name = "tb_motor";
            tb_motor.Size = new Size(125, 27);
            tb_motor.TabIndex = 17;
            // 
            // tb_potencia
            // 
            tb_potencia.Location = new Point(525, 246);
            tb_potencia.Name = "tb_potencia";
            tb_potencia.Size = new Size(125, 27);
            tb_potencia.TabIndex = 18;
            // 
            // tb_kms
            // 
            tb_kms.Location = new Point(525, 279);
            tb_kms.Name = "tb_kms";
            tb_kms.Size = new Size(125, 27);
            tb_kms.TabIndex = 19;
            // 
            // tb_matricula
            // 
            tb_matricula.Location = new Point(525, 320);
            tb_matricula.Name = "tb_matricula";
            tb_matricula.Size = new Size(125, 27);
            tb_matricula.TabIndex = 20;
            // 
            // rb_novo
            // 
            rb_novo.AutoSize = true;
            rb_novo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rb_novo.Location = new Point(108, 46);
            rb_novo.Name = "rb_novo";
            rb_novo.Size = new Size(122, 24);
            rb_novo.TabIndex = 21;
            rb_novo.TabStop = true;
            rb_novo.Text = "Veiculo Novo";
            rb_novo.UseVisualStyleBackColor = true;
            // 
            // rb_usado
            // 
            rb_usado.AutoSize = true;
            rb_usado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rb_usado.Location = new Point(259, 46);
            rb_usado.Name = "rb_usado";
            rb_usado.Size = new Size(132, 24);
            rb_usado.TabIndex = 22;
            rb_usado.TabStop = true;
            rb_usado.Text = "Veiculo Antigo";
            rb_usado.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_adicionar.Location = new Point(690, 117);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(107, 44);
            btn_adicionar.TabIndex = 23;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_alterar.Location = new Point(690, 173);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(107, 44);
            btn_alterar.TabIndex = 24;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_eliminar.Location = new Point(690, 233);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(107, 48);
            btn_eliminar.TabIndex = 25;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(705, 50);
            label10.Name = "label10";
            label10.Size = new Size(69, 28);
            label10.TabIndex = 26;
            label10.Text = "Filtrar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_automoveis);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 372);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listar Automóveis";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(416, 91);
            label11.Name = "label11";
            label11.Size = new Size(35, 28);
            label11.TabIndex = 28;
            label11.Text = "Id:";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(525, 84);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(125, 27);
            tb_id.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_id);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_alterar);
            Controls.Add(btn_adicionar);
            Controls.Add(rb_usado);
            Controls.Add(rb_novo);
            Controls.Add(tb_matricula);
            Controls.Add(tb_kms);
            Controls.Add(tb_potencia);
            Controls.Add(tb_motor);
            Controls.Add(tb_preco);
            Controls.Add(tb_modelo);
            Controls.Add(tb_marca);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbb_filtro);
            Controls.Add(btn_sair);
            Controls.Add(btn_abrir);
            Controls.Add(label1);
            Controls.Add(tb_caminho);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_caminho;
        private Label label1;
        private Button btn_abrir;
        private Button btn_sair;
        private ComboBox cbb_filtro;
        private ListBox lb_automoveis;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_marca;
        private TextBox tb_modelo;
        private TextBox tb_preco;
        private TextBox tb_motor;
        private TextBox tb_potencia;
        private TextBox tb_kms;
        private TextBox tb_matricula;
        private RadioButton rb_novo;
        private RadioButton rb_usado;
        private Button btn_adicionar;
        private Button btn_alterar;
        private Button btn_eliminar;
        private Label label10;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox tb_id;
    }
}
