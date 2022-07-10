using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingToolkit.QRCode.Codec;
using System.Windows.Forms;


namespace TEKNİKSERVİS.Formlar
{
    public partial class FrmQRCode : Form
    {
        public FrmQRCode()
        {
            InitializeComponent();
        }

        private void FrmQRCode_Load(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(txtSeriNoQr.Text);
        }
    }
}
