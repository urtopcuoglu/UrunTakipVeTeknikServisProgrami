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
    public partial class FrmArama : Form
    {
        public FrmArama()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void FrmArama_Load(object sender, EventArgs e)
        {

        }
        
        private void btnFaturaArama_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textID.Text);
            var degerler = (from u in db.tblFaturaDetay
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           }).Where(x=>x.FATURAID==id);
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
