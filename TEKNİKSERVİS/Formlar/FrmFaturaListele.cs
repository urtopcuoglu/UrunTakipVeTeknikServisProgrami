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
    public partial class FrmFaturaListele : Form
    {
        public FrmFaturaListele()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void FrmFaturaListele_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.tblFaturaBilgi
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT, 
                               u.VERGIDAIRESI,
                               CARI= u.tblCari.AD +" "+u.tblCari.SOYAD,
                               PERSONEL=u.tblPersonel.AD +" "+u.tblPersonel.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();
            //lookUpEdit1.Properties.DataSource = db.tblDepartman.ToList(); -- Eğer bu yöntem ile yaparsak gerekli gereksiz bütün sütunlar gelir
            lueMüsteri.Properties.DataSource = (from x in db.tblCari
                                                 select new
                                                 {
                                                    x.ID,
                                                    AD= x.AD +" " +x.SOYAD,
                                                    
                                                 }).ToList();
            lueCari.Properties.DataSource = (from x in db.tblPersonel
                                                select new
                                                {
                                                    x.ID,
                                                    AD= x.AD +" " +x.SOYAD
                                                    
                                                }).ToList();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.tblFaturaBilgi
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRESI,
                               CARI = u.tblCari.AD + " " + u.tblCari.SOYAD,
                               PERSONEL = u.tblPersonel.AD + " " + u.tblPersonel.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblFaturaBilgi T = new tblFaturaBilgi();
            T.SERI = txtSeri.Text;
            T.SIRANO = txtSıraNo.Text;
            T.TARIH = Convert.ToDateTime(txtTarih.Text);
            T.SAAT = TxtSaat.Text;
            T.VERGIDAIRESI = txtVergiDairesi.Text;
            T.CARI = int.Parse(lueMüsteri.EditValue.ToString());
            T.PERSONEL = short.Parse(lueCari.EditValue.ToString());
            db.tblFaturaBilgi.Add(T);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme kaydedilmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepID.Text);
            var deger = db.tblFaturaBilgi.Find(id);
            db.tblFaturaBilgi.Remove(deger);
            /*txtID'deki içeriği id'ye atadık.
                id değerindeki tüm içerikleri de 
                deger değikenine atayıp remove
                işlemini yaptı
             */
            db.SaveChanges();
            MessageBox.Show("Fatura Kaydı başarıyla silindi.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

           
        }
    }
}
