using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TEKNİKSERVİS.Formlar
{
    public partial class FrmCariİller : Form
    {
        public FrmCariİller()
        {
            InitializeComponent();
        }
        DBTEKNİKSERVİSEntities db = new DBTEKNİKSERVİSEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=THINKPAD-E470;Initial Catalog=DBTEKNİKSERVİS;Integrated Security=True");
        private void FrmCariİller_Load(object sender, EventArgs e)
        {
          /*  chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
            chartControl1.Series["Series 1"].Points.AddPoint("Kayseri", 12);
            chartControl1.Series["Series 1"].Points.AddPoint("İstanbul",10);
            chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 5);
            chartControl1.Series["Series 1"].Points.AddPoint("Almanya", 3); */

            gridControl1.DataSource = db.tblCari.OrderBy(x=>x.IL).GroupBy(y=>y.IL).
            Select(z=> new {
            IL = z.Key,TOPLAM = z.Count()}).ToList();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,COUNT(*) FROM tblCari group by IL",baglanti);
            SqlDataReader dr = komut.ExecuteReader();   
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
