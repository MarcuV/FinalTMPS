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

namespace Beneficiari
{
    public partial class Form6 : Form
    {
        public SqlConnection co = new SqlConnection(@"Data Source=DESKTOP-6L0R2I1; Initial Catalog = Beneficiari1; Integrated Security=true;");
        public Form6()
        {
            InitializeComponent();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
            String sql = @"Select * from Beneficiar WHERE Mediu='Rural'";

            SqlCommand cmd = new SqlCommand(sql, co);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Beneficiar");
            dataGridView1.Rows.Clear();
            foreach (DataRow r in ds.Tables["Beneficiar"].Rows)
            {
                this.dataGridView1.Rows.Add(r["ID"], r["Nume"], r["Prenume"], r["Localitatea"], r["Mediu"], r["Email"], r["Telefon"], r["ID_Serviciu"], r["Serviciu"], r["ID_Produs"], r["Produs"], r["Pret"]);
            }
        }
    }
}
