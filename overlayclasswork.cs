using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class overlayclasswork : Form
    {
        public overlayclasswork()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AssignmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            postNewAssignment pna = new postNewAssignment();
            pna.ShowDialog();
        }

        private void Materialbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            postNewMaterial pnm = new postNewMaterial();
            pnm.ShowDialog();
        }
    }
}
