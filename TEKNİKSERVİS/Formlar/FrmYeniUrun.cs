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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
            tblUrun tb = new tblUrun();
            tb.AD = txtAD.Text;
            tb.ALISFIYATI = decimal.Parse(txtAlisFiyat.Text);
            tb.SATISFIYATI = decimal.Parse(txtSatisFiyatı.Text);
            tb.STOK = short.Parse(txtStok.Text);
            tb.KATEGORI = byte.Parse(txtKategori.Text);
            tb.MARKA = txtMarka.Text;
            db.tblUrun.Add(tb);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla eklendi","Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
           // FrmYeniUrun fr = new FrmYeniUrun();
            //fr.Hide();
        }

        
    }
}
