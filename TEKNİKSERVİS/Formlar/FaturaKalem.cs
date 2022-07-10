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
    public partial class FaturaKalem : Form
    {
        public FaturaKalem()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void FaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.tblFaturaDetay
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,                          
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblFaturaDetay t = new tblFaturaDetay();    
            t.URUN = txtURUN.Text;
            t.ADET = short.Parse(txtAdet.Text);
            t.FIYAT = decimal.Parse(txtFiyat.Text);
            t.TUTAR = decimal.Parse(txtTutar.Text);
            t.FATURAID = int.Parse(txtFaturaID.Text);
            db.tblFaturaDetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Detay & Kalem İşlemleri başarıyla Kaydedilmiştir","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.tblFaturaDetay
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
