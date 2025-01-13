namespace SimularLogin
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
            tb_utilizador = new TextBox();
            label2 = new Label();
            tb_palavrapasse = new TextBox();
            lb_mensagem = new Label();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Utilizador:";
            // 
            // tb_utilizador
            // 
            tb_utilizador.Location = new Point(165, 39);
            tb_utilizador.Name = "tb_utilizador";
            tb_utilizador.Size = new Size(155, 27);
            tb_utilizador.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 2;
            label2.Text = "Palavra-Passe:";
            // 
            // tb_palavrapasse
            // 
            tb_palavrapasse.Location = new Point(165, 95);
            tb_palavrapasse.Name = "tb_palavrapasse";
            tb_palavrapasse.Size = new Size(155, 27);
            tb_palavrapasse.TabIndex = 3;
            // 
            // lb_mensagem
            // 
            lb_mensagem.AutoSize = true;
            lb_mensagem.Font = new Font("Segoe UI", 12F);
            lb_mensagem.Location = new Point(196, 240);
            lb_mensagem.Name = "lb_mensagem";
            lb_mensagem.Size = new Size(108, 28);
            lb_mensagem.TabIndex = 4;
            lb_mensagem.Text = "Mensagem";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_login.Location = new Point(165, 146);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(155, 62);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(lb_mensagem);
            Controls.Add(tb_palavrapasse);
            Controls.Add(label2);
            Controls.Add(tb_utilizador);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_utilizador;
        private Label label2;
        private TextBox tb_palavrapasse;
        private Label lb_mensagem;
        private Button btn_login;
    }
}
