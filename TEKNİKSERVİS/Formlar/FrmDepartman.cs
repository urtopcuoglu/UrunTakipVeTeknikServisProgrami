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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
       DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.tblDepartman
                           select new
                           {
                               u.ID,
                               u.AD
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl12.Text =db.tblDepartman.Count().ToString();
            labelControl14.Text =db.tblPersonel.Count().ToString();    
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblDepartman t = new tblDepartman();
            if (txtDepAd.Text.Length<=50 &&txtDepAd.Text!="")
            {
                t.AD = txtDepAd.Text;
                db.tblDepartman.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi", "Bilgi Mesajı",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Kayıt gerçekleştirilmedi.", "Bilgi Mesajı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepID.Text);
            var deger = db.tblDepartman.Find(id);
            db.tblDepartman.Remove(deger);
            /*txtID'deki içeriği id'ye atadık.
                id değerindeki tüm içerikleri de 
                deger değikenine atayıp remove
                işlemini yaptı
             */
            db.SaveChanges();
            MessageBox.Show("Departman başarıyla silindi.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepID.Text);
            var deger = db.tblDepartman.Find(id);
            deger.AD = txtDepAd.Text;
            db.SaveChanges();
            MessageBox.Show("Departman güncellendi.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.tblDepartman
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDepID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtDepAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
          //  txtDepAcıklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            
        }
    }
}
