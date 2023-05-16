using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class TeacherNavigate : Form
    {
        private SqlConnection connection = new SqlConnection();
        private SqlCommand command;
        private SqlDataReader dataReader;
        private static string currentClassCode;
        private DBHandler handler;

        public static string getCurrClassCode()
        {
            return currentClassCode;
        }

        public TeacherNavigate()
        {
            this.InitializeComponent();
            this.handler = new DBHandler();
            this.connection = new SqlConnection(this.handler.MyConnection());
        }

        public TeacherNavigate(string ccode)
        {
            TeacherNavigate.currentClassCode = ccode;
            this.handler = new DBHandler();
            this.connection = new SqlConnection(this.handler.MyConnection());
            this.InitializeComponent();
            try
            {
                this.connection.Open();
                this.command = new SqlCommand("SELECT * from DBlabproject.dbo.class WHERE classCode=@reqCode;", this.connection);
                this.command.Parameters.AddWithValue("@reqCode", (object)TeacherNavigate.currentClassCode);
                this.dataReader = this.command.ExecuteReader();
                if (this.dataReader.HasRows)
                {
                    this.dataReader.Read();
                    string className = this.dataReader.GetString(1);
                    string classSection = this.dataReader.GetString(3);
                    this.setInfo(className, TeacherNavigate.currentClassCode,classSection, "");
                    this.dataReader.Close();
                    this.connection.Close();
                    this.getAllPosts();
                    this.getAllPeople();
                }
                else
                {
                    this.dataReader.Close();
                    this.connection.Close();
                    int num = (int)MessageBox.Show("An error occurred");
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An exception error occurred");
                Debug.WriteLine((object)ex);
            }
        }

        public void getAllPeople()
        {
            try
            {
                this.connection = new SqlConnection(this.handler.MyConnection());
                this.connection.Open();
                this.command = new SqlCommand("SELECT personName FROM DBlabproject.dbo.person JOIN DBlabproject.dbo.studentEnrollsInClass ON (studentEnrollsInClass.studentEmail=person.personEmail) WHERE studentEnrollsInClass.classCode=@ccode;", this.connection);
                this.command.Parameters.AddWithValue("@ccode", (object)TeacherNavigate.getCurrClassCode());
                this.dataReader = this.command.ExecuteReader();
                while (this.dataReader.Read())
                    this.addPersonToClassPeople("Student", this.dataReader.GetString(0));
                this.connection.Close();
                this.dataReader.Close();

                this.connection = new SqlConnection(this.handler.MyConnection());
                this.connection.Open();
                this.command = new SqlCommand("SELECT personName FROM DBlabproject.dbo.person JOIN DBlabproject.dbo.teacherTeachesClass ON(teacherEmail = person.personEmail) WHERE teacherTeachesClass.classCode = 'DJFS12';", this.connection);
                this.command.Parameters.AddWithValue("@ccode", (object)TeacherNavigate.getCurrClassCode());
                this.dataReader = this.command.ExecuteReader();
                while (this.dataReader.Read())
                    this.addPersonToClassPeople("Teacher", this.dataReader.GetString(0));
                this.connection.Close();
                this.dataReader.Close();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Whoops! Couldnt add people of class");
                Debug.WriteLine(ex.ToString());
            }
        }

        public void getAllPosts()
        {
            try
            {
                this.connection.Open();
                this.command = new SqlCommand("SELECT * FROM DBlabproject.dbo.post where classCode=@cCode", this.connection);
                this.command.Parameters.AddWithValue("@cCode", (object)TeacherNavigate.currentClassCode);
                this.dataReader = this.command.ExecuteReader();
                if (this.dataReader.HasRows)
                {
                    while (this.dataReader.Read())
                    {
                        string type = this.dataReader["postType"].ToString();
                        string str1 = this.dataReader["postDate"].ToString();
                        string str2 = this.dataReader["postTime"].ToString();
                        string str3 = this.dataReader["postDescription"].ToString();
                        string str4 = this.dataReader["personEmail"].ToString();
                        int postID = int.Parse(this.dataReader["postID"].ToString());
                        int num;
                        switch (type)
                        {
                            case "Announcement":
                                this.createAnnouncement(str2, str1, str4, "Teacher", str3, postID);
                                goto label_8;
                            case "Material":
                                num = 1;
                                break;
                            default:
                                num = type == "Assignment" ? 1 : 0;
                                break;
                        }
                        if (num != 0)
                        {
                            this.addNewClassworkToStream(type, str3, str4, postID);
                            this.addClassworkToClassworkTab(type, str3, str1, str2, postID);
                        }
                    label_8:
                        if (type == "Assignment")
                            this.addDeadlineToUpcomingWork(str1, str3, postID);
                    }
                }
                else
                {
                    int num1 = (int)MessageBox.Show("This classroom has no posts");
                }
                this.dataReader.Close();
                this.connection.Close();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("an exception occurred");
            }
        }

        private void PostAnnouncementBtn_Click(object sender, EventArgs e)
        {
            if (Person.getInstance() != null)
                this.createAnnouncement(DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("yyyy'-'MM'-'dd"), Person.getInstance().getName(), Person.getInstance().getType(), this.AddAnnouncementTextBox.Text, 1);
            try
            {
                this.connection = new SqlConnection(this.handler.MyConnection());
                this.connection.Open();
                this.command = new SqlCommand("EXEC DBlabproject.dbo.addPost @time,@date, @announcementText, @currEmail, 'Announcement', @currClassCode;", this.connection);
                this.command.Parameters.AddWithValue("@time", (object)DateTime.Now.ToString("HH:mm:ss"));
                this.command.Parameters.AddWithValue("@date", (object)DateTime.Now.ToString("yyyy-MM-dd"));
                this.command.Parameters.AddWithValue("@announcementText", (object)this.AddAnnouncementTextBox.Text);
                this.command.Parameters.AddWithValue("@currEmail", (object)Person.getInstance().getEmail());
                this.command.Parameters.AddWithValue("@currClassCode", (object)this.classroomCode.Text);
                this.command.ExecuteNonQuery();
                this.connection.Close();
                this.dataReader.Close();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An exception error occurred");
                Debug.WriteLine((object)ex);
            }
            this.AddAnnouncementTextBox.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void AddAnnouncementTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ClassSection_Click(object sender, EventArgs e) => this.addDeadlineToUpcomingWork("Omg", "No", 1);

        private void UpcomingWorkBox_Enter(object sender, EventArgs e)
        {
        }

        private void classworkMaterialClicked(object sender, EventArgs e)
        {
            if (!(sender is Button button))
                return;
            string s = button.Tag.ToString();
            this.Hide();
            int num = (int)new ViewingClasswork(int.Parse(s), "Material").ShowDialog();
        }

        private void classworkAssignmentClicked(object sender, EventArgs e)
        {
            if (!(sender is Button button))
                return;
            string s = button.Tag.ToString();
            this.Hide();
            int num = (int)new ViewingClasswork(int.Parse(s), "Assignment").ShowDialog();
        }

        private void newpostpanel1bgbutton_Click(object sender, EventArgs e)
        {
        }

        private void TeacherNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            this.Hide();
            hp.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            overlayclasswork oc = new overlayclasswork();
            oc.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            addingNewClass anc = new addingNewClass();
            this.Hide();
            anc.ShowDialog();
        }
    }
}
