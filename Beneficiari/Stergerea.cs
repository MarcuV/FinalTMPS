using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Beneficiari
{
    public partial class Stergerea : Form
    {
        MainMenu f = new MainMenu();
        public Stergerea()
        {
            InitializeComponent();
        }
        public SqlConnection co = new SqlConnection(@"
Initial Catalog = Benefeciari1; Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            string deletesql;
            deletesql = "delete from Beneficiar where ID='";
            deletesql += textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(deletesql, f.co);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Stergere reusita !");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stergerea_Load(object sender, EventArgs e)
        {

        }
    }
}
