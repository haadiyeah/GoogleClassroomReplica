
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace lab10
{
    public partial class postNewAssignment : Form
    {
        SqlConnection connection=new SqlConnection();
        SqlCommand command=new SqlCommand();
        DBHandler db= new DBHandler();
        SqlDataReader dataReader;
        public postNewAssignment()
        {
            InitializeComponent();
            connection=new SqlConnection(db.MyConnection());
        }

        public postNewAssignment(String code, String topic)
        {
            InitializeComponent();
            connection = new SqlConnection(db.MyConnection());
        }

     

            private void Assignbutton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("EXEC DBlabproject.dbo.addNewAssignment @postTime, @postDate, @postDescription, @personEmail, @postType, @classCode, @assignmentDeadline,@assignmentTotal, @assignmentTitle;", connection);
                command.Parameters.AddWithValue("@postTime", DateTime.Now.TimeOfDay.ToString());
                command.Parameters.AddWithValue("@postDate", DateTime.Now.Date.ToString());
                command.Parameters.AddWithValue("@postDescription", richTextBox1.Text);
                command.Parameters.AddWithValue("@personEmail", Person.getInstance().getEmail());
                command.Parameters.AddWithValue("@postType", "Assignment");
                command.Parameters.AddWithValue("@classCode", TeacherNavigate.getCurrClassCode());               command.Parameters.AddWithValue("@assignmentDeadline",DeadlineBox.Text);
                command.Parameters.AddWithValue("@assignmentTotal", int.Parse(pointBox.Text));
                command.Parameters.AddWithValue("@assignmentTitle", TitleBox.Text);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command = new SqlCommand("SELECT studentEmail FROM DBlabproject.dbo.studentEnrollsInClass WHERE classCode=@code", connection);
                command.Parameters.AddWithValue("@code", TeacherNavigate.getCurrClassCode());
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {
                        SqlCommand newcommand = new SqlCommand("insert into DBlabproject.dbo.assignment_assignedto_student(personEmail,assignmentID, assignmentStatus) VALUES (@email,DBlabproject.dbo.getPostID(), @Assigned)", connection);
                        newcommand.Parameters.AddWithValue("@email", dataReader.GetString(0));
                        newcommand.Parameters.AddWithValue("@Assigned", "Assigned");
                        newcommand.ExecuteNonQuery();
                    }

                }
                dataReader.Close();
                connection.Close();
                MessageBox.Show("The assignment was uploaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                TeacherNavigate tn = new TeacherNavigate(TeacherNavigate.getCurrClassCode());
                tn.ShowDialog();
            }
            catch(Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Filebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Attach File";
            openFileDialog.Filter = "All Files (.)|.";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherNavigate tn = new TeacherNavigate(TeacherNavigate.getCurrClassCode());
            tn.Show();

        }
    }
}
