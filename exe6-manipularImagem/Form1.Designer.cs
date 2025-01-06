namespace exe6_manipularImagem
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
            tb_caminho = new Label();
            textBox1 = new TextBox();
            pb_imagem = new PictureBox();
            btn_escolher = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pb_imagem).BeginInit();
            SuspendLayout();
            // 
            // tb_caminho
            // 
            tb_caminho.AutoSize = true;
            tb_caminho.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_caminho.Location = new Point(36, 31);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.Size = new Size(100, 28);
            tb_caminho.TabIndex = 0;
            tb_caminho.Text = "Caminho:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(155, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(589, 27);
            textBox1.TabIndex = 1;
            // 
            // pb_imagem
            // 
            pb_imagem.Location = new Point(36, 88);
            pb_imagem.Name = "pb_imagem";
            pb_imagem.Size = new Size(717, 216);
            pb_imagem.TabIndex = 2;
            pb_imagem.TabStop = false;
            // 
            // btn_escolher
            // 
            btn_escolher.Location = new Point(91, 326);
            btn_escolher.Name = "btn_escolher";
            btn_escolher.Size = new Size(613, 74);
            btn_escolher.TabIndex = 3;
            btn_escolher.TabStop = false;
            btn_escolher.Text = "Escolher a imagem";
            btn_escolher.UseVisualStyleBackColor = true;
            btn_escolher.Click += btn_escolher_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_escolher);
            Controls.Add(pb_imagem);
            Controls.Add(textBox1);
            Controls.Add(tb_caminho);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tb_caminho;
        private TextBox textBox1;
        private PictureBox pb_imagem;
        private Button btn_escolher;
        private OpenFileDialog openFileDialog1;
    }
}
