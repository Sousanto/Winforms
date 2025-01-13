namespace exe2_visibleEenable
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
            lbl_data = new Label();
            dtp_data = new DateTimePicker();
            lbl_curso = new Label();
            cbb_curso = new ComboBox();
            lbl_qual = new Label();
            tb_qual = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lb_qual2 = new Label();
            tb_qual2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_data.Location = new Point(51, 60);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(92, 41);
            lbl_data.TabIndex = 0;
            lbl_data.Text = "Data:";
            lbl_data.Click += lbl_data_Click;
            // 
            // dtp_data
            // 
            dtp_data.Location = new Point(168, 72);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(250, 27);
            dtp_data.TabIndex = 1;
            // 
            // lbl_curso
            // 
            lbl_curso.AutoSize = true;
            lbl_curso.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_curso.Location = new Point(51, 200);
            lbl_curso.Name = "lbl_curso";
            lbl_curso.Size = new Size(106, 41);
            lbl_curso.TabIndex = 2;
            lbl_curso.Text = "Curso:";
            // 
            // cbb_curso
            // 
            cbb_curso.FormattingEnabled = true;
            cbb_curso.Items.AddRange(new object[] { "CET TPSI", "CET Redes", "CET Multimédia", "Outro" });
            cbb_curso.Location = new Point(168, 214);
            cbb_curso.Name = "cbb_curso";
            cbb_curso.Size = new Size(194, 28);
            cbb_curso.TabIndex = 3;
            cbb_curso.SelectedIndexChanged += cbb_curso_SelectedIndexChanged;
            // 
            // lbl_qual
            // 
            lbl_qual.AutoSize = true;
            lbl_qual.Font = new Font("Segoe UI", 16F);
            lbl_qual.Location = new Point(27, 60);
            lbl_qual.Name = "lbl_qual";
            lbl_qual.Size = new Size(92, 37);
            lbl_qual.TabIndex = 4;
            lbl_qual.Text = "Qual ?";
            // 
            // tb_qual
            // 
            tb_qual.Location = new Point(148, 70);
            tb_qual.Name = "tb_qual";
            tb_qual.Size = new Size(195, 27);
            tb_qual.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_qual);
            panel1.Controls.Add(lbl_qual);
            panel1.Location = new Point(368, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 113);
            panel1.TabIndex = 6;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tb_qual2);
            panel2.Controls.Add(lb_qual2);
            panel2.Enabled = false;
            panel2.Location = new Point(368, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 126);
            panel2.TabIndex = 7;
            // 
            // lb_qual2
            // 
            lb_qual2.AutoSize = true;
            lb_qual2.Font = new Font("Segoe UI", 16F);
            lb_qual2.Location = new Point(27, 35);
            lb_qual2.Name = "lb_qual2";
            lb_qual2.Size = new Size(92, 37);
            lb_qual2.TabIndex = 5;
            lb_qual2.Text = "Qual ?";
            // 
            // tb_qual2
            // 
            tb_qual2.Location = new Point(148, 35);
            tb_qual2.Name = "tb_qual2";
            tb_qual2.Size = new Size(195, 27);
            tb_qual2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cbb_curso);
            Controls.Add(lbl_curso);
            Controls.Add(dtp_data);
            Controls.Add(lbl_data);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_data;
        private DateTimePicker dtp_data;
        private Label lbl_curso;
        private ComboBox cbb_curso;
        private Label lbl_qual;
        private TextBox tb_qual;
        private Panel panel1;
        private Panel panel2;
        private TextBox tb_qual2;
        private Label lb_qual2;
    }
}
