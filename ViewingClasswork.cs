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
    public partial class ViewingClasswork : Form
    {
        private SqlConnection connection;
        private DBHandler handler = new DBHandler();
        private SqlCommand command;
        private SqlDataReader dataReader;
        private int currentPostId;

public ViewingClasswork()
        {
            InitializeComponent();
        }

        public ViewingClasswork(int postID, String type)
        {
            InitializeComponent();
            currentPostId = postID;
            if (type == "Assignment")
            {
                setupAssignment(postID);
            } 
            else if(type=="Material")
            {
                setupMaterial(postID);
            }
        }

        private void setupAssignment(int postid)
        {
            try
            {
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();

                command = new SqlCommand("SELECT postDescription,postDate, person.personName, postType, assignmentTitle, assignmentDeadline, assignmentTotal FROM DBlabproject.dbo.post JOIN DBlabproject.dbo.person ON (person.personEmail=post.personEmail) JOIN DBlabproject.dbo.assignment ON (assignment.postID=post.postID) WHERE post.postID=@pid;", connection);
                command.Parameters.AddWithValue("@pid", postid);
                dataReader = command.ExecuteReader();
                MessageBox.Show("ok");
                while (dataReader.Read())
                {
                    String desc = dataReader.GetString(0);
                    String date = dataReader.GetValue(1).ToString();
                    String postedBy = dataReader.GetString(2);
                    String type = dataReader.GetString(3);
                    String title = dataReader.GetString(4);
                    String duedate = dataReader.GetValue(5).ToString();
                    String total = dataReader.GetValue(6).ToString();
                    dueLabel.Show();
                    ClassworkTotalPoints.Show();
                    setInfo(title, type, duedate, date, postedBy, desc, total);
                    MessageBox.Show("ok6");

                }
                connection.Close();
                dataReader.Close();


                //----------------Adding the public comments
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();

                command = new SqlCommand("SELECT personName, commentText FROM comment JOIN person ON(personEmail=commentPerson) WHERE commentPost=@pid AND commentType='Public';", connection);
                command.Parameters.AddWithValue("@pid", postid);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    String commenterName = dataReader.GetString(0);
                    String commentMade = dataReader.GetString(1);
                    addComment(commenterName, commentMade, false);
                    this.yourWorkPanel.Show();

                }
                connection.Close();
                dataReader.Close();

                //----------------Adding the private comments
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();

                command = new SqlCommand("SELECT personName, commentText FROM comment JOIN person ON(personEmail=commentPerson) WHERE commentPost=@pid AND commentType='Private' AND commentPerson=@currentPerson;", connection);
                command.Parameters.AddWithValue("@pid", postid);
                command.Parameters.AddWithValue("@currentPerson", Person.getInstance().getEmail());
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    String commenterName = dataReader.GetString(0);
                    String commentMade = dataReader.GetString(1);
                    addComment(commenterName, commentMade, true);
                    this.yourWorkPanel.Show();

                }
                connection.Close();
                dataReader.Close();

            } catch(Exception ex)
            {
                MessageBox.Show("Whoops! Looks like this classwork doesnt exist");
            }
        }

        private void setupMaterial(int postid)
        {
            try
            {
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();

                command = new SqlCommand("SELECT postDescription, postDate, person.personName, postType, materialURL FROM DBlabproject.dbo.post JOIN DBlabproject.dbo.person ON (person.personEmail=post.personEmail) JOIN DBlabproject.dbo.material ON (material.postID=post.postID) WHERE post.postID=@pid;", connection);
                command.Parameters.AddWithValue("@pid", postid);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    String desc = dataReader.GetString(0);
                    String date = dataReader.GetValue(1).ToString();
                    String postedBy = dataReader.GetString(2);
                    String type = dataReader.GetString(3);
                    String url = dataReader.GetString(4);
                    setInfo("Material", type,"", date, postedBy, desc, "N/A");
                    this.yourWorkPanel.Hide();
                    this.dueLabel.Hide();
                    this.ClassworkTotalPoints.Hide();

                }
                connection.Close();
                dataReader.Close();

                //----------------Adding the public comments
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();

                command = new SqlCommand("SELECT personName, commentText FROM comment JOIN person ON(personEmail=commentPerson) WHERE commentPost=@pid AND commentType='Public';", connection);
                command.Parameters.AddWithValue("@pid", postid);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    String commenterName = dataReader.GetString(0);
                    String commentMade = dataReader.GetString(1);
                    addComment(commenterName, commentMade, false);
                    this.yourWorkPanel.Hide();

                }
                connection.Close();
                dataReader.Close();

                //----------------Adding the private comments
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();

                command = new SqlCommand("SELECT personName, commentText FROM comment JOIN person ON(personEmail=commentPerson) WHERE commentPost=@pid AND commentType='Private' AND commentPerson=@currentPerson;", connection);
                command.Parameters.AddWithValue("@pid", postid);
                command.Parameters.AddWithValue("@currentPerson", Person.getInstance().getEmail());
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    String commenterName = dataReader.GetString(0);
                    String commentMade = dataReader.GetString(1);
                    addComment(commenterName, commentMade, true);
                    this.yourWorkPanel.Show();

                }
                connection.Close();
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! Looks like this classwork doesnt exist");
                Debug.WriteLine(ex.ToString());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void postprivatecomment_Click(object sender, EventArgs e)
        {
            addComment(Person.getInstance().getName(), PrivateCommentTextBox.Text, true);
            

            try
            {
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();

                command = new SqlCommand("INSERT INTO comment(commentDateTime, commentPerson, commentPost, commentText, commentType) VALUES (@datetime, @commenter, @postID, @commentText, @commentPrivacyType);", connection);
                command.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@commenter", Person.getInstance().getEmail());
                command.Parameters.AddWithValue("@postID", currentPostId);
                command.Parameters.AddWithValue("@commentText", ClassCommentTextBox.Text);
                command.Parameters.AddWithValue("@commentPrivacyType", "Private");

                command.ExecuteNonQuery();

                connection.Close();
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception error occurred");
                Debug.WriteLine(ex);
            }
            PrivateCommentTextBox.Text = "";

        }

        private void postcommentbutton_Click(object sender, EventArgs e)
        {
            addComment(Person.getInstance().getName(), ClassCommentTextBox.Text, false);
            

            try
            {
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();

                command = new SqlCommand("INSERT INTO comment(commentDateTime, commentPerson, commentPost, commentText, commentType) VALUES (@datetime, @commenter, @postID, @commentText, @commentPrivacyType);", connection);
                command.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@commenter", Person.getInstance().getEmail());
                command.Parameters.AddWithValue("@postID", currentPostId);
                command.Parameters.AddWithValue("@commentText", ClassCommentTextBox.Text);
                command.Parameters.AddWithValue("@commentPrivacyType", "Public");

               command.ExecuteNonQuery();
               
                connection.Close();
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception error occurred");
                Debug.WriteLine(ex);
            }
            ClassCommentTextBox.Text = "";

        }

        private void pgroup_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Person.getInstance().getType() == "Student")
            {
                StudentNavigate sn = new StudentNavigate(StudentNavigate.getCurrClassCode());
                sn.ShowDialog();
            }
            else if (Person.getInstance().getType() == "Teacher")
            {
                TeacherNavigate tn = new TeacherNavigate(TeacherNavigate.getCurrClassCode());
                tn.ShowDialog();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClassworkMarkAsDone_Click(object sender, EventArgs e)
        {
            if(assignmentStatusLabel.Text == "Assigned")
            {
                assignmentStatusLabel.Text = "Done";
                assignmentStatusLabel.ForeColor = System.Drawing.Color.Green;

            }
        }
    }
}
