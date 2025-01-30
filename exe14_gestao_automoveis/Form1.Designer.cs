namespace exe14_gestao_automoveis
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


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lb_automoveis = new ListBox();
            tb_caminho = new TextBox();
            btn_escolher = new Button();
            openFileDialog1 = new OpenFileDialog();
            btn_sair = new Button();
            btn_ver = new Button();
            cbb_veiculos = new ComboBox();
            btn_adicionar = new Button();
            btn_alterar = new Button();
            btn_iliminar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tb_id = new TextBox();
            tb_modelo = new TextBox();
            tb_preco = new TextBox();
            tb_motor = new TextBox();
            tb_potencia = new TextBox();
            tb_kms = new TextBox();
            tb_matriculas = new TextBox();
            btn_verUsados = new Button();
            btn_verNovos = new Button();
            rb_novo = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            tb_marca = new TextBox();
            idOuMatricula = new Label();
            tb_idOuMatricula = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "Ficheiro:";
            // 
            // lb_automoveis
            // 
            lb_automoveis.FormattingEnabled = true;
            lb_automoveis.Location = new Point(22, 26);
            lb_automoveis.Name = "lb_automoveis";
            lb_automoveis.Size = new Size(366, 344);
            lb_automoveis.TabIndex = 1;
            // 
            // tb_caminho
            // 
            tb_caminho.Location = new Point(100, 42);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.Size = new Size(702, 27);
            tb_caminho.TabIndex = 2;
            // 
            // btn_escolher
            // 
            btn_escolher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_escolher.Location = new Point(808, 33);
            btn_escolher.Name = "btn_escolher";
            btn_escolher.Size = new Size(105, 38);
            btn_escolher.TabIndex = 3;
            btn_escolher.Text = "Escolher";
            btn_escolher.UseVisualStyleBackColor = true;
            btn_escolher.Click += btn_escolher_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_sair.Location = new Point(808, 399);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(97, 39);
            btn_sair.TabIndex = 4;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_ver
            // 
            btn_ver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ver.Location = new Point(808, 99);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(105, 36);
            btn_ver.TabIndex = 5;
            btn_ver.Text = "Ver";
            btn_ver.UseVisualStyleBackColor = true;
            btn_ver.Click += btn_ver_Click;
            // 
            // cbb_veiculos
            // 
            cbb_veiculos.Font = new Font("Segoe UI", 12F);
            cbb_veiculos.FormattingEnabled = true;
            cbb_veiculos.Location = new Point(669, 99);
            cbb_veiculos.Name = "cbb_veiculos";
            cbb_veiculos.Size = new Size(133, 36);
            cbb_veiculos.TabIndex = 6;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_adicionar.Location = new Point(800, 285);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(113, 39);
            btn_adicionar.TabIndex = 7;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_alterar.Location = new Point(705, 399);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(105, 39);
            btn_alterar.TabIndex = 8;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_iliminar
            // 
            btn_iliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_iliminar.Location = new Point(800, 330);
            btn_iliminar.Name = "btn_iliminar";
            btn_iliminar.Size = new Size(113, 44);
            btn_iliminar.TabIndex = 9;
            btn_iliminar.Text = "Iliminar";
            btn_iliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_automoveis);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 372);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Automoveis existentes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(486, 144);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 11;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(486, 204);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 12;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(486, 240);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 13;
            label4.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(486, 280);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 14;
            label5.Text = "Motor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(486, 317);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 15;
            label6.Text = "Potencia:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(486, 354);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 16;
            label7.Text = "Kms:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(486, 388);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 17;
            label8.Text = "Matriculas:";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(574, 137);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(125, 27);
            tb_id.TabIndex = 18;
            // 
            // tb_modelo
            // 
            tb_modelo.Location = new Point(574, 201);
            tb_modelo.Name = "tb_modelo";
            tb_modelo.Size = new Size(125, 27);
            tb_modelo.TabIndex = 19;
            // 
            // tb_preco
            // 
            tb_preco.Location = new Point(574, 240);
            tb_preco.Name = "tb_preco";
            tb_preco.Size = new Size(125, 27);
            tb_preco.TabIndex = 20;
            // 
            // tb_motor
            // 
            tb_motor.Location = new Point(574, 273);
            tb_motor.Name = "tb_motor";
            tb_motor.Size = new Size(125, 27);
            tb_motor.TabIndex = 21;
            // 
            // tb_potencia
            // 
            tb_potencia.Location = new Point(574, 310);
            tb_potencia.Name = "tb_potencia";
            tb_potencia.Size = new Size(125, 27);
            tb_potencia.TabIndex = 22;
            // 
            // tb_kms
            // 
            tb_kms.Location = new Point(574, 347);
            tb_kms.Name = "tb_kms";
            tb_kms.Size = new Size(125, 27);
            tb_kms.TabIndex = 23;
            // 
            // tb_matriculas
            // 
            tb_matriculas.Location = new Point(574, 381);
            tb_matriculas.Name = "tb_matriculas";
            tb_matriculas.Size = new Size(125, 27);
            tb_matriculas.TabIndex = 24;
            // 
            // btn_verUsados
            // 
            btn_verUsados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_verUsados.Location = new Point(772, 141);
            btn_verUsados.Name = "btn_verUsados";
            btn_verUsados.Size = new Size(141, 36);
            btn_verUsados.TabIndex = 25;
            btn_verUsados.Text = "Ver Usados";
            btn_verUsados.UseVisualStyleBackColor = true;
            // 
            // btn_verNovos
            // 
            btn_verNovos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_verNovos.Location = new Point(772, 183);
            btn_verNovos.Name = "btn_verNovos";
            btn_verNovos.Size = new Size(141, 36);
            btn_verNovos.TabIndex = 26;
            btn_verNovos.Text = "Ver Novos";
            btn_verNovos.UseVisualStyleBackColor = true;
            // 
            // rb_novo
            // 
            rb_novo.AutoSize = true;
            rb_novo.Location = new Point(505, 99);
            rb_novo.Name = "rb_novo";
            rb_novo.Size = new Size(117, 24);
            rb_novo.TabIndex = 27;
            rb_novo.TabStop = true;
            rb_novo.Text = "radioButton1";
            rb_novo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(486, 174);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 28;
            label9.Text = "Marca:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(586, 183);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 29;
            // 
            // tb_marca
            // 
            tb_marca.Location = new Point(574, 168);
            tb_marca.Name = "tb_marca";
            tb_marca.Size = new Size(125, 27);
            tb_marca.TabIndex = 30;
            // 
            // idOuMatricula
            // 
            idOuMatricula.AutoSize = true;
            idOuMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            idOuMatricula.Location = new Point(486, 418);
            idOuMatricula.Name = "idOuMatricula";
            idOuMatricula.Size = new Size(88, 20);
            idOuMatricula.TabIndex = 31;
            idOuMatricula.Text = "Matricula2:";
            // 
            // tb_idOuMatricula
            // 
            tb_idOuMatricula.Location = new Point(574, 411);
            tb_idOuMatricula.Name = "tb_idOuMatricula";
            tb_idOuMatricula.Size = new Size(125, 27);
            tb_idOuMatricula.TabIndex = 32;
            // 
            // Form1
            // 
            ClientSize = new Size(807, 461);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        // 
        // Form1
        // 


        #endregion

        private Label label1;
        private ListBox lb_automoveis;
        private TextBox tb_caminho;
        private Button btn_escolher;
        private OpenFileDialog openFileDialog1;
        private Button btn_sair;
        private Button btn_ver;
        private ComboBox cbb_veiculos;
        private Button btn_adicionar;
        private Button btn_alterar;
        private Button btn_iliminar;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tb_id;
        private TextBox tb_modelo;
        private TextBox tb_preco;
        private TextBox tb_motor;
        private TextBox tb_potencia;
        private TextBox tb_kms;
        private TextBox tb_matriculas;
        private Button btn_verUsados;
        private Button btn_verNovos;
        private RadioButton rb_novo;
        private Label label9;
        private Label label10;
        private TextBox tb_marca;
        private Label idOuMatricula;
        private TextBox tb_idOuMatricula;
    }
}
