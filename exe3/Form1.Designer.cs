namespace exe3
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
            //label2 = new Label();
            cbb_curso = new ComboBox();
            clb_modulos = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(91, 65);
            label1.Name = "label1";
            label1.Size = new Size(121, 46);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // label2
            // 
            //label2.AutoSize = true;
            //label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            //label2.Location = new Point(91, 211);
            //label2.Name = "label2";
            //label2.Size = new Size(156, 46);
            //label2.TabIndex = 1;
            //label2.Text = "Módulo:";
            //label2.Click += label2_Click;
            // 
            // cbb_curso
            // 
            cbb_curso.FormattingEnabled = true;
            cbb_curso.Items.AddRange(new object[] { "CET TPSI", "CET Redes", "CET Multimédia", "EFA Robótica" });
            cbb_curso.Location = new Point(261, 83);
            cbb_curso.Name = "cbb_curso";
            cbb_curso.Size = new Size(429, 28);
            cbb_curso.TabIndex = 2;
            cbb_curso.SelectedIndexChanged += cbb_curso_SelectedIndexChanged;
            // 
            // clb_modulos
            // 
            clb_modulos.FormattingEnabled = true;
            clb_modulos.Location = new Point(261, 229);
            clb_modulos.Name = "clb_modulos";
            clb_modulos.Size = new Size(437, 136);
            clb_modulos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clb_modulos);
            Controls.Add(cbb_curso);
            //Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
       // private Label label2;
        private ComboBox cbb_curso;
        private CheckedListBox clb_modulos;
    }
}
