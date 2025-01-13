namespace exe8
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
            label2 = new Label();
            lbl_x = new Label();
            lbl_y = new Label();
            pb_area = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_area).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(73, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 46);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(73, 124);
            label2.Name = "label2";
            label2.Size = new Size(50, 46);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.Font = new Font("Segoe UI", 20F);
            lbl_x.Location = new Point(130, 43);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new Size(38, 46);
            lbl_x.TabIndex = 2;
            lbl_x.Text = "0";
            // 
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Font = new Font("Segoe UI", 20F);
            lbl_y.Location = new Point(129, 124);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new Size(38, 46);
            lbl_y.TabIndex = 3;
            lbl_y.Text = "0";
            // 
            // pb_area
            // 
            pb_area.BorderStyle = BorderStyle.FixedSingle;
            pb_area.Location = new Point(286, 43);
            pb_area.Name = "pb_area";
            pb_area.Size = new Size(387, 305);
            pb_area.TabIndex = 4;
            pb_area.TabStop = false;
            pb_area.MouseDown += pb_area_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_area);
            Controls.Add(lbl_y);
            Controls.Add(lbl_x);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_area).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_x;
        private Label lbl_y;
        private PictureBox pb_area;
    }
}
