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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tblCari t = new tblCari();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.TELEFON = txtTelefon.Text;
            t.MAIL = txtMail.Text;
            t.IL = txtİl.Text;  
            t.ILCE = txtİlce.Text;
            db.tblCari.Add(t);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Kaydedildi.","Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
