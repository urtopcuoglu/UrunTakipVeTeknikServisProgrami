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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();   
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            //listeleme
            var degerler = from k in db.tblKategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList(); 
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
                tblKategori t = new tblKategori();
                t.AD = txtAd.Text;
                db.tblKategori.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Eklenmiştir.", "Bilgi Mesajı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                MessageBox.Show("Kategori Eklenemedi .Boş geçilmez veya Fazla Karakter Girdiniz", "Bilgi Mesajı",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.tblKategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblKategori.Find(id);
            db.tblKategori.Remove(deger);
            /*txtID'deki içeriği id'ye atadık.
                id değerindeki tüm içerikleri de 
                deger değikenine atayıp remove
                işlemini yaptı
             */
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla silindi.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblKategori.Find(id);
            deger.AD = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtID.Text = "";
        }
    }
}
