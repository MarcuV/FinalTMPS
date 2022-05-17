using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Beneficiari
{
    public partial class MainMenu : Form
    {
       
        public SqlConnection co = new SqlConnection(@"Data Source=DESKTOP-6L0R2I1; Initial Catalog = Beneficiari1; Integrated Security=true;");
        public MainMenu()
        {
            InitializeComponent();
      
            co.Open();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserare form2 = new Inserare();
            form2.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            dataGridView1.Visible = true;
            String sql = "Select * from Beneficiar";

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

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            String sql = "Select * from Beneficiar ORDER BY Nume";

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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stergerea form3 = new Stergerea();
            form3.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificarea form4 = new Modificarea();
            form4.Show();

        }

        private void ratioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raport form5 = new Raport();
            form5.Show();
        }

        private void mediulRuralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void deleteID0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string deletesql;
            deletesql = "delete from Beneficiar where ID='0'";
            SqlCommand cmd = new SqlCommand(deletesql,co);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Stergere reusita !");
        
        }

        private void displayByLocalitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void displayPersonalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }

}
