namespace exe5
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
            lbl_num1 = new Label();
            btn_jogar = new Button();
            lbl_num2 = new Label();
            lbl_num3 = new Label();
            label1 = new Label();
            lbl_saldo = new Label();
            SuspendLayout();
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            lbl_num1.Location = new Point(72, 57);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(81, 112);
            lbl_num1.TabIndex = 0;
            lbl_num1.Text = "-";
            // 
            // btn_jogar
            // 
            btn_jogar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_jogar.Location = new Point(185, 311);
            btn_jogar.Name = "btn_jogar";
            btn_jogar.Size = new Size(471, 106);
            btn_jogar.TabIndex = 1;
            btn_jogar.Text = "Jogar";
            btn_jogar.UseVisualStyleBackColor = true;
            btn_jogar.Click += btn_jogar_Click;
            // 
            // lbl_num2
            // 
            lbl_num2.AutoSize = true;
            lbl_num2.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            lbl_num2.Location = new Point(360, 57);
            lbl_num2.Name = "lbl_num2";
            lbl_num2.Size = new Size(81, 112);
            lbl_num2.TabIndex = 3;
            lbl_num2.Text = "-";
            // 
            // lbl_num3
            // 
            lbl_num3.AutoSize = true;
            lbl_num3.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            lbl_num3.Location = new Point(588, 57);
            lbl_num3.Name = "lbl_num3";
            lbl_num3.Size = new Size(81, 112);
            lbl_num3.TabIndex = 4;
            lbl_num3.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(559, 37);
            label1.Name = "label1";
            label1.Size = new Size(82, 35);
            label1.TabIndex = 5;
            label1.Text = "Saldo:";
            // 
            // lbl_saldo
            // 
            lbl_saldo.AutoSize = true;
            lbl_saldo.Font = new Font("Segoe UI", 15F);
            lbl_saldo.Location = new Point(647, 37);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(67, 35);
            lbl_saldo.TabIndex = 7;
            lbl_saldo.Text = "1000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_saldo);
            Controls.Add(label1);
            Controls.Add(lbl_num3);
            Controls.Add(lbl_num2);
            Controls.Add(btn_jogar);
            Controls.Add(lbl_num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_num1;
        private Button btn_jogar;
        private Label lbl_num2;
        private Label lbl_num3;
        private Label label1;
        private Label lbl_saldo;
    }
}
