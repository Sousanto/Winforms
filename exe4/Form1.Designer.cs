namespace exe4
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
            lb_formandos = new ListBox();
            tb_nome = new TextBox();
            btn_adicionar = new Button();
            btn_remover = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(88, 46);
            label1.Name = "label1";
            label1.Size = new Size(183, 41);
            label1.TabIndex = 0;
            label1.Text = "Formandos:";
            // 
            // lb_formandos
            // 
            lb_formandos.FormattingEnabled = true;
            lb_formandos.Location = new Point(88, 132);
            lb_formandos.Name = "lb_formandos";
            lb_formandos.Size = new Size(271, 184);
            lb_formandos.TabIndex = 1;
            // 
            // tb_nome
            // 
            tb_nome.Font = new Font("Segoe UI", 14F);
            tb_nome.Location = new Point(394, 51);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(319, 39);
            tb_nome.TabIndex = 2;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Font = new Font("Segoe UI", 20F);
            btn_adicionar.Location = new Point(394, 132);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(319, 69);
            btn_adicionar.TabIndex = 3;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // btn_remover
            // 
            btn_remover.Font = new Font("Segoe UI", 20F);
            btn_remover.Location = new Point(394, 247);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(319, 69);
            btn_remover.TabIndex = 4;
            btn_remover.Text = "Remover";
            btn_remover.UseVisualStyleBackColor = true;
            btn_remover.Click += btn_remover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_remover);
            Controls.Add(btn_adicionar);
            Controls.Add(tb_nome);
            Controls.Add(lb_formandos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lb_formandos;
        private TextBox tb_nome;
        private Button btn_adicionar;
        private Button btn_remover;
    }
}
