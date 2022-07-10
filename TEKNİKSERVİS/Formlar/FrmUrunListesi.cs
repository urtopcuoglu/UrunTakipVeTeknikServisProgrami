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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();

        /*entities ile veri modelinde tüm varlıklarım tutan nesnenin adı sqlconnection'a eş değer.
        entites veri modeli veritabanı tablolarımı class'lara çevirmeye yarayan bir sistem 
        Aynı zamanda tabloların sütunları class'lara dönüşmüş veri yapılarının properties'ini oluşturur.
        Kısaca SQL veri tiplerini C# veri tipleri ile eşleştiriyor 

        ** SQL tarafından kullanılan veri tiplerini;
               * int = int
               * varchar = string
               * bit = bool 
               * tinyint = byte
               * decimal = decimal
               * smallint = sort olarak tutuyor
              
        bu model aynı zamanda tablonun bağlı olduğu tablolar yine bu classlar içerisinde navigation properties özelliği görüyor
               
         */
        void metot1 ()
        {
            var degerler = from u in db.tblUrun
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI = u.tblKategori.AD,
                               u.STOK,
                               u.ALISFIYATI,
                               u.SATISFIYATI
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //var degerler = db.tblUrun.ToList(); // degerler değişkenine tüm ürünler tablosunu listemeyi ata
            metot1();
            lookUpEdit1.Properties.DataSource = db.tblKategori.ToList(); 
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            txtID.Text = "";
            txtUrunAd.Text = "";
            txtMarka.Text = "";
            txtAlisFiyati.Text = "";
            txtSatisFiyat.Text = "";
            txtStok.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            tblUrun t = new tblUrun(); //entites 
            t.AD = txtUrunAd.Text;
            t.MARKA = txtMarka.Text;
           /*burada ilk başta t.ALISFIYATI = txtAlisFiyatı.Text yazdığımızda hata 
            * verdi . Çünkü deicmal tanımlanmış bir veriyi string olarak göstermeye çalıştık
            * Bu sebepten ötürü decimal.Parse() convertini kullandık 
            *   SATISFIYATI'da yine aynı şekilde.
            */
            t.ALISFIYATI = decimal.Parse(txtAlisFiyati.Text);
            t.SATISFIYATI = decimal.Parse(txtSatisFiyat.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.DURUM = false;
            t.KATEGORI =byte.Parse(lookUpEdit1.EditValue.ToString());
            db.tblUrun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi","Bilgi Penceresi",
            MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
           // var degerler = db.tblUrun.ToList(); // degerler değişkenine tüm ürünler tablosunu listemeyi ata
            // gridControl1.DataSource = degerler;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtAlisFiyati.Text = gridView1.GetFocusedRowCellValue("ALISFIYATI").ToString();
            txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYATI").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
           
        }
        private void btnTEMIZLE_Click(object sender, EventArgs e)
        {
            
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblUrun.Find(id);
            db.tblUrun.Remove(deger);
            /*txtID'deki içeriği id'ye atadık.
                id değerindeki tüm içerikleri de 
                deger değikenine atayıp remove
                işlemini yaptı
             */
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblUrun.Find(id);
            deger.AD = txtUrunAd.Text;
            deger.STOK = short.Parse(txtStok.Text);
            deger.MARKA = txtMarka.Text;
            deger.ALISFIYATI = decimal.Parse(txtAlisFiyati.Text);
            deger.SATISFIYATI = decimal.Parse(txtSatisFiyat.Text);
            deger.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
