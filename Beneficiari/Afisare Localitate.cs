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
    public partial class Form7 : Form
    {
        public SqlConnection co = new SqlConnection(@"

Initial Catalog = Beneficiari1; Integrated Security=true;");
        private object data;

        public Form7()
        {
            InitializeComponent();

        }

        public void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
            String sql = @"Select * from Beneficiar WHERE Localitatea='";
            sql += textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, co);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Beneficiar");
            dataGridView1.Rows.Clear();

            if (dataGridView1.Rows.Count == 0) 

                foreach (DataRow r in ds.Tables["Beneficiar"].Rows)
                {
                    this.dataGridView1.Rows.Add(r["ID"], r["Nume"], r["Prenume"], r["Localitatea"], r["Mediu"], r["Email"], r["Telefon"], r["ID_Serviciu"], r["Serviciu"], r["ID_Produs"], r["Produs"], r["Pret"]);
                }

        }
  

        private void Form7_Load(object sender, EventArgs e)
        {

        }

    }

}
    
