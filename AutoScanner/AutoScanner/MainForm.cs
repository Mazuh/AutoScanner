using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace AutoScanner
{
    public partial class MainForm : Form
    {

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ListBox lbDevices;

        /// <summary>
        ///     Default form constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     What happens after initialization.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> devices = WIAScanner.GetDevices();

            foreach (string device in devices)
            {
                lbDevices.Items.Add(device);
            }

            if (lbDevices.Items.Count == 0)
            {
                MessageBox.Show("Não foi detectado nenhum dispositivo que suporte scanner por Windows Image Acquisition (WIA).");
                this.Close();
            }
            else
            {
                lbDevices.SelectedIndex = 0;
            }
        }

        /// <summary>
        ///     An action for the scan button.
        ///     Try reach the selected device and save the image in a local file.
        /// </summary>
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
                foreach (Image image in images)
                {
                    image.Save(@"C:\MeusArquivos_AutoScanner\" + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpg", ImageFormat.Jpeg);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar a imagem: " + exc.Message);
            }
        }
 
    }
}
