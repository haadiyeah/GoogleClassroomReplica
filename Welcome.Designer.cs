namespace lab10
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private LinkedList<int> streamPanelIDs = new LinkedList<int>();
        private LinkedList<Panel> streamPanels = new LinkedList<Panel>();

        private LinkedList<int> upcomingWorkPanelIDs = new LinkedList<int>();

        //private LinkedList<Label> labels = new LinkedList<Label>(); 
        //private LinkedList<Button> buttons = new LinkedList<Button>();  
        //private LinkedList<PictureBox> pictureBoxes = new LinkedList<PictureBox>();
        private static int tracker = 0;

        /// <summary>
        ///  Clean up any resources being used.
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

        public void addNewClassworkToStream(String type, String assingmentTitle, String teacherName, int postID)
        {
            Panel newpostpanel = new System.Windows.Forms.Panel();
            streamPanels.AddFirst(newpostpanel);
            streamPanelIDs.AddFirst(postID);
                Button newpostpanelbgbutton = new System.Windows.Forms.Button();
                Label newpostpanelHeading = new System.Windows.Forms.Label();
                 PictureBox newpostpanelicon = new System.Windows.Forms.PictureBox();

            this.StreamBox.Controls.Add(newpostpanel);

            newpostpanel.Controls.Add(newpostpanelHeading);
            newpostpanel.Controls.Add(newpostpanelicon);
            newpostpanel.Controls.Add(newpostpanelbgbutton);
            newpostpanel.Dock = System.Windows.Forms.DockStyle.Top;
            newpostpanel.Location = new System.Drawing.Point(3, 19);
            newpostpanel.Name = "newpostpanel" + tracker.ToString();
            newpostpanel.Size = new System.Drawing.Size(598, 80);
            newpostpanel.TabIndex = 3;
            // 
            // newpostpanelHeading
            // 
            newpostpanelHeading.AutoSize = true;
            newpostpanelHeading.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            newpostpanelHeading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            newpostpanelHeading.Location = new System.Drawing.Point(71, 28);
            newpostpanelHeading.Name = "newpostpanelHeading" + tracker.ToString();
            newpostpanelHeading.Size = new System.Drawing.Size(305, 20);
            newpostpanelHeading.TabIndex = 2;
            newpostpanelHeading.Text = teacherName + " posted a new " + type + ": " + assingmentTitle;
            newpostpanelHeading.Click += new System.EventHandler(this.label2_Click);
            // 
            // newpostpanelicon
            // 
            if (type == "Assignment")
                newpostpanelicon.Load("..\\..\\..\\images\\assignmenticon.png");
            else if (type=="Material")
                newpostpanelicon.Load("..\\..\\..\\images\\materialicon.png");

            newpostpanelicon.Location = new System.Drawing.Point(20, 15);
            newpostpanelicon.Name = "newpostpanelicon" + tracker.ToString();
            newpostpanelicon.Size = new System.Drawing.Size(45, 45);
            newpostpanelicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            newpostpanelicon.TabIndex = 1;
            newpostpanelicon.TabStop = false;
            // 
            // newpostpanelbgbutton
            // 
            newpostpanelbgbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            newpostpanelbgbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newpostpanelbgbutton.Location = new System.Drawing.Point(3, 3);
            newpostpanelbgbutton.Name = "newpostpanelbgbutton" + tracker.ToString();
            newpostpanelbgbutton.Size = new System.Drawing.Size(592, 72);
            newpostpanelbgbutton.TabIndex = 0;
            newpostpanelbgbutton.UseVisualStyleBackColor = false;
            // newpostpanelbgbutton.Click += new System.EventHandler(this.button1_Click);
            // 

            tracker++;

        }

        public void createAnnouncement(String datetime, String announcername, String announcerType, String announcement, int postID)
        {
            Button AnnouncementPanelBGButton = new System.Windows.Forms.Button();
            Panel AnnouncementPanel = new System.Windows.Forms.Panel();
            streamPanels.AddFirst(AnnouncementPanel);
            streamPanelIDs.AddFirst(postID);
            Label AnnouncementPanelPersonName = new System.Windows.Forms.Label();
            PictureBox AnnouncementPanelPersonIcon = new System.Windows.Forms.PictureBox();
            Label AnnouncementPanelDate = new System.Windows.Forms.Label();
            Label AnnouncementPanelText = new System.Windows.Forms.Label();

            this.StreamBox.Controls.Add(AnnouncementPanel);
            // AnnouncementPanel
            // 
            AnnouncementPanel.Controls.Add(AnnouncementPanelText);
            AnnouncementPanel.Controls.Add(AnnouncementPanelDate);
            AnnouncementPanel.Controls.Add(AnnouncementPanelPersonName);
            AnnouncementPanel.Controls.Add(AnnouncementPanelPersonIcon);
            AnnouncementPanel.Controls.Add(AnnouncementPanelBGButton);
            AnnouncementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            AnnouncementPanel.Location = new System.Drawing.Point(3, 178);
            AnnouncementPanel.Name = "AnnouncementPanel" + tracker.ToString();
            AnnouncementPanel.Size = new System.Drawing.Size(598, 113);
            AnnouncementPanel.TabIndex = 7;
            // 
            // 
            // AnnouncementPanelBGButton
            // 
            AnnouncementPanelBGButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            AnnouncementPanelBGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AnnouncementPanelBGButton.Location = new System.Drawing.Point(3, 3);
            AnnouncementPanelBGButton.Name = "AnnouncementPanelBGButton" + tracker.ToString();
            AnnouncementPanelBGButton.Size = new System.Drawing.Size(592, 107);
            AnnouncementPanelBGButton.TabIndex = 0;
            AnnouncementPanelBGButton.UseVisualStyleBackColor = false;
           // AnnouncementPanelBGButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            
            // AnnouncementPanelPersonName
            // 
            AnnouncementPanelPersonName.AutoSize = true;
            AnnouncementPanelPersonName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            AnnouncementPanelPersonName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AnnouncementPanelPersonName.Location = new System.Drawing.Point(58, 15);
            AnnouncementPanelPersonName.Name = "AnnouncementPanelPersonName" + tracker.ToString();
            AnnouncementPanelPersonName.Size = new System.Drawing.Size(102, 20);
            AnnouncementPanelPersonName.TabIndex = 2;
            AnnouncementPanelPersonName.Text = announcername;
           // AnnouncementPanelPersonName.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // AnnouncementPanelPersonIcon
            // 
            if(announcerType=="Teacher")
            AnnouncementPanelPersonIcon.Load("..\\..\\..\\images\\teachericon.png");
            else if(announcerType=="Student")
                AnnouncementPanelPersonIcon.Load("..\\..\\..\\images\\studenticon.png");

            AnnouncementPanelPersonIcon.Location = new System.Drawing.Point(20, 16);
            AnnouncementPanelPersonIcon.Name = "AnnouncementPanelPersonIcon" + tracker.ToString();
            AnnouncementPanelPersonIcon.Size = new System.Drawing.Size(32, 32);
            AnnouncementPanelPersonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            AnnouncementPanelPersonIcon.TabIndex = 1;
            AnnouncementPanelPersonIcon.TabStop = false;
            // 
            // AnnouncementPanelDate
            // 
            AnnouncementPanelDate.AutoSize = true;
            AnnouncementPanelDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            AnnouncementPanelDate.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AnnouncementPanelDate.Location = new System.Drawing.Point(58, 35);
            AnnouncementPanelDate.Name = "AnnouncementPanelDate" + tracker.ToString();
            AnnouncementPanelDate.Size = new System.Drawing.Size(111, 13);
            AnnouncementPanelDate.TabIndex = 3;
            AnnouncementPanelDate.Text = datetime;
            // 
            // AnnouncementPanelText
            // 
            AnnouncementPanelText.AutoSize = true;
            AnnouncementPanelText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            AnnouncementPanelText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AnnouncementPanelText.Location = new System.Drawing.Point(20, 64);
            AnnouncementPanelText.Name = "AnnouncementPanelText" + tracker.ToString();
            AnnouncementPanelText.Size = new System.Drawing.Size(481, 17);
            AnnouncementPanelText.TabIndex = 4;
            AnnouncementPanelText.Text = announcement;

            tracker++;


        }

        public void addDeadlineToUpcomingWork(String duedate, String assignmentName, int postID)
        {
            
            Panel UpcomingWorkPanel = new System.Windows.Forms.Panel();
            Label UpcomingWorkPanelHeading = new System.Windows.Forms.Label();
            Label UpcomingWorkPanelSubheading = new System.Windows.Forms.Label();

            if(postID>=0)
                upcomingWorkPanelIDs.AddFirst(postID);

            // UpcomingWorkPanel
            // 
            UpcomingWorkPanel.Controls.Add(UpcomingWorkPanel1Heading);
            UpcomingWorkPanel.Controls.Add(UpcomingWorkPanel1Subheading);
            UpcomingWorkPanel.Dock = System.Windows.Forms.DockStyle.Top;
            UpcomingWorkPanel.Location = new System.Drawing.Point(3, 19);
            UpcomingWorkPanel.Name = "UpcomingWorkPanel" + tracker.ToString();
            UpcomingWorkPanel.Size = new System.Drawing.Size(193, 41);
            UpcomingWorkPanel.TabIndex = 2;
            // 
            // UpcomingWorkPanel1Heading
            // 
            UpcomingWorkPanelHeading.AutoSize = true;
            UpcomingWorkPanelHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            UpcomingWorkPanelHeading.Location = new System.Drawing.Point(12, 6);
            UpcomingWorkPanelHeading.Name = "UpcomingWorkPanelHeading" + tracker.ToString();
            UpcomingWorkPanelHeading.Size = new System.Drawing.Size(82, 15);
            UpcomingWorkPanelHeading.TabIndex = 0;
            UpcomingWorkPanelHeading.Text = assignmentName;
            // 
            // UpcomingWorkPanelSubheading
            // 
            UpcomingWorkPanelSubheading.AutoSize = true;
            UpcomingWorkPanelSubheading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UpcomingWorkPanelSubheading.Location = new System.Drawing.Point(12, 21);
            UpcomingWorkPanelSubheading.Name = "UpcomingWorkPanelSubheading" + tracker.ToString();
            UpcomingWorkPanelSubheading.Size = new System.Drawing.Size(76, 15);
            UpcomingWorkPanelSubheading.TabIndex = 1;
            UpcomingWorkPanelSubheading.Text = "Due " + duedate;
           
            // 


        }

        public void setInfo(String className, String classCode, String section, String headerimageurl = "..\\..\\..\\images\\header1.jpeg")
        {
            this.ClassSection.Text = section;
            this.ClassName.Text = className;
            this.headerImage.Load(headerimageurl);
            this.classroomCode.Text = classCode;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClassroomCodeBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classroomCode = new System.Windows.Forms.Label();
            this.AddAnnouncementPanel = new System.Windows.Forms.Panel();
            this.AddAnnouncementTextBox = new System.Windows.Forms.TextBox();
            this.PostAnnouncementBtn = new System.Windows.Forms.Button();
            this.StreamBox = new System.Windows.Forms.GroupBox();
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
            this.UpcomingWorkBox = new System.Windows.Forms.GroupBox();
            this.UpcomingWorkPanel = new System.Windows.Forms.Panel();
            this.UpcomingWorkPanel1Heading = new System.Windows.Forms.Label();
            this.UpcomingWorkPanel1Subheading = new System.Windows.Forms.Label();
            this.ClassSection = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.Label();
            this.headerImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.ClassroomCodeBox.SuspendLayout();
            this.AddAnnouncementPanel.SuspendLayout();
            this.StreamBox.SuspendLayout();
            this.AnnouncementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnnouncementPanelPersonIcon)).BeginInit();
            this.newpostpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newpostpanel2icon)).BeginInit();
            this.NewPostPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newpostpanel1icon)).BeginInit();
            this.UpcomingWorkBox.SuspendLayout();
            this.UpcomingWorkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.ClassroomCodeBox);
            this.panel1.Controls.Add(this.AddAnnouncementPanel);
            this.panel1.Controls.Add(this.StreamBox);
            this.panel1.Controls.Add(this.UpcomingWorkBox);
            this.panel1.Controls.Add(this.ClassSection);
            this.panel1.Controls.Add(this.ClassName);
            this.panel1.Controls.Add(this.headerImage);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 930);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.ClassroomCodeBox.Enter += new System.EventHandler(this.groupBox1_Enter_2);
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
            this.classroomCode.Click += new System.EventHandler(this.classroomCode_Click);
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
            // AddAnnouncementTextBox
            // 
            this.AddAnnouncementTextBox.Location = new System.Drawing.Point(3, 3);
            this.AddAnnouncementTextBox.Multiline = true;
            this.AddAnnouncementTextBox.Name = "AddAnnouncementTextBox";
            this.AddAnnouncementTextBox.PlaceholderText = "Announce something to your class";
            this.AddAnnouncementTextBox.Size = new System.Drawing.Size(595, 57);
            this.AddAnnouncementTextBox.TabIndex = 2;
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
            // StreamBox
            // 
            this.StreamBox.AutoSize = true;
            this.StreamBox.Controls.Add(this.AnnouncementPanel);
            this.StreamBox.Controls.Add(this.newpostpanel2);
            this.StreamBox.Controls.Add(this.NewPostPanel1);
            this.StreamBox.Location = new System.Drawing.Point(246, 315);
            this.StreamBox.Name = "StreamBox";
            this.StreamBox.Size = new System.Drawing.Size(604, 301);
            this.StreamBox.TabIndex = 4;
            this.StreamBox.TabStop = false;
            this.StreamBox.Text = "Stream";
            this.StreamBox.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.AnnouncementPanelPersonIcon.Image = ((System.Drawing.Image)(resources.GetObject("AnnouncementPanelPersonIcon.Image")));
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
            this.newPostPanel2Heading.Click += new System.EventHandler(this.label3_Click);
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
            this.newpostpanel2bgbutton.Click += new System.EventHandler(this.button2_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
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
            this.newpostpanel1Heading.Click += new System.EventHandler(this.label2_Click);
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
            this.newpostpanel1bgbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpcomingWorkBox
            // 
            this.UpcomingWorkBox.AutoSize = true;
            this.UpcomingWorkBox.Controls.Add(this.UpcomingWorkPanel);
            this.UpcomingWorkBox.Location = new System.Drawing.Point(22, 334);
            this.UpcomingWorkBox.Name = "UpcomingWorkBox";
            this.UpcomingWorkBox.Size = new System.Drawing.Size(196, 75);
            this.UpcomingWorkBox.TabIndex = 3;
            this.UpcomingWorkBox.TabStop = false;
            this.UpcomingWorkBox.Text = "Upcoming work";
            this.UpcomingWorkBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // UpcomingWorkPanel
            // 
            this.UpcomingWorkPanel.Controls.Add(this.UpcomingWorkPanel1Heading);
            this.UpcomingWorkPanel.Controls.Add(this.UpcomingWorkPanel1Subheading);
            this.UpcomingWorkPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpcomingWorkPanel.Location = new System.Drawing.Point(3, 19);
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
            this.UpcomingWorkPanel1Heading.Click += new System.EventHandler(this.label5_Click);
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
            this.UpcomingWorkPanel1Subheading.Click += new System.EventHandler(this.label6_Click);
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
            //this.ClassSection.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.BackColor = System.Drawing.Color.Purple;
            this.ClassName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClassName.Font = new System.Drawing.Font("Arial Unicode MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassName.Location = new System.Drawing.Point(22, 85);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(406, 46);
            this.ClassName.TabIndex = 1;
            this.ClassName.Text = "Fishing and Fotography";
            //this.ClassName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // headerImage
            // 
            this.headerImage.Image = ((System.Drawing.Image)(resources.GetObject("headerImage.Image")));
            this.headerImage.Location = new System.Drawing.Point(3, 3);
            this.headerImage.Name = "headerImage";
            this.headerImage.Size = new System.Drawing.Size(867, 188);
            this.headerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerImage.TabIndex = 0;
            this.headerImage.TabStop = false;
            //this.headerImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(897, 749);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ClassroomCodeBox.ResumeLayout(false);
            this.ClassroomCodeBox.PerformLayout();
            this.AddAnnouncementPanel.ResumeLayout(false);
            this.AddAnnouncementPanel.PerformLayout();
            this.StreamBox.ResumeLayout(false);
            this.AnnouncementPanel.ResumeLayout(false);
            this.AnnouncementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnnouncementPanelPersonIcon)).EndInit();
            this.newpostpanel2.ResumeLayout(false);
            this.newpostpanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newpostpanel2icon)).EndInit();
            this.NewPostPanel1.ResumeLayout(false);
            this.NewPostPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newpostpanel1icon)).EndInit();
            this.UpcomingWorkBox.ResumeLayout(false);
            this.UpcomingWorkPanel.ResumeLayout(false);
            this.UpcomingWorkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private Panel panel1;
        private PictureBox headerImage;
        private Label ClassName;
        private Label ClassSection;
        private GroupBox UpcomingWorkBox;
        private GroupBox StreamBox;
        
        private Panel NewPostPanel1;
        private Button newpostpanel1bgbutton;
        private Label newpostpanel1Heading;
        private PictureBox newpostpanel1icon;

        private Panel newpostpanel2;
        private Label newPostPanel2Heading;
        private PictureBox newpostpanel2icon;
        private Button newpostpanel2bgbutton;

        private Label UpcomingWorkPanel1Heading;
        private Label UpcomingWorkPanel1Subheading;
        private Panel UpcomingWorkPanel;
        private Panel AddAnnouncementPanel;
        private TextBox AddAnnouncementTextBox;
        private Button PostAnnouncementBtn;
        private Panel AnnouncementPanel;
        private Label AnnouncementPanelText;
        private Label AnnouncementPanelDate;
        private Label AnnouncementPanelPersonName;
        private PictureBox AnnouncementPanelPersonIcon;
        private Button AnnouncementPanelBGButton;
        private Label newpostpanel2date;
        private Label label2;
        private GroupBox ClassroomCodeBox;
        private Label classroomCode;
        private Label label1;
    }
}