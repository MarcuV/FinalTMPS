using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Beneficiari
{
    public partial class Modificarea : Form
    {
        MainMenu f = new MainMenu();
        String local;

        public Modificarea()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datele raman neschimbate");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            groupBox1.Visible = false;
            button1.Visible = false;
            groupBox2.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label14.Visible = true;
            label2.Visible = true;
   
            button3.Visible = true;
            label12.Visible = true;
            label18.Visible = true;
            label15.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label16.Visible = true;



            String selectnume;
            selectnume = "select ID,Nume,Prenume,Localitatea,Mediu,Email,Telefon,ID_Serviciu,Serviciu,ID_Produs,Produs,Pret from Beneficiar where ID = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(selectnume, f.co);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Beneficiar");
            label10.Text = "ID"; label11.Text = "Nume"; label12.Text = "Prenume"; label13.Text = "Localitatea";
            label17.Text = "Mediu"; label14.Text = "Email"; label15.Text = "Telefon"; label16.Text = "ID_Serviciu";
            label2.Text = "Serviciu"; label18.Text = "ID_Produs"; label19.Text = "Produs"; label20.Text = "Pret";

            foreach (DataRow r in ds.Tables["Beneficiar"].Rows)
            {
                label10.Text = label10.Text + "\n" + r["ID"] + "\n";
                label11.Text = label11.Text + "\n" + r["Nume"] + "\n";
                label12.Text = label12.Text + "\n" + r["Prenume"] + "\n";
                label13.Text = label13.Text + "\n" + r["Localitatea"] + "\n";
                label17.Text = label17.Text + "\n" + r["Mediu"] + "\n";
                label14.Text = label14.Text + "\n" + r["Email"] + "\n";
                label15.Text = label15.Text + "\n" + r["Telefon"] + "\n";
                label16.Text = label16.Text + "\n" + r["ID_Serviciu"] + "\n";
                label2.Text = label2.Text + "\n" + r["Serviciu"] + "\n";
                label18.Text = label18.Text + "\n" + r["ID_Produs"] + "\n";
                label19.Text = label19.Text + "\n" + r["Produs"] + "\n";
                label20.Text = label20.Text + "\n" + r["Pret"] + "\n";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
   
            button3.Visible = false;

            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label17.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label2.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
    

        }


        private void button3_Click(object sender, EventArgs e)
        {
            String inregsql;
            inregsql = "update Beneficiar set Nume='" + textBox3.Text + "',Prenume='" + textBox4.Text + "',Email='" + textBox6.Text +
                "',Telefon='" + textBox7.Text + "',Localitatea='" + textBox5.Text + "',Mediu='" + local + "',ID_Serviciu='" + textBox2.Text + "',Serviciu='" + textBox8.Text +
                "',ID_Produs='" + textBox11.Text + "',Produs='" + textBox12.Text + "',Pret='" + textBox9.Text + "' where ID='" + textBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(inregsql, f.co);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modificare reusita !");
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            local = "Urban";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            local = "Rural";
        }
    }
    public class Memento
    {
        int ID;
        string nume;
        string prenume;
        string telefon;
        string localitate;
        int ID_serviciu;
        string serviciu;
        int ID_produs;
        string produs;
        double pret;
     
        public Memento(int ID, string nume,string prenume, string telefon,string localitate,int ID_serviciu,string serviciu,int ID_produs,string produs, double pret)
        {
            this.nume = nume;
            this.prenume=prenume;
            this.telefon = telefon;
            this.localitate = localitate;
            this.ID_serviciu = ID_serviciu;
            this.ID_produs = ID_produs;
            this.pret = pret;
            this.serviciu = serviciu;
            this.produs=produs;
            this.pret = pret;
        
        }
        abstract class Approver
        {
            protected Approver SaveData;

            public void SetData(Approver saveddata)
            {
                this.SaveData = saveddata;
            }

            public abstract void ProcessRequest(Memento purchase);
        }

        class CheckData: Approver
        {
            public override void ProcessRequest(Memento purchase)
            {
              
                if (SaveData != null)
                {
                    Memento.ProcessRequest(purchase);
                }
            }
        }

        private static void ProcessRequest(Memento purchase)
        {
            Console.WriteLine("Requested has been processed");
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public string Localitate
        {
            get { return localitate; }
            set { localitate = value; }
        }
        public string Serviciu
        {
            get { return serviciu; }
            set { serviciu = value; }
        }
        public string Produs
        {
            get { return produs; }
            set { produs = value; }
        }
      
        
    }

}
