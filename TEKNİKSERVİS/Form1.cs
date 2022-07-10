using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNİKSERVİS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunListesi frmUrunList = new Formlar.FrmUrunListesi();
            frmUrunList.MdiParent= this; //mdi nesnesi bu formda açılacak
            frmUrunList.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //btn yeni ürün
            Formlar.FrmYeniUrun frmUrunList = new Formlar.FrmYeniUrun();
            
            frmUrunList.Show();
        }

        private void BtnKategoriListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategori frmKategori = new Formlar.FrmKategori();
            frmKategori.MdiParent = this; //mdi nesnesi bu formda açılacak
            frmKategori.Show();
        }

        private void btnKategoriEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori  frmYeniKategori = new Formlar.FrmYeniKategori();
            frmYeniKategori.Show();
        }

        private void btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frmİstatistik frmİstatistik = new Formlar.Frmİstatistik();
            frmİstatistik.MdiParent = this;
            frmİstatistik.Show();
        }

        private void btnMarkaİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmMarkalar frmMarka = new Formlar.FrmMarkalar();
            frmMarka.MdiParent = this;
            frmMarka.Show();
        }

        private void btnCariListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariListesi frmCari = new Formlar.FrmCariListesi();
            frmCari.MdiParent = this;
            frmCari.Show();
        }

        private void btnCariİlİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariİller frmCariİller = new Formlar.FrmCariİller();  
            frmCariİller.MdiParent = this;
            frmCariİller.Show();    
        }

        private void btnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle frmCariEkle = new Formlar.FrmCariEkle();
            //frmCariEkle.MdiParent = this;
            frmCariEkle.Show();
        }

        private void btnDepartmanListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartman frmDepartman = new Formlar.FrmDepartman();
            frmDepartman.MdiParent = this;
            frmDepartman.Show();
        }

        private void btnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanEkleme frmDepartmanEkleme = new Formlar.FrmDepartmanEkleme();
           // frmDepartmanEkleme.MdiParent = this;
            frmDepartmanEkleme.Show();
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonel frmPersonel = new Formlar.FrmPersonel();
            frmPersonel.MdiParent = this;
            frmPersonel.Show();
        }

        private void btnCalc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnDöviz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKurlar frmKurlar = new Formlar.FrmKurlar();
            frmKurlar.MdiParent = this;
            frmKurlar.Show();
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnHaber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* Formlar.FrmHaber frmHaber = new Formlar.FrmHaber();
            frmHaber.MdiParent = this;
            frmHaber.Show(); */
        }

        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYoutube frmYoutube = new Formlar.FrmYoutube();
            frmYoutube.MdiParent = this;
            frmYoutube.Show();
        }

        private void btnArizaliÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArızaListesi frmArizaListesi = new Formlar.FrmArızaListesi();
            frmArizaListesi.MdiParent = this;
            frmArizaListesi.Show();
        }

        private void btnYeniÜrün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmÜrünSatis frmÜrünSatis = new Formlar.FrmÜrünSatis();
            // frmDepartmanEkleme.MdiParent = this;
            frmÜrünSatis.Show();
        }

        private void btnSatisÜrünüListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSatisListele frmSatisListele = new Formlar.FrmSatisListele();
            frmSatisListele.MdiParent = this;
            frmSatisListele.Show();
        }

        private void btnYeniArizaKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaEkle frmArizaEkle = new Formlar.FrmArizaEkle();
            // frmDepartmanEkleme.MdiParent = this;
            frmArizaEkle.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetay frmArizaDetay = new Formlar.FrmArizaDetay();
            frmArizaDetay.Show(); 
            
        }

        private void btnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQRCode frmCode = new Formlar.FrmQRCode();
            frmCode.Show();
        }

        private void btnFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaListele frmFaturaListele = new Formlar.FrmFaturaListele();
            frmFaturaListele.MdiParent = this;
            frmFaturaListele.Show();    
        }

        private void btnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FaturaKalem frmFaturaKalem = new Formlar.FaturaKalem();
            frmFaturaKalem.MdiParent = this;
            frmFaturaKalem.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnFaturaArama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArama frmArama = new Formlar.FrmArama();
            frmArama.MdiParent = this;
            frmArama.Show();
        }
    }
}