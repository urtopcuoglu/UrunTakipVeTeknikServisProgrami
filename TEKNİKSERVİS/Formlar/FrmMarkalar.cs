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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();   
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.tblUrun.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new 
            {
                    Marka=z.Key,
                    Toplam=z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl7.Text = db.tblUrun.Count().ToString();
            labelControl3.Text = (from x in db.tblUrun
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl5.Text = (from x in db.tblUrun
                                   orderby x.SATISFIYATI descending
                                   select x.MARKA).FirstOrDefault();
            chartControl1.Series["Series 1"].Points.AddPoint("Lenovo",4);
            chartControl1.Series["Series 1"].Points.AddPoint("Dell", 5);
            chartControl1.Series["Series 1"].Points.AddPoint("Huawei", 3);
            chartControl1.Series["Series 1"].Points.AddPoint("Monster", 2);
            chartControl1.Series["Series 1"].Points.AddPoint("Casper", 1);

            chartControl2.Series["Series 1"].Points.AddPoint("Notebook", 4);
            chartControl2.Series["Series 1"].Points.AddPoint("Desktop", 5);
            chartControl2.Series["Series 1"].Points.AddPoint("Klavye", 3);
            chartControl2.Series["Series 1"].Points.AddPoint("Modem", 4);
            


        }

        private void pictureEdit8_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
