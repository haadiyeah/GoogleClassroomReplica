using lab10;
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
    public partial class Signup : Form
    {
        private SqlConnection connection;
        private DBHandler handler = new DBHandler();
        private SqlCommand command;
        private SqlDataReader dataReader;
        public Signup()
        {
            InitializeComponent();
            connection = new SqlConnection(handler.MyConnection());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String username = Username.Text;
            String email;
            String password;
            email = Email.Text;
            password = Password.Text;

            if (!this.Email.Text.EndsWith("@gmail.com") && !this.Email.Text.EndsWith("@nu.pk"))
            {
                MessageBox.Show("email must be valid!");
                Email.Clear();
                this.Email.Focus();

            }

            string check_Special = "\"" + "&*()@%!^~`+=-?/>.<,:;'\'|}]@#$%{[_";
            char[] Aray = check_Special.ToCharArray();
            bool flag = false;
            foreach (char ccharacter in Aray)
            {
                if (Password.Text.Contains(ccharacter))
                {
                    flag = true;
                }
            }

            if (password.Length < 6 || password.Length > 15)
            {
                MessageBox.Show("Password must be between 6 and 15 characters");
                Password.Clear();
            }
            else if (!Password.Text.Any(char.IsUpper))
            {
                MessageBox.Show("Password must have atleast one capital letter");
                Password.Clear();
            }
            else if (flag == false)
            {
                MessageBox.Show("Password must have atleast one special character");
                Password.Clear();
            }
            else
            {

                try
                {
                    connection.Open();
                    command = new SqlCommand("SELECT DBlabproject.dbo.studentExists(@email);", connection);
                    command.Parameters.AddWithValue("@email", Email.Text);
                    
                   
                     var result = command.ExecuteScalar();
                    
                    connection.Close();
                    if ( result is (object)2 or (object)1)
                    {
                        MessageBox.Show("Sorry! Duplicate account!");
                    }
                    else {
                        connection.Open();
                        command = new SqlCommand("EXEC DBlabproject.dbo.createNewStudent @name, @email, @password, 1; ", connection);
                        command.Parameters.AddWithValue("@name", Username.Text);
                        command.Parameters.AddWithValue("@email", Email.Text);
                        command.Parameters.AddWithValue("@password", Password.Text);


                        command.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception thrown");
                }

               


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login li = new Login();
            li.Show();
        }
    }
}
