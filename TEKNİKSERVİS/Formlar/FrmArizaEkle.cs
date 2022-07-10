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
    public partial class FrmArizaEkle : Form
    {
        public FrmArizaEkle()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void btnSatis_Click(object sender, EventArgs e)
        {
            tblUrunKabul t = new tblUrunKabul();
            t.CARI = int.Parse(txtMüsteriID.Text);
            t.PERSONEL = short.Parse(txtPersonel.Text);
            t.GELİSTARİHİ = DateTime.Parse(txtTarih.Text);
            t.URUNSERINO = txtSeriNO.Text;
            db.tblUrunKabul.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arıza Kaydı Alındı.","Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Question);
            
        }
    }
}
