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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            connection = new SqlConnection(handler.MyConnection());
            addAllClassTiles();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       private void classClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                String classCode = btn.Tag.ToString();
                
                if(Person.getInstance().getType() == "Student")
                {
                    this.Hide();
                    StudentNavigate sn = new StudentNavigate(classCode);
                    sn.ShowDialog();
                }
                else if(Person.getInstance().getType() == "Teacher")
                {
                    this.Hide();
                    //Open in teacher view if person logged in is a teacher
                    TeacherNavigate tn = new TeacherNavigate(classCode);
                    tn.ShowDialog();
                } else if (Person.getInstance().getType() == "Student&Teacher")
                {
                    //Check if he is a student for that particular class, or a teacher.
                    //Open the view accordingly.
                }
            }
            else //Person is neither.This button should never be clicked anyway.
            {
                //Check if he is a student for that particular class, or a teacher.
                //Open the view accordingly.
            }
        }
        
    }
}
