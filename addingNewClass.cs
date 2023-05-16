
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class addingNewClass : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DBHandler db = new DBHandler();
        SqlDataReader dataReader;
        public addingNewClass()
        {
            InitializeComponent();
            connection = new SqlConnection(db.MyConnection());
        }

        private void createNewClass_Click(object sender, EventArgs e)
        {
           
        }
        private static Random random = new Random();

        public string RandomString(int length)
        {
            bool found = false;
            while (!found)
            {
                const string alphaNumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                String neww = new string(Enumerable.Repeat(alphaNumeric, length).Select(s => s[random.Next(s.Length)]).ToArray());

                connection.Open();
                command = new SqlCommand("SELECT classCode FROM DBlabproject.dbo.class WHERE classCode=@code", connection);
                command.Parameters.AddWithValue("code", neww);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    found = false;
                }
                else
                {
                    connection.Close();
                    found = true;
                    return neww;
                }
                connection.Close();
            }
            return "";

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void createNewClass_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                if (enterClassName.Text == "")
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    String code = RandomString(7);
                    connection.Open();
                    command = new SqlCommand("EXEC DBlabproject.dbo.createNewClass @classCode , @className , @classDescription , @classSection , @classRoom , @classSubject , @ownerEmail ", connection);
                    command.Parameters.AddWithValue("@classCode", code);
                    command.Parameters.AddWithValue("@className", enterClassName.Text);
                    command.Parameters.AddWithValue("@classDescription", classDesc.Text);
                    command.Parameters.AddWithValue("@classRoom", enterRoom.Text);
                    command.Parameters.AddWithValue("@classSubject", enterClassSubject.Text);
                    command.Parameters.AddWithValue("@classSection", section.Text);
                    command.Parameters.AddWithValue("@ownerEmail", Person.getInstance().getEmail());
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Class Created Successfully! Your generated class code is " + code, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                this.Hide();
                Homepage tn = new Homepage();
                tn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
