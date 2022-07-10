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
    public partial class FrmSatisListele : Form
    {
        public FrmSatisListele()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void FrmSatisListele_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.tblUrunHareket
                           select new
                           {
                               x.HAREKETID,
                               x.tblUrun.AD,
                               MUSTERİ_BİLGİ = x.tblCari.AD +" "+ x.tblCari.SOYAD,
                               PERSONEL_BİLGİ = x.tblPersonel.AD +" "+ x.tblPersonel.SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.FIYAT,
                               x.URUNSERINO
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
