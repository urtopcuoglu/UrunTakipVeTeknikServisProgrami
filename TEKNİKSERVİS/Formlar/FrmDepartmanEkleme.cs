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
    public partial class FrmDepartmanEkleme : Form
    {
        public FrmDepartmanEkleme()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tblDepartman t = new tblDepartman();
            t.AD = txtDepAd.Text;
            db.tblDepartman.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Eklenmiştir.", "Bilgi Mesajı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
