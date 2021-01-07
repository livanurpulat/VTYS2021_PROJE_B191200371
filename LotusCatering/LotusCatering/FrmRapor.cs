using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LotusCatering
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-59M902F;Initial Catalog=LotusCtr;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From MUSTERI");
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From SIPARIS");
        }

        private void btnMenuler_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From MENU");
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            verilerigoster("Select*From OrderInvoice");
        }
    }
}
