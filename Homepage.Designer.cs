using System.Data.SqlClient;
using System.Diagnostics;

namespace lab10
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private LinkedList<String> classCodes = new LinkedList<String>();
        private static int tracker = 0;
        private SqlConnection connection;
        private DBHandler handler = new DBHandler();
        private SqlCommand command;
        private SqlDataReader dataReader;
        


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void addClassTile(String classCode, String classname, String teacherName, String section)
        {
            classCodes.AddFirst(classCode);

            Panel ClassTilePanel = new System.Windows.Forms.Panel();
            Label ClassTileTeacher = new System.Windows.Forms.Label();
            Label ClassTileTitle = new System.Windows.Forms.Label();
            Label ClassTileSection = new System.Windows.Forms.Label();
            PictureBox ClassTileTeacherImg = new System.Windows.Forms.PictureBox();
            PictureBox ClassTileHeaderImg = new System.Windows.Forms.PictureBox();
            Button ClassTileBgButton = new System.Windows.Forms.Button();


            // ClassTilePanel
            // 
            ClassTilePanel.Controls.Add(ClassTileTeacher);
            ClassTilePanel.Controls.Add(ClassTileTitle);
            ClassTilePanel.Controls.Add(ClassTileSection);
            ClassTilePanel.Controls.Add(ClassTileTeacherImg);
            ClassTilePanel.Controls.Add(ClassTileHeaderImg);
            ClassTilePanel.Controls.Add(ClassTileBgButton);
            ClassTilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            ClassTilePanel.Location = new System.Drawing.Point(2, 2);
            ClassTilePanel.Margin = new System.Windows.Forms.Padding(2);
            ClassTilePanel.Name = "ClassTilePanel" + tracker.ToString();
            ClassTilePanel.Size = new System.Drawing.Size(260, 163);
            ClassTilePanel.TabIndex = 11;
            // 
            ClassTilesContainerPanel.Controls.Add(ClassTilePanel);
            // ClassTileTeacher
            // 
            ClassTileTeacher.AutoSize = true;
            ClassTileTeacher.BackColor = System.Drawing.Color.DarkSlateGray;
            ClassTileTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ClassTileTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ClassTileTeacher.Location = new System.Drawing.Point(15, 75);
            ClassTileTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ClassTileTeacher.Name = "ClassTileTeacher"+tracker.ToString();
            ClassTileTeacher.Size = new System.Drawing.Size(51, 15);
            ClassTileTeacher.TabIndex = 4;
            ClassTileTeacher.Text = classname;
            // 
            // ClassTileTitle
            // 
            ClassTileTitle.AutoSize = true;
            ClassTileTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            ClassTileTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ClassTileTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ClassTileTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            ClassTileTitle.Location = new System.Drawing.Point(17, 17);
            ClassTileTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ClassTileTitle.Name = "ClassTileTitle" + tracker.ToString();
            ClassTileTitle.Size = new System.Drawing.Size(86, 27);
            ClassTileTitle.TabIndex = 2;
            ClassTileTitle.Text = classname;
            ClassTileTitle.UseCompatibleTextRendering = true;
            ClassTileTitle.Visible = false;
            // 
            // ClassTileSection
            // 
            ClassTileSection.AutoSize = true;
            ClassTileSection.BackColor = System.Drawing.Color.DarkSlateGray;
            ClassTileSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ClassTileSection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ClassTileSection.Location = new System.Drawing.Point(15, 53);
            ClassTileSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ClassTileSection.Name = "ClassTileSection" + tracker.ToString();
            ClassTileSection.Size = new System.Drawing.Size(49, 15);
            ClassTileSection.TabIndex = 3;
            ClassTileSection.Text = section;
            // 
            // ClassTileTeacherImg
            // 
            ClassTileTeacherImg.Load("..\\..\\..\\images\\teachericon.png");
            ClassTileTeacherImg.Location = new System.Drawing.Point(188, 67);
            ClassTileTeacherImg.Margin = new System.Windows.Forms.Padding(2);
            ClassTileTeacherImg.Name = "ClassTileTeacherImg" + tracker.ToString();
            ClassTileTeacherImg.Size = new System.Drawing.Size(58, 57);
            ClassTileTeacherImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ClassTileTeacherImg.TabIndex = 6;
            ClassTileTeacherImg.TabStop = false;
            // 
            // ClassTileHeaderIm
            // g
            // 
            ClassTileHeaderImg.Load("..\\..\\..\\images\\header1.jpeg");
            ClassTileHeaderImg.Location = new System.Drawing.Point(2, 2);
            ClassTileHeaderImg.Margin = new System.Windows.Forms.Padding(2);
            ClassTileHeaderImg.Name = "ClassTileHeaderImg" + tracker.ToString();
            ClassTileHeaderImg.Size = new System.Drawing.Size(256, 100);
            ClassTileHeaderImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ClassTileHeaderImg.TabIndex = 8;
            ClassTileHeaderImg.TabStop = false;
            // 
            // ClassTileBgButton
            // 
            ClassTileBgButton.Location = new System.Drawing.Point(2, 2);
            ClassTileBgButton.Margin = new System.Windows.Forms.Padding(2);
            ClassTileBgButton.Name = "ClassTileBgButton" + tracker.ToString();
            ClassTileBgButton.Size = new System.Drawing.Size(258, 159);
            ClassTileBgButton.TabIndex = 1;
            ClassTileBgButton.UseVisualStyleBackColor = true;
           ClassTileBgButton.Click += new System.EventHandler(this.classClicked);
            
            ClassTileBgButton.Tag = classCode;
          
        }

        private void addAllClassTiles()
        {
            

            try
            {
                connection = null;
                connection = new SqlConnection(handler.MyConnection());
                connection.Open();


                if (Person.getInstance().getType() == "Student")
                {
                    command = new SqlCommand("SELECT * FROM DBlabproject.dbo.class WHERE classCode IN (SELECT classCode FROM DBlabproject.dbo.studentEnrollsInClass WHERE studentEnrollsInClass.studentEmail=@reqmail);", connection);
                    command.Parameters.AddWithValue("@reqmail", Person.getInstance().getEmail());
                    dataReader = command.ExecuteReader();

                }
                else if (Person.getInstance().getType() == "Teacher")
                {
                    ////add teaching classes
                    command = new SqlCommand("SELECT* FROM DBlabproject.dbo.class WHERE classCode IN(SELECT classCode FROM DBlabproject.dbo.teacherTeachesClass WHERE teacherTeachesClass.teacherEmail= @reqmail);", connection);
                    command.Parameters.AddWithValue("@reqmail", Person.getInstance().getEmail());
                    dataReader = command.ExecuteReader();

                }
                else if (Person.getInstance().getType() == "Student&Teacher")
                {
                    ////add both teaching and studying classes -special case.
                    command = new SqlCommand("SELECT * FROM DBlabproject.dbo.class WHERE classCode IN (SELECT classCode FROM DBlabproject.dbo.studentEnrollsInClass WHERE studentEnrollsInClass.studentEmail=@reqmail) OR classCode IN (SELECT classCode FROM DBlabproject.dbo.teacherTeachesClass WHERE teacherTeachesClass.teacherEmail=@reqmail);", connection);
                    command.Parameters.AddWithValue("@reqmail", Person.getInstance().getEmail());
                    dataReader = command.ExecuteReader();

                }
                else
                {
                    return;
                }
                    
                if (dataReader.HasRows)
                {
                  
                    while (dataReader.Read())
                    {
                        String classCode = dataReader.GetString(0);
                        String className = dataReader.GetString(1);
                        String classSect = dataReader.GetString(3);
                        addClassTile(classCode, className, "Class", classSect);

                    }
                }
                dataReader.Close();
                connection.Close();
            }
             catch(Exception ex)
            {
                MessageBox.Show("Exception in adding class tiles");
                Debug.WriteLine(ex.ToString());
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel5 = new System.Windows.Forms.Panel();
            this.ClassTilesContainerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ClassTilesContainerPanel);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(802, 449);
            this.panel5.TabIndex = 12;
            // 
            // ClassTilesContainerPanel
            // 
            this.ClassTilesContainerPanel.AutoScroll = true;
            this.ClassTilesContainerPanel.AutoSize = true;
            this.ClassTilesContainerPanel.Location = new System.Drawing.Point(3, 92);
            this.ClassTilesContainerPanel.Name = "ClassTilesContainerPanel";
            this.ClassTilesContainerPanel.Size = new System.Drawing.Size(796, 308);
            this.ClassTilesContainerPanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel1.Size = new System.Drawing.Size(802, 86);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(688, 28);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(19, 39);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(728, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(57, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Google";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = " Classroom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel5;
        private Panel ClassTilePanel;
        private Label ClassTileTeacher;
        private Label ClassTileTitle;
        private Label ClassTileSection;
        private PictureBox ClassTileTeacherImg;
        private PictureBox ClassTileHeaderImg;
        private Button ClassTileBgButton;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label1;
        private Panel ClassTilesContainerPanel;
    }
}