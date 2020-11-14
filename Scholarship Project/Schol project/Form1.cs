using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;


namespace Schol_project
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = string.Format("Server=nimbus.rangitoto.school.nz;" +
               "Port=3307;" +
               "database={0};" +
               "UID=2018110375;" +
               "password=110375;" +
               "SslMode = none", "student2018110375");
            this.connection = new MySqlConnection(connectionString);
            try
            {
                this.connection.Open();
                MessageBox.Show("Connection open!");
                //connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection" + ex.ToString());
            }
            Stackpanel.SelectTab("Login_Page");
        }

        void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is the teacher's login thingy.
            // can be broken by ' .' or 1 = 1; # '
            var cmd = new MySqlCommand(string.Format("SELECT teachers_name, password FROM teachers WHERE teachers_name =@username AND password =@password;"), this.connection);
            cmd.Parameters.AddWithValue("@username", tbUsername.Text);
            cmd.Parameters.AddWithValue("@password", tbPassword.Text);
            //cmd.Parameters.Add("@username", MySqlDbType.String).Value = tbUsername.Text; //same thing but does error checking on the data type.
            string user = (string)cmd.ExecuteScalar(); //run this and get a single result, casts it to a string
            if (!String.IsNullOrEmpty(user))
            {
                Console.WriteLine("User?" + user);
                Stackpanel.SelectTab("TeacherView");
                tbPassword.Text = "";
                tbUsername.Text = "";
            }
            else
            {
                MessageBox.Show("WRONG. I'LL BE BACK. I'M A COP YOU IDIOT. COME ON DO IT KILL ME! PUT THAT COOKIE DOWN!");
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stackpanel.SelectTab("MusicView");
        }

        private void ViewMusic_Click(object sender, EventArgs e)
        {
            Stackpanel.SelectTab("MusicView");
        }

        private void Transcribe1_Click(object sender, EventArgs e)
        {
            runApi();
        }
        private async void runApi()
        {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
                        {
                           { "access_id", "751e9899-eb0e-4bf4-80d6-eef614256a21" },
                           { "input_file", "http://www.sonicAPI.com/music/brown_eyes_by_ueberschall.mp3" },
                            { "format", "json" }
                        };

            var content = new FormUrlEncodedContent(values);
            Console.WriteLine("working on it");

            var response = await client.PostAsync("https://api.sonicAPI.com/analyze/melody", content);

            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine("here it is ... :");
            Console.WriteLine(responseString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillListView(MySqlConnection connection)
        {

        }

        private void LoginPage_Click(object sender, EventArgs e)
        {

        }

        private void teacher_button_Click(object sender, EventArgs e)
        {
            Stackpanel.SelectTab("teacher_Login");
        }

        private void student_button_Click(object sender, EventArgs e)
        {
            Stackpanel.SelectTab("student_login");
        }

        private void AssessedTask_Click(object sender, EventArgs e)
        {
            runApi();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // this is the student login
            // can be broken by ' .' or 1 = 1; # '
            var cmd = new MySqlCommand(string.Format("SELECT students name, student password FROM students WHERE students name =@username AND student password =@password;"), this.connection);
            cmd.Parameters.AddWithValue("@username", tbusername_student.Text);
            cmd.Parameters.AddWithValue("@password", tbpassword_student.Text);
            //cmd.Parameters.Add("@username", MySqlDbType.String).Value = tbUsername.Text; //same thing but does error checking on the data type.
            string user = (string)cmd.ExecuteScalar(); //run this and get a single result, casts it to a string
            if (!String.IsNullOrEmpty(user))
            {
                Console.WriteLine("User?" + user);
                Stackpanel.SelectTab("StudentView");
                tbpassword_student.Text = "";
                tbusername_student.Text = "";
            }
            else
            {
                MessageBox.Show("WRONG. I'LL BE BACK. I'M A COP YOU IDIOT. COME ON DO IT KILL ME! PUT THAT COOKIE DOWN!");
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
