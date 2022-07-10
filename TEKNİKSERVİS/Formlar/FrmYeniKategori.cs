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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();   
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            tblKategori t = new tblKategori();
            t.AD = txtAD.Text;
            db.tblKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Eklenmiştir.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
