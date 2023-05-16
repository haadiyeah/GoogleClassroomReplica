
using System.ComponentModel;

namespace lab10
{
    partial class StudentNavigate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void addNewClassworkToStream(

#nullable disable
       string type,
       string assingmentTitle,
       string teacherName,
       int postID)
        {
            Panel panel = new System.Windows.Forms.Panel();
            this.streamPanels.AddFirst(panel);
            this.streamPanelIDs.AddFirst(postID);
            Button button = new System.Windows.Forms.Button();
            Label label = new System.Windows.Forms.Label();
            PictureBox pictureBox = new System.Windows.Forms.PictureBox();
            this.StreamBox.Controls.Add((Control)panel);
            panel.Controls.Add(label);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(button);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(3, 19);
            panel.Name = "newpostpanel" + StudentNavigate.tracker.ToString();
            panel.Size = new System.Drawing.Size(598, 80);
            panel.TabIndex = 3;
            label.AutoSize = true;
            label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label.Font = new System.Drawing.Font("Segoe UI", 11.25f,System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(71, 28);
            label.Name = "newpostpanelHeading" + StudentNavigate.tracker.ToString();
            label.Size = new System.Drawing.Size(305, 20);
            label.TabIndex = 2;
            label.Text = teacherName + " posted a new " + type + ": " + assingmentTitle;
            pictureBox.Location = new System.Drawing.Point(20, 15);
            pictureBox.Name = "newpostpanelicon" + StudentNavigate.tracker.ToString();
            pictureBox.Size = new System.Drawing.Size(45, 45);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Location = new System.Drawing.Point(3, 3);
            button.Name = "newpostpanelbgbutton" + StudentNavigate.tracker.ToString();
            button.Size = new System.Drawing.Size(592, 72);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = false;
            button.Tag = (object)postID.ToString();
            switch (type)
            {
                case "Assignment":
                    button.Click += new EventHandler(this.classworkAssignmentClicked);
                    pictureBox.Load("..\\..\\..\\images\\assignmenticon.png");
                    break;
                case "Material":
                    button.Click += new EventHandler(this.classworkMaterialClicked);
                    pictureBox.Load("..\\..\\..\\images\\materialicon.png");
                    break;
                case "Question":
                    this.ClassworkIcon.Load("..\\..\\..\\images\\questionicon.png");
                    break;
            }
            ++StudentNavigate.tracker;
        }

        public void createAnnouncement(
          string time,
          string date,
          string announcername,
          string announcerType,
          string announcement,
          int postID)
        {
            Button button = new System.Windows.Forms.Button();
            Panel panel = new System.Windows.Forms.Panel();
            this.streamPanels.AddFirst(panel);
            this.streamPanelIDs.AddFirst(postID);
            Label label1 = new System.Windows.Forms.Label();
            PictureBox pictureBox = new System.Windows.Forms.PictureBox();
            Label label2 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            this.StreamBox.Controls.Add((Control)panel);
            panel.Controls.Add((Control)label3);
            panel.Controls.Add((Control)label2);
            panel.Controls.Add((Control)label1);
            panel.Controls.Add((Control)pictureBox);
            panel.Controls.Add((Control)button);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(3, 178);
            panel.Name = "AnnouncementPanel" + StudentNavigate.tracker.ToString();
            panel.Size = new System.Drawing.Size(598, 113);
            panel.TabIndex = 7;
            button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Location = new System.Drawing.Point(3, 3);
            button.Name = "AnnouncementPanelBGButton" + StudentNavigate.tracker.ToString();
            button.Size = new System.Drawing.Size(592, 107);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = false;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25f,System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(58, 15);
            label1.Name = "AnnouncementPanelPersonName" + StudentNavigate.tracker.ToString();
            label1.Size = new System.Drawing.Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = announcername;
            switch (announcerType)
            {
                case "Teacher":
                    pictureBox.Load("..\\..\\..\\images\\teachericon.png");
                    break;
                case "Student":
                    pictureBox.Load("..\\..\\..\\images\\studenticon.png");
                    break;
            }
            pictureBox.Location = new System.Drawing.Point(20, 16);
            pictureBox.Name = "AnnouncementPanelPersonIcon" + StudentNavigate.tracker.ToString();
            pictureBox.Size = new System.Drawing.Size(32, 32);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Font = new System.Drawing.Font("Segoe UI Light", 8.25f,System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(58, 35);
            label2.Name = "AnnouncementPanelDate" + StudentNavigate.tracker.ToString();
            label2.Size = new System.Drawing.Size(111, 13);
            label2.TabIndex = 3;
            label2.Text = date + time;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75f,System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(20, 64);
            label3.Name = "AnnouncementPanelText" + StudentNavigate.tracker.ToString();
            label3.Size = new System.Drawing.Size(481, 17);
            label3.TabIndex = 4;
            label3.Text = announcement;
            ++StudentNavigate.tracker;
        }

        public void addDeadlineToUpcomingWork(string duedate, string assignmentName, int postID)
        {
            Panel panel = new System.Windows.Forms.Panel();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            if (postID >= 0)
                this.upcomingWorkPanelIDs.AddFirst(postID);
            panel.Controls.Add((Control)this.UpcomingWorkPanel1Heading);
            panel.Controls.Add((Control)this.UpcomingWorkPanel1Subheading);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(3, 19);
            panel.Name = "UpcomingWorkPanel" + StudentNavigate.tracker.ToString();
            panel.Size = new System.Drawing.Size(193, 41);
            panel.TabIndex = 2;
            this.UpcomingWorkBox.Controls.Add((Control)this.UpcomingWorkPanel);
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9f,System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 6);
            label1.Name = "UpcomingWorkPanelHeading" + StudentNavigate.tracker.ToString();
            label1.Size = new System.Drawing.Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = assignmentName;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9f,System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 21);
            label2.Name = "UpcomingWorkPanelSubheading" + StudentNavigate.tracker.ToString();
            label2.Size = new System.Drawing.Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Due " + duedate;
            ++StudentNavigate.tracker;
        }

