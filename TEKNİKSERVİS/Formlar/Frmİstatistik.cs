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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.tblUrun.Count().ToString();
            labelControl3.Text = db.tblKategori.Count().ToString();
            labelControl19.Text = (from x in db.tblUrun
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();// FirstOrDefault = İlk gelen değeri seçer
            labelControl7.Text = "10";
            labelControl5.Text = db.tblUrun.Sum(x => x.STOK).ToString();
            labelControl17.Text = (from x in db.tblUrun 
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.tblUrun
                                  orderby x.SATISFIYATI descending
                                  select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.tblUrun
                                   orderby x.SATISFIYATI ascending
                                   select x.AD).FirstOrDefault();
            labelControl35.Text = db.tblUrun.Count(x=> x.KATEGORI == 2).ToString();
            labelControl33.Text = db.tblUrun.Count(x => x.KATEGORI == 1).ToString();
            labelControl31.Text = db.tblUrun.Count(x => x.KATEGORI == 4).ToString();
            labelControl29.Text = (from x in db.tblUrun
                                   select x.MARKA).Distinct().Count().ToString();
            


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
