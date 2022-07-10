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
    public partial class FrmÜrünSatis : Form
    {
        public FrmÜrünSatis()
        {
            InitializeComponent();
        }

        private void FrmÜrünSatis_Load(object sender, EventArgs e)
        {

        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void btnSatis_Click(object sender, EventArgs e)
        {
            tblUrunHareket t = new tblUrunHareket();
            t.URUN = int.Parse(txtÜrünID.Text);
            t.MUSTERI = int.Parse(txtMüsteri.Text);
            t.PERSONEL = short.Parse(txtPersonel.Text);
            t.URUN = int.Parse(txtÜrünID.Text);
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.ADET = short.Parse(txtAdet.Text);
            t.FIYAT = decimal.Parse(txtSatisFiyat.Text);
            t.URUNSERINO = txtSeriNO.Text;
            db.tblUrunHareket.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Başarıyla Gerçekleştirildi.","Bilgi Mesajı",
            MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
