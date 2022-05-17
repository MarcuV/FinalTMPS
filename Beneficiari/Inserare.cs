using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Beneficiari
{
    public partial class Inserare : Form
    {
        String local;
        SqlConnection co;
        public Inserare()
        {
            InitializeComponent();
            co = new SqlConnection(@"Data Source=DESKTOP-6L0R2I1;Database=Beneficiari1;Trusted_Connection=yes;");
          
            co.Open();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
         
            string insertsql;
            insertsql = "insert into Beneficiar (ID,Nume,Prenume,Localitatea,Mediu,Email,Telefon,ID_Serviciu,Serviciu,ID_Produs,Produs,Pret) values " +
                "('"; insertsql += textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + local + "','"  + textBox6.Text + "','" 
                 + textBox7.Text  +"','" + textBox1.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + textBox9.Text + "')";
            SqlCommand cmd = new SqlCommand(insertsql, co);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inregistrare reusita !");
              this.Close();

        }
    
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            local= "Urban";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            local = "Rural";
        }

        private void Inserare_Load(object sender, EventArgs e)
        {

        }
    }
}
