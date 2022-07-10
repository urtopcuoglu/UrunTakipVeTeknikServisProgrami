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
    public partial class FrmArızaListesi : Form
    {
        public FrmArızaListesi()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void FrmArızaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.tblUrunKabul select new
            {
                x.ISLEMID,
                //ÜRÜN=x.tblUrun.AD,
                CARİ = x.tblCari.AD + x.tblCari.SOYAD,
                PERSONEL = x.tblPersonel.AD + x.tblPersonel.SOYAD,
                x.GELİSTARİHİ,
                x.CIKISTARİHİ,
                x.URUNSERINO
            };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
