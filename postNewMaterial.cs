
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class postNewMaterial : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DBHandler db = new DBHandler();
        SqlDataReader dataReader;
        string selectedFilePath="";
        public postNewMaterial()
        {
            InitializeComponent();
            connection = new SqlConnection(db.MyConnection());
        }
        private void Filebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Attach File";
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                MessageBox.Show(fileName + " has been attached successfully!");
            }
            selectedFilePath = openFileDialog.FileName;
        }
        private void Assignbutton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("EXEC DBlabproject.dbo.addNewMaterial @postTime, @postDate,@personEmail, @postType, @classCode,@materialDesc, @materialURL; ", connection);
                command.Parameters.AddWithValue("@postTime", DateTime.Now.TimeOfDay.ToString());
                command.Parameters.AddWithValue("@postDate", DateTime.Now.Date.ToString());
                command.Parameters.AddWithValue("@materialDesc", instruction.Text);
                command.Parameters.AddWithValue("@personEmail", Person.getInstance().getEmail());
                command.Parameters.AddWithValue("@postType", "Material");
                command.Parameters.AddWithValue("@classCode", TeacherNavigate.getCurrClassCode());
                command.Parameters.AddWithValue("@materialURL", selectedFilePath);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The material was uploaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                TeacherNavigate tn = new TeacherNavigate(TeacherNavigate.getCurrClassCode());
                tn.ShowDialog();
            }
            catch (Exception ex) {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherNavigate tn = new TeacherNavigate(TeacherNavigate.getCurrClassCode());
            tn.Show();
        }
    }
}
