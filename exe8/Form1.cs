namespace exe8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_area_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_x.Text = e.X.ToString();
            lbl_y.Text = e.Y.ToString();
        }
    }
}
