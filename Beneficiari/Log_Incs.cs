using System;
using System.Windows.Forms;

namespace Beneficiari
{
    public partial class Log_Incs : Form
    {

        public sealed class Singleton
        {

            private Singleton() { }


            private static Singleton _instance;
            public static Singleton GetInstance()
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }


        }

        public Log_Incs()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Singleton s1 = Singleton.GetInstance();
            if (textBox1.Text != "" && textBox2.Text == "admin")
            {
                AdminLogIn();

            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                UserLogIn();
            }
            MainMenu form1 = new MainMenu();
            form1.Show();
            this.Hide();


        }

        private void UserLogIn()
        {
            MessageBox.Show("A-ti fost logat ca utilizator");
        }

        private void AdminLogIn()
        {
            MessageBox.Show("A-ti fost logat ca administrator");
        }

        private void Log_Incs_Load(object sender, EventArgs e)
        {

        }
    }
}
