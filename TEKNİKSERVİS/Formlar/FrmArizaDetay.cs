using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNİKSERVİS.Formlar
{
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }

        private void FrmArizaDetay_Load(object sender, EventArgs e)
        {

        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void btnAciklama_Click(object sender, EventArgs e)
        {
          /* 
            tblUrunTakip t = new tblUrunTakip();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERINO = txtSeriNO.Text;
            t.TARIH = DateTime.Parse(txtTarih.Text);
            db.tblUrunTakip.Add(t);
            db.SaveChanges();   
            MessageBox.Show("Ürün İşlemi Güncellendi","Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
          */

        }

        private void txtTarih_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
