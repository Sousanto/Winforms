
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Diagnostics.Eventing.Reader;



namespace exe10
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Process netshare = new Process();
            netshare.StartInfo.FileName = "net ";
            netshare.StartInfo.Arguments = "share";
            netshare.StartInfo.UseShellExecute = false;
            netshare.StartInfo.CreateNoWindow = true;
            netshare.StartInfo.RedirectStandardOutput = true;
            netshare.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);

            netshare.Start();
            rtb_texto.Text = netshare.StandardOutput.ReadToEnd();
        }

        private void btn_gtmac_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Process getmac = new Process();
            getmac.StartInfo.FileName = "getmac ";
            getmac.StartInfo.UseShellExecute = false;
            getmac.StartInfo.CreateNoWindow = true;
            getmac.StartInfo.RedirectStandardOutput = true;
            getmac.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);

            getmac.Start();
            rtb_texto.Text = getmac.StandardOutput.ReadToEnd();
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            if (tb_endereco.Text != "")
            {

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                Process ping = new Process();
                ping.StartInfo.FileName = "ping ";
                ping.StartInfo.Arguments = tb_endereco.Text;
                ping.StartInfo.UseShellExecute = false;
                ping.StartInfo.CreateNoWindow = true;
                ping.StartInfo.RedirectStandardOutput = true;
                ping.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);

                ping.Start();
                rtb_texto.Text = ping.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Preencha o endereço!!!");
            }
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Process ipconfig = new Process();
            ipconfig.StartInfo.FileName = "ipconfig ";

            if (rb_all.Checked)
            {
                ipconfig.StartInfo.Arguments = "/all";
            }
            else if (rb_renew.Checked) 
            {
                ipconfig.StartInfo.Arguments = "/renew";
            }
            else if (rb_release.Checked)
            {
                ipconfig.StartInfo.Arguments = "/release";
            }


            ipconfig.StartInfo.Arguments = tb_endereco.Text;
            ipconfig.StartInfo.UseShellExecute = false;
            ipconfig.StartInfo.CreateNoWindow = true;
            ipconfig.StartInfo.RedirectStandardOutput = true;
            ipconfig.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);

            ipconfig.Start();
            rtb_texto.Text = ipconfig.StandardOutput.ReadToEnd();
        }
    }

}
