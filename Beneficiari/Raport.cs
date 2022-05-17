  using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Beneficiari
{
    public partial class Raport : Form
    {
        public Raport()
        {
            InitializeComponent();
        }
        public SqlConnection co = new SqlConnection(@"Data Source=DESKTOP-6L0R2I1; Initial Catalog = Beneficiari1; Integrated Security=true;");

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlCommand count_urban = new SqlCommand("   SELECT Count(Mediu) From Beneficiar where Mediu = 'Urban'", co);
            SqlCommand count_rural = new SqlCommand("   SELECT Count(Mediu) From Beneficiar where Mediu = 'Rural'", co);

            SqlDataAdapter adapter = new SqlDataAdapter(count_urban);
            SqlDataAdapter adapter1 = new SqlDataAdapter(count_rural);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "tabel1");
            adapter1.Fill(ds, "tabel2");
            textBox1.Text = Convert.ToString(ds.Tables[0].Rows[0][0].ToString()) + ":" + Convert.ToString(ds.Tables[1   ].Rows[0][0].ToString());
        }
    }
}
