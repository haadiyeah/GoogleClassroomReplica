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
    public partial class Login : Form
    {
        private SqlConnection connection;
        private DBHandler handler = new DBHandler();
        private SqlCommand command;
        private SqlDataReader dataReader;
        

        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(handler.MyConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("SELECT DBlabproject.dbo.studentExists(@email);", connection);
                command.Parameters.AddWithValue("@email", Email.Text);

                var result = command.ExecuteScalar();

                if (result is (object)2 or (object)1)
                {
                   
                    command = new SqlCommand("SELECT personPassword FROM DBlabproject.dbo.person WHERE personEmail=@email;", connection);
                    command.Parameters.AddWithValue("@email", Email.Text);
                    
                    dataReader = command.ExecuteReader();
                    

                    if (dataReader.HasRows)
                    {
                        dataReader.Read();

                        String passwordCheck = dataReader.GetString(0);
                        dataReader.Close();

                        if (passwordCheck != Password.Text)
                        {
                            MessageBox.Show("Invalid password");
                            
                            connection.Close();
                            return;
                        } else
                        {

                            command = new SqlCommand("SELECT * FROM DBlabproject.dbo.person WHERE personEmail=@email;", connection);
                            command.Parameters.AddWithValue("@email", Email.Text);
                            
                            dataReader = command.ExecuteReader();
                            dataReader.Read();
                            String personName = dataReader.GetString(0);
                            String personEmail = dataReader.GetString(1);
                            String personPassword = dataReader.GetString(2);
                            var studentflag = dataReader.GetValue(3);
                            var teacherflag = dataReader.GetValue(4);
                            MessageBox.Show("Student flag is true " + (studentflag is (object)true).ToString());
                            if (studentflag is (object)true && teacherflag is (object)true)
                            {
                                Person.setInstance(personName, personEmail, personPassword, "Student&Teacher");

                            }
                            else if (studentflag is (object)true)
                            {
                                Person.setInstance(personName, personEmail, personPassword, "Student");

                            }
                            else if (teacherflag is (object)true)
                            {
                                Person.setInstance(personName, personEmail, personPassword, "Teacher");

                            }
                            else 
                            {//default
                                MessageBox.Show("default " + teacherflag.ToString());
                                Person.setInstance(personName, personEmail, personPassword, "Student");
                            }
                            MessageBox.Show("Login Successful, Welcome, " + personName);
                            dataReader.Close();
                            connection.Close();
                            this.Hide();
                            Homepage obj = new Homepage();
                            obj.ShowDialog();
                        }
                    }
                    connection.Close();
                    
                } else
                {
                    connection.Close();
                    MessageBox.Show("Sorry! Account doesnt exist!");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup su = new Signup();
            su.Show();
        }
    }
}
