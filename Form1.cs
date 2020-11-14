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
            string connectionString = string.Format();
            this.connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connection open!");
                Console.WriteLine("running api");
                //connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection" + ex.ToString());
            }
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
            // can be broken by ' .' or 1 = 1; # '
            var cmd = new MySqlCommand(string.Format("UPDATE `student2018113705`.`users` SET `password`=SHA2('{0}:::{1}', 256) WHERE `username`=@username;", tbUsername.Text, tbPassword.Text), this.connection);
            cmd.Parameters.AddWithValue("@username", tbUsername.Text);
            //cmd.Parameters.Add("@username", MySqlDbType.String).Value = tbUsername.Text; //same thing but does error checking on the data type.
            string user = (string)cmd.ExecuteScalar(); //run this and get a single result, casts it to a string
            if (!String.IsNullOrEmpty(user))
            {
                Console.WriteLine("User?" + user);
                stackPanel1.SelectTab("LogoutPage");
                tbPassword.Text = "";
                tbUsername.Text = "";
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
        }

        private async void runApi()
        {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
                        {
                           { "access_id", "" },
                           { "input_file", "http://www.sonicAPI.com/music/brown_eyes_by_ueberschall.mp3" },
                            { "format", "json" }
                        };

            var content = new FormUrlEncodedContent(values);
            Console.WriteLine("working on it");

            var response = await client.PostAsync("https://api.sonicAPI.com/analyze/key", content);

            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine("here it is ... :");
            Console.WriteLine(responseString);
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
