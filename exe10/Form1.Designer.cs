namespace exe10
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
            rtb_texto = new RichTextBox();
            button1 = new Button();
            btn_gtmac = new Button();
            label1 = new Label();
            tb_endereco = new TextBox();
            btn_ping = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rb_all = new RadioButton();
            rb_renew = new RadioButton();
            rb_release = new RadioButton();
            btn_executar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // rtb_texto
            // 
            rtb_texto.Location = new Point(308, 40);
            rtb_texto.Name = "rtb_texto";
            rtb_texto.Size = new Size(480, 398);
            rtb_texto.TabIndex = 0;
            rtb_texto.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(33, 40);
            button1.Name = "button1";
            button1.Size = new Size(254, 40);
            button1.TabIndex = 1;
            button1.Text = "NET SHARE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_gtmac
            // 
            btn_gtmac.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_gtmac.Location = new Point(33, 86);
            btn_gtmac.Name = "btn_gtmac";
            btn_gtmac.Size = new Size(254, 38);
            btn_gtmac.TabIndex = 2;
            btn_gtmac.Text = "GETMAC";
            btn_gtmac.UseVisualStyleBackColor = true;
            btn_gtmac.Click += btn_gtmac_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 31);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Endereço:";
            // 
            // tb_endereco
            // 
            tb_endereco.Location = new Point(82, 31);
            tb_endereco.Name = "tb_endereco";
            tb_endereco.Size = new Size(161, 27);
            tb_endereco.TabIndex = 4;
            // 
            // btn_ping
            // 
            btn_ping.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ping.Location = new Point(6, 76);
            btn_ping.Name = "btn_ping";
            btn_ping.Size = new Size(237, 47);
            btn_ping.TabIndex = 5;
            btn_ping.Text = "Ping";
            btn_ping.UseVisualStyleBackColor = true;
            btn_ping.Click += btn_ping_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ping);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_endereco);
            groupBox1.Location = new Point(33, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 155);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ping";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_executar);
            groupBox2.Controls.Add(rb_release);
            groupBox2.Controls.Add(rb_renew);
            groupBox2.Controls.Add(rb_all);
            groupBox2.Location = new Point(33, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "IPCONFIG";
            // 
            // rb_all
            // 
            rb_all.AutoSize = true;
            rb_all.Location = new Point(6, 26);
            rb_all.Name = "rb_all";
            rb_all.Size = new Size(52, 24);
            rb_all.TabIndex = 0;
            rb_all.TabStop = true;
            rb_all.Text = "/all";
            rb_all.UseVisualStyleBackColor = true;
            // 
            // rb_renew
            // 
            rb_renew.AutoSize = true;
            rb_renew.Location = new Point(6, 56);
            rb_renew.Name = "rb_renew";
            rb_renew.Size = new Size(76, 24);
            rb_renew.TabIndex = 1;
            rb_renew.TabStop = true;
            rb_renew.Text = "/renew";
            rb_renew.UseVisualStyleBackColor = true;
            // 
            // rb_release
            // 
            rb_release.AutoSize = true;
            rb_release.Location = new Point(6, 86);
            rb_release.Name = "rb_release";
            rb_release.Size = new Size(83, 24);
            rb_release.TabIndex = 2;
            rb_release.TabStop = true;
            rb_release.Text = "/release";
            rb_release.UseVisualStyleBackColor = true;
            // 
            // btn_executar
            // 
            btn_executar.Location = new Point(120, 39);
            btn_executar.Name = "btn_executar";
            btn_executar.Size = new Size(94, 59);
            btn_executar.TabIndex = 3;
            btn_executar.Text = "EXECUTAR";
            btn_executar.UseVisualStyleBackColor = true;
            btn_executar.Click += btn_executar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_gtmac);
            Controls.Add(button1);
            Controls.Add(rtb_texto);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_texto;
        private Button button1;
        private Button btn_gtmac;
        private Label label1;
        private TextBox tb_endereco;
        private Button btn_ping;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_executar;
        private RadioButton rb_release;
        private RadioButton rb_renew;
        private RadioButton rb_all;
    }
}
