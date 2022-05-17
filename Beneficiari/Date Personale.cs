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

    public partial class Form8 : Form
    {
        public SqlConnection co = new SqlConnection(@"Data Source=DESKTOP-6L0R2I1; Initial Catalog = Beneficiari1; Integrated Security=true;");
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            String sql = "Select Nume,Prenume,Localitatea,Email,Telefon from Beneficiar ORDER BY Nume";

            SqlCommand cmd = new SqlCommand(sql, co);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Beneficiar");
            if (dataGridView1.Rows.Count==0)    
            foreach (DataRow r in ds.Tables["Beneficiar"].Rows)
            {
                this.dataGridView1.Rows.Add(r["Nume"], r["Prenume"], r["Localitatea"], r["Email"], r["Telefon"]);
            }
            else
            {
                adapter.Fill(ds, "Beneficiar");
            }
        }
    }
    public class Personal
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Localitate { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public Personal(string nume, string prenume, string localitate, string email, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            Localitate = localitate;
            Email = email;
            Telefon = telefon;

        }
        public interface ISharedFolder
        {
            void ShowPersData();
        }
        public class SharedFolder : ISharedFolder
        {
            public void ShowPersData()
            {
                Console.WriteLine("Se executa operatia de scriere si citire a datelor clientilor");
            }
        }
        class SharedFolderProxy 
        {
            private ISharedFolder folder;
            private Personal pers;
            public SharedFolderProxy(Personal emp)
            {
               pers = emp;
            }
            public void PerformRWOperations()
            {
                    folder = new SharedFolder();
                Console.WriteLine("Proxy-ul apeleaza metoda de citire si scriere a datelor clientilor");
                    folder.ShowPersData();
  
               
            }
        }
    }
}