        public void setInfo(
          string className,
          string classCode,
          string section,
          string classTeacher,
          string headerimageurl = "..\\..\\..\\images\\header1.jpeg")
        {
            this.ClassSection.Text = section;
            this.ClassHeaderText.Text = className;
            this.headerImage.Load(headerimageurl);
            this.classroomCode.Text = classCode;
            this.TeacherNameLabel.Text = classTeacher;
            this.addPersonToClassPeople("Teacher", classTeacher);
        }

        public void addClassworkToClassworkTab(
          string type,
          string classworkTitle,
          string duedate,
          string duetime,
          int postID)
        {
            Panel panel = new System.Windows.Forms.Panel();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label4 = new System.Windows.Forms.Label();
            PictureBox pictureBox = new System.Windows.Forms.PictureBox();
            Button button = new System.Windows.Forms.Button();
            panel.Controls.Add((Control)this.DUElabel);
            panel.Controls.Add((Control)label1);
            panel.Controls.Add((Control)label4);
            panel.Controls.Add((Control)label2);
            panel.Controls.Add((Control)label3);
            panel.Controls.Add((Control)pictureBox);
            panel.Controls.Add((Control)button);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(2, 24);
            panel.Name = "ClassworkPanel" + StudentNavigate.tracker.ToString();
            panel.Size = new System.Drawing.Size(672, 50);
            panel.TabIndex = 6;
            this.ClassworkGroupBox.Controls.Add((Control)panel);
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9f,System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(515, 17);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "DUElabel" + StudentNavigate.tracker.ToString();
            label4.Size = new System.Drawing.Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Due: ";
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9f,System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(599, 17);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "ClassworkDueTime" + StudentNavigate.tracker.ToString();
            label1.Size = new System.Drawing.Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = duetime;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9f,System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(555, 17);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "ClassworkDueDate" + StudentNavigate.tracker.ToString();
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = duedate;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Font = new System.Drawing.Font("Segoe UI", 11f,System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(65, 13);
            label3.Name = "ClassworkName" + StudentNavigate.tracker.ToString();
            label3.Size = new System.Drawing.Size(40, 20);
            label3.TabIndex = 2;
            label3.Text = classworkTitle;
            pictureBox.Location = new System.Drawing.Point(27, 9);
            pictureBox.Name = "ClassworkIcon" + StudentNavigate.tracker.ToString();
            pictureBox.Size = new System.Drawing.Size(32, 29);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button.Dock = System.Windows.Forms.DockStyle.Top;
            button.Location = new System.Drawing.Point(0, 0);
            button.Name = "ClassworkBgButton" + StudentNavigate.tracker.ToString();
            button.Size = new System.Drawing.Size(672, 50);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = false;
            button.Tag = (object)postID.ToString();
            switch (type)
            {
                case "Assignment":
                    button.Click += new EventHandler(this.classworkAssignmentClicked);
                    pictureBox.Load("..\\..\\..\\images\\assignmenticon.png");
                    break;
                case "Material":
                    button.Click += new EventHandler(this.classworkMaterialClicked);
                    pictureBox.Load("..\\..\\..\\images\\materialicon.png");
                    break;
            }
            ++StudentNavigate.tracker;
        }

        public void addPersonToClassPeople(string type, string personName)
        {
            Panel panel = new System.Windows.Forms.Panel();
            Label label = new System.Windows.Forms.Label();
            PictureBox pictureBox = new System.Windows.Forms.PictureBox();
            switch (type)
            {
                case "Student":
                    this.StudentsBox.Controls.Add((Control)panel);
                    break;
                case "Teacher":
                    this.TeachersBox.Controls.Add((Control)panel);
                    break;
            }
            panel.Controls.Add((Control)label);
            panel.Controls.Add((Control)pictureBox);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(2, 34);
            panel.Name = "PersonPanel" + StudentNavigate.tracker.ToString();
            panel.Size = new System.Drawing.Size(874, 51);
            panel.TabIndex = 19;
            label.AutoSize = true;
            label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label.Font = new System.Drawing.Font("Segoe UI", 11f,System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label.Location = new System.Drawing.Point(57, 18);
            label.Name = "PersonName" + StudentNavigate.tracker.ToString();
            label.Size = new System.Drawing.Size(107, 20);
            label.TabIndex = 2;
            label.Text = personName;
            switch (type)
            {
                case "Student":
                    pictureBox.Load("..\\..\\..\\images\\studenticon.png");
                    break;
                case "Teacher":
                    pictureBox.Load("..\\..\\..\\images\\teachericon.png");
                    break;
            }
            pictureBox.Location = new System.Drawing.Point(23, 9);
            pictureBox.Name = "PersonIcon" + StudentNavigate.tracker.ToString();
            pictureBox.Size = new System.Drawing.Size(29, 29);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentNavigate));
            this.AddAnnouncementTextBox = new System.Windows.Forms.TextBox();
            this.AnnouncementPanel = new System.Windows.Forms.Panel();
            this.AnnouncementPanelText = new System.Windows.Forms.Label();
            this.AnnouncementPanelDate = new System.Windows.Forms.Label();
            this.AnnouncementPanelPersonName = new System.Windows.Forms.Label();
            this.AnnouncementPanelPersonIcon = new System.Windows.Forms.PictureBox();
            this.AnnouncementPanelBGButton = new System.Windows.Forms.Button();
            this.newpostpanel2 = new System.Windows.Forms.Panel();
            this.newpostpanel2date = new System.Windows.Forms.Label();
            this.newPostPanel2Heading = new System.Windows.Forms.Label();
            this.newpostpanel2icon = new System.Windows.Forms.PictureBox();
            this.newpostpanel2bgbutton = new System.Windows.Forms.Button();
            this.NewPostPanel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.newpostpanel1Heading = new System.Windows.Forms.Label();
            this.newpostpanel1icon = new System.Windows.Forms.PictureBox();
            this.newpostpanel1bgbutton = new System.Windows.Forms.Button();
            this.StreamBox = new System.Windows.Forms.GroupBox();
            this.UpcomingWorkBox = new System.Windows.Forms.GroupBox();
            this.UpcomingWorkPanel = new System.Windows.Forms.Panel();
            this.UpcomingWorkPanel1Heading = new System.Windows.Forms.Label();
            this.UpcomingWorkPanel1Subheading = new System.Windows.Forms.Label();
            this.ClassSection = new System.Windows.Forms.Label();
            this.ClassHeaderText = new System.Windows.Forms.Label();
            this.headerImage = new System.Windows.Forms.PictureBox();
            this.StudentsBox = new System.Windows.Forms.GroupBox();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentIcon = new System.Windows.Forms.PictureBox();
            this.PostAnnouncementBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ProfileIcon = new System.Windows.Forms.PictureBox();
            this.ClassName = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.StreamTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClassroomCodeBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classroomCode = new System.Windows.Forms.Label();
            this.AddAnnouncementPanel = new System.Windows.Forms.Panel();
            this.ClassworkTab = new System.Windows.Forms.TabPage();
            this.ClassworkGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassworkPanel = new System.Windows.Forms.Panel();
            this.DUElabel = new System.Windows.Forms.Label();
            this.ClassworkDueTime = new System.Windows.Forms.Label();
            this.ClassworkDueDate = new System.Windows.Forms.Label();
            this.ClassworkName = new System.Windows.Forms.Label();
            this.ClassworkIcon = new System.Windows.Forms.PictureBox();
            this.ClassworkBgButton = new System.Windows.Forms.Button();
            this.PeopleTab = new System.Windows.Forms.TabPage();
            this.TeachersBox = new System.Windows.Forms.GroupBox();
            this.TeacherPanel = new System.Windows.Forms.Panel();
            this.TeacherNameLabel = new System.Windows.Forms.Label();
            this.TeacherIcon = new System.Windows.Forms.PictureBox();
            this.AnnouncementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnnouncementPanelPersonIcon)).BeginInit();
            this.newpostpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newpostpanel2icon)).BeginInit();
            this.NewPostPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newpostpanel1icon)).BeginInit();
            this.StreamBox.SuspendLayout();
            this.UpcomingWorkBox.SuspendLayout();
            this.UpcomingWorkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            this.StudentsBox.SuspendLayout();
            this.StudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).BeginInit();
            this.Tabs.SuspendLayout();
            this.StreamTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ClassroomCodeBox.SuspendLayout();
            this.AddAnnouncementPanel.SuspendLayout();
            this.ClassworkTab.SuspendLayout();
            this.ClassworkGroupBox.SuspendLayout();
            this.ClassworkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassworkIcon)).BeginInit();
            this.PeopleTab.SuspendLayout();
            this.TeachersBox.SuspendLayout();
            this.TeacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAnnouncementTextBox
            // 
            this.AddAnnouncementTextBox.Location = new System.Drawing.Point(3, 3);
            this.AddAnnouncementTextBox.Multiline = true;
            this.AddAnnouncementTextBox.Name = "AddAnnouncementTextBox";
            this.AddAnnouncementTextBox.PlaceholderText = "Announce something to your class";
            this.AddAnnouncementTextBox.Size = new System.Drawing.Size(595, 57);
            this.AddAnnouncementTextBox.TabIndex = 2;
            this.AddAnnouncementTextBox.TextChanged += new System.EventHandler(this.AddAnnouncementTextBox_TextChanged);
            // 
            // AnnouncementPanel
            // 
            this.AnnouncementPanel.Controls.Add(this.AnnouncementPanelText);
            this.AnnouncementPanel.Controls.Add(this.AnnouncementPanelDate);
            this.AnnouncementPanel.Controls.Add(this.AnnouncementPanelPersonName);
            this.AnnouncementPanel.Controls.Add(this.AnnouncementPanelPersonIcon);
            this.AnnouncementPanel.Controls.Add(this.AnnouncementPanelBGButton);
            this.AnnouncementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnnouncementPanel.Location = new System.Drawing.Point(3, 178);
            this.AnnouncementPanel.Name = "AnnouncementPanel";
            this.AnnouncementPanel.Size = new System.Drawing.Size(598, 113);
            this.AnnouncementPanel.TabIndex = 8;
            // 
            // AnnouncementPanelText
            // 
            this.AnnouncementPanelText.AutoSize = true;
            this.AnnouncementPanelText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnouncementPanelText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnnouncementPanelText.Location = new System.Drawing.Point(20, 64);
            this.AnnouncementPanelText.Name = "AnnouncementPanelText";
            this.AnnouncementPanelText.Size = new System.Drawing.Size(481, 17);
            this.AnnouncementPanelText.TabIndex = 4;
            this.AnnouncementPanelText.Text = "Dear students, please note there will be no class today as I was literally just b" +
    "orn.";
            // 
            // AnnouncementPanelDate
            // 
            this.AnnouncementPanelDate.AutoSize = true;
            this.AnnouncementPanelDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnouncementPanelDate.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnnouncementPanelDate.Location = new System.Drawing.Point(58, 35);
            this.AnnouncementPanelDate.Name = "AnnouncementPanelDate";
            this.AnnouncementPanelDate.Size = new System.Drawing.Size(111, 13);
            this.AnnouncementPanelDate.TabIndex = 3;
            this.AnnouncementPanelDate.Text = "10:01 AM, 10 July, 2002";
            // 
            // AnnouncementPanelPersonName
            // 
            this.AnnouncementPanelPersonName.AutoSize = true;
            this.AnnouncementPanelPersonName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnouncementPanelPersonName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnnouncementPanelPersonName.Location = new System.Drawing.Point(58, 15);
            this.AnnouncementPanelPersonName.Name = "AnnouncementPanelPersonName";
            this.AnnouncementPanelPersonName.Size = new System.Drawing.Size(102, 20);
            this.AnnouncementPanelPersonName.TabIndex = 2;
            this.AnnouncementPanelPersonName.Text = "Haadiya Sajid";
            // 
            // AnnouncementPanelPersonIcon
            // 
            this.AnnouncementPanelPersonIcon.Location = new System.Drawing.Point(20, 16);
            this.AnnouncementPanelPersonIcon.Name = "AnnouncementPanelPersonIcon";
            this.AnnouncementPanelPersonIcon.Size = new System.Drawing.Size(32, 32);
            this.AnnouncementPanelPersonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnnouncementPanelPersonIcon.TabIndex = 1;
            this.AnnouncementPanelPersonIcon.TabStop = false;
            // 
            // AnnouncementPanelBGButton
            // 
            this.AnnouncementPanelBGButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnouncementPanelBGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnouncementPanelBGButton.Location = new System.Drawing.Point(3, 3);
            this.AnnouncementPanelBGButton.Name = "AnnouncementPanelBGButton";
            this.AnnouncementPanelBGButton.Size = new System.Drawing.Size(592, 107);
            this.AnnouncementPanelBGButton.TabIndex = 0;
            this.AnnouncementPanelBGButton.UseVisualStyleBackColor = false;
            // 
            // newpostpanel2
            // 
            this.newpostpanel2.Controls.Add(this.newpostpanel2date);
            this.newpostpanel2.Controls.Add(this.newPostPanel2Heading);
            this.newpostpanel2.Controls.Add(this.newpostpanel2icon);
            this.newpostpanel2.Controls.Add(this.newpostpanel2bgbutton);
            this.newpostpanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.newpostpanel2.Location = new System.Drawing.Point(3, 99);
            this.newpostpanel2.Name = "newpostpanel2";
            this.newpostpanel2.Size = new System.Drawing.Size(598, 79);
            this.newpostpanel2.TabIndex = 4;
            // 
            // newpostpanel2date
            // 
            this.newpostpanel2date.AutoSize = true;
            this.newpostpanel2date.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newpostpanel2date.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newpostpanel2date.Location = new System.Drawing.Point(466, 35);
            this.newpostpanel2date.Name = "newpostpanel2date";
            this.newpostpanel2date.Size = new System.Drawing.Size(111, 13);
            this.newpostpanel2date.TabIndex = 5;
            this.newpostpanel2date.Text = "10:01 AM, 10 July, 2002";
            // 
            // newPostPanel2Heading
            // 
            this.newPostPanel2Heading.AutoSize = true;
            this.newPostPanel2Heading.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newPostPanel2Heading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPostPanel2Heading.Location = new System.Drawing.Point(71, 28);
            this.newPostPanel2Heading.Name = "newPostPanel2Heading";
            this.newPostPanel2Heading.Size = new System.Drawing.Size(340, 20);
            this.newPostPanel2Heading.TabIndex = 2;
            this.newPostPanel2Heading.Text = "Haadiya posted a new assignment: Assignment#1.";
            // 
            // newpostpanel2icon
            // 
            this.newpostpanel2icon.Image = ((System.Drawing.Image)(resources.GetObject("newpostpanel2icon.Image")));
            this.newpostpanel2icon.Location = new System.Drawing.Point(20, 15);
            this.newpostpanel2icon.Name = "newpostpanel2icon";
            this.newpostpanel2icon.Size = new System.Drawing.Size(45, 45);
            this.newpostpanel2icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newpostpanel2icon.TabIndex = 1;
            this.newpostpanel2icon.TabStop = false;
            // 
            // newpostpanel2bgbutton
            // 
            this.newpostpanel2bgbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newpostpanel2bgbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newpostpanel2bgbutton.Location = new System.Drawing.Point(3, 3);
            this.newpostpanel2bgbutton.Name = "newpostpanel2bgbutton";
            this.newpostpanel2bgbutton.Size = new System.Drawing.Size(592, 72);
            this.newpostpanel2bgbutton.TabIndex = 0;
            this.newpostpanel2bgbutton.UseVisualStyleBackColor = false;
            // 
            // NewPostPanel1
            // 
            this.NewPostPanel1.Controls.Add(this.label2);
            this.NewPostPanel1.Controls.Add(this.newpostpanel1Heading);
            this.NewPostPanel1.Controls.Add(this.newpostpanel1icon);
            this.NewPostPanel1.Controls.Add(this.newpostpanel1bgbutton);
            this.NewPostPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewPostPanel1.Location = new System.Drawing.Point(3, 19);
            this.NewPostPanel1.Name = "NewPostPanel1";
            this.NewPostPanel1.Size = new System.Drawing.Size(598, 80);
            this.NewPostPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(466, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "10:01 AM, 10 July, 2002";
            // 
            // newpostpanel1Heading
            // 
            this.newpostpanel1Heading.AutoSize = true;
            this.newpostpanel1Heading.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newpostpanel1Heading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newpostpanel1Heading.Location = new System.Drawing.Point(71, 28);
            this.newpostpanel1Heading.Name = "newpostpanel1Heading";
            this.newpostpanel1Heading.Size = new System.Drawing.Size(305, 20);
            this.newpostpanel1Heading.TabIndex = 2;
            this.newpostpanel1Heading.Text = "Haadiya posted a new material: list of losers.";
            // 
            // newpostpanel1icon
            // 
            this.newpostpanel1icon.Image = ((System.Drawing.Image)(resources.GetObject("newpostpanel1icon.Image")));
            this.newpostpanel1icon.Location = new System.Drawing.Point(20, 15);
            this.newpostpanel1icon.Name = "newpostpanel1icon";
            this.newpostpanel1icon.Size = new System.Drawing.Size(45, 45);
            this.newpostpanel1icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newpostpanel1icon.TabIndex = 1;
            this.newpostpanel1icon.TabStop = false;
            // 
            // newpostpanel1bgbutton
            // 
            this.newpostpanel1bgbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newpostpanel1bgbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newpostpanel1bgbutton.Location = new System.Drawing.Point(3, 3);
            this.newpostpanel1bgbutton.Name = "newpostpanel1bgbutton";
            this.newpostpanel1bgbutton.Size = new System.Drawing.Size(592, 72);
            this.newpostpanel1bgbutton.TabIndex = 0;
            this.newpostpanel1bgbutton.UseVisualStyleBackColor = false;
            this.newpostpanel1bgbutton.Click += new System.EventHandler(this.newpostpanel1bgbutton_Click);
            // 
            // StreamBox
            // 
            this.StreamBox.AutoSize = true;
            this.StreamBox.Controls.Add(this.AnnouncementPanel);
            this.StreamBox.Controls.Add(this.newpostpanel2);
            this.StreamBox.Controls.Add(this.NewPostPanel1);
            this.StreamBox.Location = new System.Drawing.Point(246, 315);
            this.StreamBox.Name = "StreamBox";
            this.StreamBox.Size = new System.Drawing.Size(604, 310);
            this.StreamBox.TabIndex = 4;
            this.StreamBox.TabStop = false;
            this.StreamBox.Text = "Stream";
            // 
            // UpcomingWorkBox
            // 
            this.UpcomingWorkBox.AutoSize = true;
            this.UpcomingWorkBox.Controls.Add(this.UpcomingWorkPanel);
            this.UpcomingWorkBox.Location = new System.Drawing.Point(22, 334);
            this.UpcomingWorkBox.Name = "UpcomingWorkBox";
            this.UpcomingWorkBox.Size = new System.Drawing.Size(196, 82);
            this.UpcomingWorkBox.TabIndex = 3;
            this.UpcomingWorkBox.TabStop = false;
            this.UpcomingWorkBox.Text = "Upcoming work";
            this.UpcomingWorkBox.Enter += new System.EventHandler(this.UpcomingWorkBox_Enter);
            // 
            // UpcomingWorkPanel
            // 
            this.UpcomingWorkPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpcomingWorkPanel.Controls.Add(this.UpcomingWorkPanel1Heading);
            this.UpcomingWorkPanel.Controls.Add(this.UpcomingWorkPanel1Subheading);
            this.UpcomingWorkPanel.Location = new System.Drawing.Point(2, 19);
            this.UpcomingWorkPanel.Name = "UpcomingWorkPanel";
            this.UpcomingWorkPanel.Size = new System.Drawing.Size(190, 41);
            this.UpcomingWorkPanel.TabIndex = 2;
            // 
            // UpcomingWorkPanel1Heading
            // 
            this.UpcomingWorkPanel1Heading.AutoSize = true;
            this.UpcomingWorkPanel1Heading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpcomingWorkPanel1Heading.Location = new System.Drawing.Point(12, 6);
            this.UpcomingWorkPanel1Heading.Name = "UpcomingWorkPanel1Heading";
            this.UpcomingWorkPanel1Heading.Size = new System.Drawing.Size(82, 15);
            this.UpcomingWorkPanel1Heading.TabIndex = 0;
            this.UpcomingWorkPanel1Heading.Text = "Assignment 1";
            // 
            // UpcomingWorkPanel1Subheading
            // 
            this.UpcomingWorkPanel1Subheading.AutoSize = true;
            this.UpcomingWorkPanel1Subheading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpcomingWorkPanel1Subheading.Location = new System.Drawing.Point(12, 21);
            this.UpcomingWorkPanel1Subheading.Name = "UpcomingWorkPanel1Subheading";
            this.UpcomingWorkPanel1Subheading.Size = new System.Drawing.Size(76, 15);
            this.UpcomingWorkPanel1Subheading.TabIndex = 1;
            this.UpcomingWorkPanel1Subheading.Text = "Due 11:59pm";
            // 
            // ClassSection
            // 
            this.ClassSection.AutoSize = true;
            this.ClassSection.BackColor = System.Drawing.Color.Purple;
            this.ClassSection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClassSection.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassSection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassSection.Location = new System.Drawing.Point(22, 143);
            this.ClassSection.Name = "ClassSection";
            this.ClassSection.Size = new System.Drawing.Size(106, 27);
            this.ClassSection.TabIndex = 2;
            this.ClassSection.Text = "Section P";
            this.ClassSection.Click += new System.EventHandler(this.ClassSection_Click);
            // 
            // ClassHeaderText
            // 
            this.ClassHeaderText.AutoSize = true;
            this.ClassHeaderText.BackColor = System.Drawing.Color.Purple;
            this.ClassHeaderText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClassHeaderText.Font = new System.Drawing.Font("Arial Unicode MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassHeaderText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassHeaderText.Location = new System.Drawing.Point(22, 85);
            this.ClassHeaderText.Name = "ClassHeaderText";
            this.ClassHeaderText.Size = new System.Drawing.Size(406, 46);
            this.ClassHeaderText.TabIndex = 1;
            this.ClassHeaderText.Text = "Fishing and Fotography";
            // 
            // headerImage
            // 
            this.headerImage.Location = new System.Drawing.Point(3, 3);
            this.headerImage.Name = "headerImage";
            this.headerImage.Size = new System.Drawing.Size(867, 188);
            this.headerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerImage.TabIndex = 0;
            this.headerImage.TabStop = false;
            // 
            // StudentsBox
            // 
            this.StudentsBox.AutoSize = true;
            this.StudentsBox.Controls.Add(this.StudentPanel);
            this.StudentsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentsBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentsBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.StudentsBox.Location = new System.Drawing.Point(0, 87);
            this.StudentsBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.StudentsBox.Name = "StudentsBox";
            this.StudentsBox.Padding = new System.Windows.Forms.Padding(2);
            this.StudentsBox.Size = new System.Drawing.Size(878, 87);
            this.StudentsBox.TabIndex = 1;
            this.StudentsBox.TabStop = false;
            this.StudentsBox.Text = "Students";
            // 
            // StudentPanel
            // 
            this.StudentPanel.Controls.Add(this.StudentName);
            this.StudentPanel.Controls.Add(this.StudentIcon);
            this.StudentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentPanel.Location = new System.Drawing.Point(2, 34);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(874, 51);
            this.StudentPanel.TabIndex = 19;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentName.Location = new System.Drawing.Point(57, 18);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(107, 20);
            this.StudentName.TabIndex = 2;
            this.StudentName.Text = "Student name";
            // 
            // StudentIcon
            // 
            this.StudentIcon.Location = new System.Drawing.Point(23, 9);
            this.StudentIcon.Name = "StudentIcon";
            this.StudentIcon.Size = new System.Drawing.Size(29, 29);
            this.StudentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentIcon.TabIndex = 1;
            this.StudentIcon.TabStop = false;
            // 
            // PostAnnouncementBtn
            // 
            this.PostAnnouncementBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.PostAnnouncementBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PostAnnouncementBtn.Location = new System.Drawing.Point(469, 60);
            this.PostAnnouncementBtn.Name = "PostAnnouncementBtn";
            this.PostAnnouncementBtn.Size = new System.Drawing.Size(129, 31);
            this.PostAnnouncementBtn.TabIndex = 1;
            this.PostAnnouncementBtn.Text = "Post";
            this.PostAnnouncementBtn.UseVisualStyleBackColor = false;
            this.PostAnnouncementBtn.Click += new System.EventHandler(this.PostAnnouncementBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Tabs);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 741);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.ProfileIcon);
            this.panel2.Controls.Add(this.ClassName);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 59);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(20, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(795, 18);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // ProfileIcon
            // 
            this.ProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("ProfileIcon.Image")));
            this.ProfileIcon.InitialImage = null;
            this.ProfileIcon.Location = new System.Drawing.Point(838, 18);
            this.ProfileIcon.Margin = new System.Windows.Forms.Padding(0);
            this.ProfileIcon.Name = "ProfileIcon";
            this.ProfileIcon.Size = new System.Drawing.Size(26, 23);
            this.ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileIcon.TabIndex = 17;
            this.ProfileIcon.TabStop = false;
            this.ProfileIcon.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassName.Location = new System.Drawing.Point(75, 18);
            this.ClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(109, 28);
            this.ClassName.TabIndex = 15;
            this.ClassName.Text = "Classroom";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.StreamTab);
            this.Tabs.Controls.Add(this.ClassworkTab);
            this.Tabs.Controls.Add(this.PeopleTab);
            this.Tabs.Location = new System.Drawing.Point(2, 64);
            this.Tabs.Margin = new System.Windows.Forms.Padding(2);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(886, 675);
            this.Tabs.TabIndex = 0;
            // 
            // StreamTab
            // 
            this.StreamTab.AutoScroll = true;
            this.StreamTab.Controls.Add(this.panel3);
            this.StreamTab.Location = new System.Drawing.Point(4, 24);
            this.StreamTab.Name = "StreamTab";
            this.StreamTab.Size = new System.Drawing.Size(878, 647);
            this.StreamTab.TabIndex = 3;
            this.StreamTab.Text = "Stream";
            this.StreamTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.ClassroomCodeBox);
            this.panel3.Controls.Add(this.AddAnnouncementPanel);
            this.panel3.Controls.Add(this.StreamBox);
            this.panel3.Controls.Add(this.UpcomingWorkBox);
            this.panel3.Controls.Add(this.ClassSection);
            this.panel3.Controls.Add(this.ClassHeaderText);
            this.panel3.Controls.Add(this.headerImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 628);
            this.panel3.TabIndex = 1;
            // 
            // ClassroomCodeBox
            // 
            this.ClassroomCodeBox.Controls.Add(this.label1);
            this.ClassroomCodeBox.Controls.Add(this.classroomCode);
            this.ClassroomCodeBox.Location = new System.Drawing.Point(25, 218);
            this.ClassroomCodeBox.Name = "ClassroomCodeBox";
            this.ClassroomCodeBox.Size = new System.Drawing.Size(193, 100);
            this.ClassroomCodeBox.TabIndex = 6;
            this.ClassroomCodeBox.TabStop = false;
            this.ClassroomCodeBox.Text = "Classroom Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Students can enter this\r\n to join the class";
            // 
            // classroomCode
            // 
            this.classroomCode.AutoSize = true;
            this.classroomCode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classroomCode.Location = new System.Drawing.Point(12, 19);
            this.classroomCode.Name = "classroomCode";
            this.classroomCode.Size = new System.Drawing.Size(87, 32);
            this.classroomCode.TabIndex = 0;
            this.classroomCode.Text = "p2djfe";
            // 
            // AddAnnouncementPanel
            // 
            this.AddAnnouncementPanel.Controls.Add(this.AddAnnouncementTextBox);
            this.AddAnnouncementPanel.Controls.Add(this.PostAnnouncementBtn);
            this.AddAnnouncementPanel.Location = new System.Drawing.Point(246, 215);
            this.AddAnnouncementPanel.Name = "AddAnnouncementPanel";
            this.AddAnnouncementPanel.Size = new System.Drawing.Size(601, 94);
            this.AddAnnouncementPanel.TabIndex = 5;
            // 
            // ClassworkTab
            // 
            this.ClassworkTab.Controls.Add(this.ClassworkGroupBox);
            this.ClassworkTab.Location = new System.Drawing.Point(4, 24);
            this.ClassworkTab.Margin = new System.Windows.Forms.Padding(2);
            this.ClassworkTab.Name = "ClassworkTab";
            this.ClassworkTab.Padding = new System.Windows.Forms.Padding(2);
            this.ClassworkTab.Size = new System.Drawing.Size(878, 647);
            this.ClassworkTab.TabIndex = 1;
            this.ClassworkTab.Text = "Classwork";
            this.ClassworkTab.UseVisualStyleBackColor = true;
            // 
            // ClassworkGroupBox
            // 
            this.ClassworkGroupBox.Controls.Add(this.ClassworkPanel);
            this.ClassworkGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkGroupBox.Location = new System.Drawing.Point(22, 16);
            this.ClassworkGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassworkGroupBox.Name = "ClassworkGroupBox";
            this.ClassworkGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ClassworkGroupBox.Size = new System.Drawing.Size(676, 406);
            this.ClassworkGroupBox.TabIndex = 0;
            this.ClassworkGroupBox.TabStop = false;
            this.ClassworkGroupBox.Text = "Classwork";
            this.ClassworkGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ClassworkPanel
            // 
            this.ClassworkPanel.Controls.Add(this.DUElabel);
            this.ClassworkPanel.Controls.Add(this.ClassworkDueTime);
            this.ClassworkPanel.Controls.Add(this.ClassworkDueDate);
            this.ClassworkPanel.Controls.Add(this.ClassworkName);
            this.ClassworkPanel.Controls.Add(this.ClassworkIcon);
            this.ClassworkPanel.Controls.Add(this.ClassworkBgButton);
            this.ClassworkPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassworkPanel.Location = new System.Drawing.Point(2, 24);
            this.ClassworkPanel.Name = "ClassworkPanel";
            this.ClassworkPanel.Size = new System.Drawing.Size(672, 50);
            this.ClassworkPanel.TabIndex = 6;
            // 
            // DUElabel
            // 
            this.DUElabel.AutoSize = true;
            this.DUElabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DUElabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DUElabel.Location = new System.Drawing.Point(515, 17);
            this.DUElabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DUElabel.Name = "DUElabel";
            this.DUElabel.Size = new System.Drawing.Size(36, 15);
            this.DUElabel.TabIndex = 5;
            this.DUElabel.Text = "Due: ";
            // 
            // ClassworkDueTime
            // 
            this.ClassworkDueTime.AutoSize = true;
            this.ClassworkDueTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkDueTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClassworkDueTime.Location = new System.Drawing.Point(599, 17);
            this.ClassworkDueTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassworkDueTime.Name = "ClassworkDueTime";
            this.ClassworkDueTime.Size = new System.Drawing.Size(56, 15);
            this.ClassworkDueTime.TabIndex = 4;
            this.ClassworkDueTime.Text = "12:00PM";
            // 
            // ClassworkDueDate
            // 
            this.ClassworkDueDate.AutoSize = true;
            this.ClassworkDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkDueDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClassworkDueDate.Location = new System.Drawing.Point(555, 17);
            this.ClassworkDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassworkDueDate.Name = "ClassworkDueDate";
            this.ClassworkDueDate.Size = new System.Drawing.Size(40, 15);
            this.ClassworkDueDate.TabIndex = 3;
            this.ClassworkDueDate.Text = "May 6";
            // 
            // ClassworkName
            // 
            this.ClassworkName.AutoSize = true;
            this.ClassworkName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassworkName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkName.Location = new System.Drawing.Point(65, 13);
            this.ClassworkName.Name = "ClassworkName";
            this.ClassworkName.Size = new System.Drawing.Size(40, 20);
            this.ClassworkName.TabIndex = 2;
            this.ClassworkName.Text = "Quiz";
            // 
            // ClassworkIcon
            // 
            this.ClassworkIcon.Location = new System.Drawing.Point(27, 9);
            this.ClassworkIcon.Name = "ClassworkIcon";
            this.ClassworkIcon.Size = new System.Drawing.Size(32, 29);
            this.ClassworkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClassworkIcon.TabIndex = 1;
            this.ClassworkIcon.TabStop = false;
            // 
            // ClassworkBgButton
            // 
            this.ClassworkBgButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassworkBgButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassworkBgButton.Location = new System.Drawing.Point(0, 0);
            this.ClassworkBgButton.Name = "ClassworkBgButton";
            this.ClassworkBgButton.Size = new System.Drawing.Size(672, 47);
            this.ClassworkBgButton.TabIndex = 0;
            this.ClassworkBgButton.UseVisualStyleBackColor = false;
            // 
            // PeopleTab
            // 
            this.PeopleTab.Controls.Add(this.StudentsBox);
            this.PeopleTab.Controls.Add(this.TeachersBox);
            this.PeopleTab.Location = new System.Drawing.Point(4, 24);
            this.PeopleTab.Margin = new System.Windows.Forms.Padding(2);
            this.PeopleTab.Name = "PeopleTab";
            this.PeopleTab.Size = new System.Drawing.Size(878, 647);
            this.PeopleTab.TabIndex = 2;
            this.PeopleTab.Text = "People";
            this.PeopleTab.UseVisualStyleBackColor = true;
            // 
            // TeachersBox
            // 
            this.TeachersBox.AutoSize = true;
            this.TeachersBox.Controls.Add(this.TeacherPanel);
            this.TeachersBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TeachersBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeachersBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TeachersBox.Location = new System.Drawing.Point(0, 0);
            this.TeachersBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.TeachersBox.Name = "TeachersBox";
            this.TeachersBox.Padding = new System.Windows.Forms.Padding(2);
            this.TeachersBox.Size = new System.Drawing.Size(878, 87);
            this.TeachersBox.TabIndex = 0;
            this.TeachersBox.TabStop = false;
            this.TeachersBox.Text = "Teachers";
            // 
            // TeacherPanel
            // 
            this.TeacherPanel.Controls.Add(this.TeacherNameLabel);
            this.TeacherPanel.Controls.Add(this.TeacherIcon);
            this.TeacherPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TeacherPanel.Location = new System.Drawing.Point(2, 34);
            this.TeacherPanel.Name = "TeacherPanel";
            this.TeacherPanel.Size = new System.Drawing.Size(874, 51);
            this.TeacherPanel.TabIndex = 19;
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TeacherNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeacherNameLabel.ForeColor = System.Drawing.Color.Black;
            this.TeacherNameLabel.Location = new System.Drawing.Point(58, 18);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(106, 20);
            this.TeacherNameLabel.TabIndex = 2;
            this.TeacherNameLabel.Text = "Teacher name";
            this.TeacherNameLabel.Click += new System.EventHandler(this.TeacherNameLabel_Click);
            // 
            // TeacherIcon
            // 
            this.TeacherIcon.Location = new System.Drawing.Point(23, 9);
            this.TeacherIcon.Name = "TeacherIcon";
            this.TeacherIcon.Size = new System.Drawing.Size(29, 29);
            this.TeacherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TeacherIcon.TabIndex = 1;
            this.TeacherIcon.TabStop = false;
            // 
            // StudentNavigate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 749);
            this.Controls.Add(this.panel1);
            this.Name = "StudentNavigate";
            this.Text = "StudentNavigate";
            this.AnnouncementPanel.ResumeLayout(false);
            this.AnnouncementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnnouncementPanelPersonIcon)).EndInit();
            this.newpostpanel2.ResumeLayout(false);
            this.newpostpanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newpostpanel2icon)).EndInit();
            this.NewPostPanel1.ResumeLayout(false);
            this.NewPostPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newpostpanel1icon)).EndInit();
            this.StreamBox.ResumeLayout(false);
            this.UpcomingWorkBox.ResumeLayout(false);
            this.UpcomingWorkPanel.ResumeLayout(false);
            this.UpcomingWorkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
            this.StudentsBox.ResumeLayout(false);
            this.StudentPanel.ResumeLayout(false);
            this.StudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.StreamTab.ResumeLayout(false);
            this.StreamTab.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ClassroomCodeBox.ResumeLayout(false);
            this.ClassroomCodeBox.PerformLayout();
            this.AddAnnouncementPanel.ResumeLayout(false);
            this.AddAnnouncementPanel.PerformLayout();
            this.ClassworkTab.ResumeLayout(false);
            this.ClassworkGroupBox.ResumeLayout(false);
            this.ClassworkPanel.ResumeLayout(false);
            this.ClassworkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassworkIcon)).EndInit();
            this.PeopleTab.ResumeLayout(false);
            this.PeopleTab.PerformLayout();
            this.TeachersBox.ResumeLayout(false);
            this.TeacherPanel.ResumeLayout(false);
            this.TeacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private LinkedList<int> streamPanelIDs = new LinkedList<int>();
        private LinkedList<Panel> streamPanels = new LinkedList<Panel>();
        private LinkedList<int> upcomingWorkPanelIDs = new LinkedList<int>();
        private static int tracker;
        private TextBox AddAnnouncementTextBox;
        private Panel AnnouncementPanel;
        private Label AnnouncementPanelText;
        private Label AnnouncementPanelDate;
        private Label AnnouncementPanelPersonName;
        private PictureBox AnnouncementPanelPersonIcon;
        private Button AnnouncementPanelBGButton;
        private Panel newpostpanel2;
        private Label newpostpanel2date;
        private Label newPostPanel2Heading;
        private PictureBox newpostpanel2icon;
        private Button newpostpanel2bgbutton;
        private Panel NewPostPanel1;
        private Label label2;
        private Label newpostpanel1Heading;
        private PictureBox newpostpanel1icon;
        private Button newpostpanel1bgbutton;
        private GroupBox StreamBox;
        private GroupBox UpcomingWorkBox;
        private Panel UpcomingWorkPanel;
        private Label UpcomingWorkPanel1Heading;
        private Label UpcomingWorkPanel1Subheading;
        private Label ClassSection;
        private Label ClassHeaderText;
        private PictureBox headerImage;
        private GroupBox StudentsBox;
        private Panel StudentPanel;
        private Label StudentName;
        private PictureBox StudentIcon;
        private Button PostAnnouncementBtn;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox ProfileIcon;
        private Label ClassName;
        private TabControl Tabs;
        private TabPage StreamTab;
        private Panel panel3;
        private GroupBox ClassroomCodeBox;
        private Label label1;
        private Label classroomCode;
        private Panel AddAnnouncementPanel;
        private TabPage ClassworkTab;
        private GroupBox ClassworkGroupBox;
        private Panel ClassworkPanel;
        private Label DUElabel;
        private Label ClassworkDueTime;
        private Label ClassworkDueDate;
        private Label ClassworkName;
        private PictureBox ClassworkIcon;
        private Button ClassworkBgButton;
        private TabPage PeopleTab;
        private GroupBox TeachersBox;
        private Panel TeacherPanel;
        private Label TeacherNameLabel;
        private PictureBox TeacherIcon;


        #endregion

        private Button button1;
    }
}