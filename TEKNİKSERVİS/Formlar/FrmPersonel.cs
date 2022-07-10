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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.tblPersonel
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();
            //lookUpEdit1.Properties.DataSource = db.tblDepartman.ToList(); -- Eğer bu yöntem ile yaparsak gerekli gereksiz bütün sütunlar gelir
            lookUpEdit1.Properties.DataSource = (from x in db.tblDepartman
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();

            string ad1,soyad1,ad2,soyad2,ad3,soyad3,ad4,soyad4;

            //1.Personel
            ad1 = db.tblPersonel.First(x => x.ID == 1).AD;
            soyad1 = db.tblPersonel.First(x => x.ID == 1).SOYAD;
            labelControl3.Text = ad1 + " " + soyad1;
            labelControl4.Text = db.tblPersonel.First(x => x.ID == 1).tblDepartman.AD;
            labelControl6.Text = db.tblPersonel.First(x => x.ID == 1).MAIL;
            //2.Personel 
            ad2 = db.tblPersonel.First(x => x.ID == 2).AD;
            soyad2 = db.tblPersonel.First(x => x.ID == 2).SOYAD;
            labelControl14.Text = ad2 + " " + soyad2;
            labelControl11.Text = db.tblPersonel.First(x => x.ID == 2).tblDepartman.AD;
            labelControl9.Text = db.tblPersonel.First(x => x.ID == 2).MAIL;
            //3.Personel 
            ad3 = db.tblPersonel.First(x => x.ID == 3).AD;
            soyad3 = db.tblPersonel.First(x => x.ID == 3).SOYAD;
            labelControl20.Text = ad3 + " " + soyad3;
            labelControl18.Text = db.tblPersonel.First(x => x.ID == 3).tblDepartman.AD;
            labelControl16.Text = db.tblPersonel.First(x => x.ID == 3).MAIL;
            //4.Personel
            ad4 = db.tblPersonel.First(x => x.ID == 4).AD;
            soyad4 = db.tblPersonel.First(x => x.ID == 4).SOYAD;
            labelControl26.Text = ad4 + " " + soyad4;
            labelControl24.Text = db.tblPersonel.First(x => x.ID == 4).tblDepartman.AD;
            labelControl22.Text = db.tblPersonel.First(x => x.ID == 4).MAIL;
        }
    }
}
