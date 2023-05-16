using System.Data.SqlClient;

namespace lab10
{
    partial class ViewingClasswork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        static int tracker = 1;

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

        //Boolean indicates whether to add the comment to private commnents box or public
        public void addComment(String commenterName, String comment, bool isPrivate)
        {
            Panel NewCommentPanel = new System.Windows.Forms.Panel();
            Label NewCommentDescription = new System.Windows.Forms.Label();
            Label NewCommenterPersonName = new System.Windows.Forms.Label();

            if (isPrivate)
            {
                this.PrivateCommentsBox.Controls.Add(NewCommentPanel);
            }
            else
            {
                this.ClassworkCommentsBox.Controls.Add(NewCommentPanel);
            }
            // ClassCommentPanel
            // 
            NewCommentPanel.Controls.Add(NewCommentDescription);
            NewCommentPanel.Controls.Add(NewCommenterPersonName);
            NewCommentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            NewCommentPanel.Location = new System.Drawing.Point(2, 18);
            NewCommentPanel.Name = "ClassCommentPanel" + tracker.ToString();
            NewCommentPanel.Size = new System.Drawing.Size(486, 29);
            NewCommentPanel.TabIndex = 0;
            // 
            // ClassCommentDescription
            // 
            NewCommentDescription.AutoEllipsis = true;
            NewCommentDescription.Dock = System.Windows.Forms.DockStyle.Left;
            NewCommentDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewCommentDescription.Location = new System.Drawing.Point(96, 0);
            NewCommentDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            NewCommentDescription.Name = "ClassCommentDescription" + tracker.ToString();
            NewCommentDescription.Size = new System.Drawing.Size(388, 29);
            NewCommentDescription.TabIndex = 46;
            NewCommentDescription.Text = comment;
            // 
            // ClassCommenterPersonName
            // 
            NewCommenterPersonName.AutoSize = true;
            NewCommenterPersonName.Dock = System.Windows.Forms.DockStyle.Left;
            NewCommenterPersonName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            NewCommenterPersonName.Location = new System.Drawing.Point(0, 0);
            NewCommenterPersonName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            NewCommenterPersonName.Name = "ClassCommenterPersonName" + tracker.ToString();
            NewCommenterPersonName.Size = new System.Drawing.Size(96, 15);
            NewCommenterPersonName.TabIndex = 45;
            NewCommenterPersonName.Text = commenterName;
            // 


           

        }

        public void setInfo(String classworkName,String type, String duedate, String postdate, String postedBy, String desc, String totalMarks)
        {
            this.ClassworkDescription.Text = desc;
            this.ClassworkPersonWhoPosted.Text = "Posted by " +postedBy;
            this.ClassworkTitleLabel.Text = classworkName;
            this.ClassworkPostDateLabel.Text = postdate;
            this.ClassworkDeadlineLabel.Text = duedate;
            this.ClassworkTotalPoints.Text ="Total points: " +totalMarks;
            if (type == "Assignment")
                this.ClassworkIcon.Load("..\\..\\..\\images\\assignmenticon.png");
            else if (type == "Material")
                this.ClassworkIcon.Load("..\\..\\..\\images\\materialicon.png");

        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewingClasswork));
            this.assignmentStatusLabel = new System.Windows.Forms.Label();
            this.assignment = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dueLabel = new System.Windows.Forms.Label();
            this.Postcommentpanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.postcommentbutton = new System.Windows.Forms.Button();
            this.CurrentPersonEmail2 = new System.Windows.Forms.Label();
            this.ClassCommentTextBox = new System.Windows.Forms.RichTextBox();
            this.personcommenticon = new System.Windows.Forms.PictureBox();
            this.ClassworkPostDateLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.commenticon = new System.Windows.Forms.PictureBox();
            this.ClassworkIcon = new System.Windows.Forms.PictureBox();
            this.ClassworkCommentsBox = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassCommentPanel = new System.Windows.Forms.Panel();
            this.ClassCommentDescription = new System.Windows.Forms.Label();
            this.ClassCommenterPersonName = new System.Windows.Forms.Label();
            this.ClassworkTotalPoints = new System.Windows.Forms.Label();
            this.ClassworkDeadlineLabel = new System.Windows.Forms.Label();
            this.ClassworkPersonWhoPosted = new System.Windows.Forms.Label();
            this.ClassworkDescription = new System.Windows.Forms.Label();
            this.ClassworkTitleLabel = new System.Windows.Forms.Label();
            this.PrivateCommentTextBox = new System.Windows.Forms.TextBox();
            this.postprivatecomment = new System.Windows.Forms.Button();
            this.personicon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CurrentClassName = new System.Windows.Forms.Label();
            this.ClassworkMarkAsDone = new System.Windows.Forms.Button();
            this.PrivateCommentsBox = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yourWorkPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ClassworkAddOrCreate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Privatecomment = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.assignment.SuspendLayout();
            this.Postcommentpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personcommenticon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commenticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassworkIcon)).BeginInit();
            this.ClassworkCommentsBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ClassCommentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personicon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PrivateCommentsBox.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.yourWorkPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentStatusLabel
            // 
            this.assignmentStatusLabel.AutoSize = true;
            this.assignmentStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.assignmentStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignmentStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.assignmentStatusLabel.Location = new System.Drawing.Point(189, 17);
            this.assignmentStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assignmentStatusLabel.Name = "assignmentStatusLabel";
            this.assignmentStatusLabel.Size = new System.Drawing.Size(56, 15);
            this.assignmentStatusLabel.TabIndex = 6;
            this.assignmentStatusLabel.Text = "Assigned";
            // 
            // assignment
            // 
            this.assignment.AutoSize = true;
            this.assignment.Controls.Add(this.label4);
            this.assignment.Controls.Add(this.dueLabel);
            this.assignment.Controls.Add(this.Postcommentpanel);
            this.assignment.Controls.Add(this.ClassworkPostDateLabel);
            this.assignment.Controls.Add(this.panel3);
            this.assignment.Controls.Add(this.ClassworkIcon);
            this.assignment.Controls.Add(this.ClassworkCommentsBox);
            this.assignment.Controls.Add(this.ClassworkTotalPoints);
            this.assignment.Controls.Add(this.ClassworkDeadlineLabel);
            this.assignment.Controls.Add(this.ClassworkPersonWhoPosted);
            this.assignment.Controls.Add(this.ClassworkDescription);
            this.assignment.Controls.Add(this.ClassworkTitleLabel);
            this.assignment.Location = new System.Drawing.Point(12, 12);
            this.assignment.Margin = new System.Windows.Forms.Padding(2);
            this.assignment.Name = "assignment";
            this.assignment.Padding = new System.Windows.Forms.Padding(2);
            this.assignment.Size = new System.Drawing.Size(501, 506);
            this.assignment.TabIndex = 2;
            this.assignment.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Posted by:";
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Location = new System.Drawing.Point(319, 56);
            this.dueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(31, 15);
            this.dueLabel.TabIndex = 45;
            this.dueLabel.Text = "Due:";
            // 
            // Postcommentpanel
            // 
            this.Postcommentpanel.Controls.Add(this.label6);
            this.Postcommentpanel.Controls.Add(this.postcommentbutton);
            this.Postcommentpanel.Controls.Add(this.CurrentPersonEmail2);
            this.Postcommentpanel.Controls.Add(this.ClassCommentTextBox);
            this.Postcommentpanel.Controls.Add(this.personcommenticon);
            this.Postcommentpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Postcommentpanel.Location = new System.Drawing.Point(2, 420);
            this.Postcommentpanel.Margin = new System.Windows.Forms.Padding(2);
            this.Postcommentpanel.Name = "Postcommentpanel";
            this.Postcommentpanel.Size = new System.Drawing.Size(497, 84);
            this.Postcommentpanel.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Add a class comment";
            // 
            // postcommentbutton
            // 
            this.postcommentbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.postcommentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postcommentbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postcommentbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postcommentbutton.Location = new System.Drawing.Point(439, 35);
            this.postcommentbutton.Margin = new System.Windows.Forms.Padding(2);
            this.postcommentbutton.Name = "postcommentbutton";
            this.postcommentbutton.Size = new System.Drawing.Size(50, 24);
            this.postcommentbutton.TabIndex = 25;
            this.postcommentbutton.Text = "Post";
            this.postcommentbutton.UseVisualStyleBackColor = false;
            this.postcommentbutton.Click += new System.EventHandler(this.postcommentbutton_Click);
            // 
            // CurrentPersonEmail2
            // 
            this.CurrentPersonEmail2.AutoSize = true;
            this.CurrentPersonEmail2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentPersonEmail2.Location = new System.Drawing.Point(40, 6);
            this.CurrentPersonEmail2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentPersonEmail2.Name = "CurrentPersonEmail2";
            this.CurrentPersonEmail2.Size = new System.Drawing.Size(0, 19);
            this.CurrentPersonEmail2.TabIndex = 48;
            // 
            // ClassCommentTextBox
            // 
            this.ClassCommentTextBox.Location = new System.Drawing.Point(4, 35);
            this.ClassCommentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassCommentTextBox.Name = "ClassCommentTextBox";
            this.ClassCommentTextBox.Size = new System.Drawing.Size(431, 33);
            this.ClassCommentTextBox.TabIndex = 45;
            this.ClassCommentTextBox.Text = "";
            // 
            // personcommenticon
            // 
            this.personcommenticon.Image = ((System.Drawing.Image)(resources.GetObject("personcommenticon.Image")));
            this.personcommenticon.InitialImage = null;
            this.personcommenticon.Location = new System.Drawing.Point(5, 6);
            this.personcommenticon.Margin = new System.Windows.Forms.Padding(0);
            this.personcommenticon.Name = "personcommenticon";
            this.personcommenticon.Size = new System.Drawing.Size(29, 27);
            this.personcommenticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personcommenticon.TabIndex = 44;
            this.personcommenticon.TabStop = false;
            // 
            // ClassworkPostDateLabel
            // 
            this.ClassworkPostDateLabel.AutoSize = true;
            this.ClassworkPostDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClassworkPostDateLabel.Location = new System.Drawing.Point(354, 32);
            this.ClassworkPostDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassworkPostDateLabel.Name = "ClassworkPostDateLabel";
            this.ClassworkPostDateLabel.Size = new System.Drawing.Size(132, 15);
            this.ClassworkPostDateLabel.TabIndex = 36;
            this.ClassworkPostDateLabel.Text = "yyyy-mm-dd hh:mm:ss";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.commenticon);
            this.panel3.Location = new System.Drawing.Point(6, 216);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 31);
            this.panel3.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(48, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "Class Comments";
            // 
            // commenticon
            // 
            this.commenticon.ErrorImage = null;
            this.commenticon.Image = ((System.Drawing.Image)(resources.GetObject("commenticon.Image")));
            this.commenticon.InitialImage = null;
            this.commenticon.Location = new System.Drawing.Point(1, 0);
            this.commenticon.Margin = new System.Windows.Forms.Padding(0);
            this.commenticon.Name = "commenticon";
            this.commenticon.Size = new System.Drawing.Size(35, 31);
            this.commenticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commenticon.TabIndex = 43;
            this.commenticon.TabStop = false;
            // 
            // ClassworkIcon
            // 
            this.ClassworkIcon.Location = new System.Drawing.Point(7, 21);
            this.ClassworkIcon.Name = "ClassworkIcon";
            this.ClassworkIcon.Size = new System.Drawing.Size(35, 33);
            this.ClassworkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClassworkIcon.TabIndex = 35;
            this.ClassworkIcon.TabStop = false;
            // 
            // ClassworkCommentsBox
            // 
            this.ClassworkCommentsBox.AutoSize = true;
            this.ClassworkCommentsBox.Controls.Add(this.panel4);
            this.ClassworkCommentsBox.Controls.Add(this.ClassCommentPanel);
            this.ClassworkCommentsBox.Location = new System.Drawing.Point(5, 242);
            this.ClassworkCommentsBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassworkCommentsBox.Name = "ClassworkCommentsBox";
            this.ClassworkCommentsBox.Padding = new System.Windows.Forms.Padding(2);
            this.ClassworkCommentsBox.Size = new System.Drawing.Size(490, 174);
            this.ClassworkCommentsBox.TabIndex = 23;
            this.ClassworkCommentsBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 29);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Class Comments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Class Comments";
            // 
            // ClassCommentPanel
            // 
            this.ClassCommentPanel.Controls.Add(this.ClassCommentDescription);
            this.ClassCommentPanel.Controls.Add(this.ClassCommenterPersonName);
            this.ClassCommentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassCommentPanel.Location = new System.Drawing.Point(2, 18);
            this.ClassCommentPanel.Name = "ClassCommentPanel";
            this.ClassCommentPanel.Size = new System.Drawing.Size(486, 29);
            this.ClassCommentPanel.TabIndex = 0;
            // 
            // ClassCommentDescription
            // 
            this.ClassCommentDescription.AutoEllipsis = true;
            this.ClassCommentDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassCommentDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassCommentDescription.Location = new System.Drawing.Point(96, 0);
            this.ClassCommentDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassCommentDescription.Name = "ClassCommentDescription";
            this.ClassCommentDescription.Size = new System.Drawing.Size(388, 29);
            this.ClassCommentDescription.TabIndex = 46;
            this.ClassCommentDescription.Text = "Class Comments";
            // 
            // ClassCommenterPersonName
            // 
            this.ClassCommenterPersonName.AutoSize = true;
            this.ClassCommenterPersonName.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassCommenterPersonName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassCommenterPersonName.Location = new System.Drawing.Point(0, 0);
            this.ClassCommenterPersonName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassCommenterPersonName.Name = "ClassCommenterPersonName";
            this.ClassCommenterPersonName.Size = new System.Drawing.Size(96, 15);
            this.ClassCommenterPersonName.TabIndex = 45;
            this.ClassCommenterPersonName.Text = "Class Comments";
            // 
            // ClassworkTotalPoints
            // 
            this.ClassworkTotalPoints.AutoSize = true;
            this.ClassworkTotalPoints.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkTotalPoints.Location = new System.Drawing.Point(51, 70);
            this.ClassworkTotalPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassworkTotalPoints.Name = "ClassworkTotalPoints";
            this.ClassworkTotalPoints.Size = new System.Drawing.Size(65, 15);
            this.ClassworkTotalPoints.TabIndex = 33;
            this.ClassworkTotalPoints.Text = "100 Points";
            // 
            // ClassworkDeadlineLabel
            // 
            this.ClassworkDeadlineLabel.AutoSize = true;
            this.ClassworkDeadlineLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkDeadlineLabel.Location = new System.Drawing.Point(354, 56);
            this.ClassworkDeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassworkDeadlineLabel.Name = "ClassworkDeadlineLabel";
            this.ClassworkDeadlineLabel.Size = new System.Drawing.Size(132, 15);
            this.ClassworkDeadlineLabel.TabIndex = 32;
            this.ClassworkDeadlineLabel.Text = "yyyy-mm-dd hh:mm:ss";
            // 
            // ClassworkPersonWhoPosted
            // 
            this.ClassworkPersonWhoPosted.AutoSize = true;
            this.ClassworkPersonWhoPosted.Location = new System.Drawing.Point(120, 50);
            this.ClassworkPersonWhoPosted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassworkPersonWhoPosted.Name = "ClassworkPersonWhoPosted";
            this.ClassworkPersonWhoPosted.Size = new System.Drawing.Size(121, 15);
            this.ClassworkPersonWhoPosted.TabIndex = 31;
            this.ClassworkPersonWhoPosted.Text = "Assigment posted by ";
            // 
            // ClassworkDescription
            // 
            this.ClassworkDescription.Location = new System.Drawing.Point(7, 99);
            this.ClassworkDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassworkDescription.Name = "ClassworkDescription";
            this.ClassworkDescription.Size = new System.Drawing.Size(479, 108);
            this.ClassworkDescription.TabIndex = 30;
            this.ClassworkDescription.Text = "Assignment descriptiomn";
            // 
            // ClassworkTitleLabel
            // 
            this.ClassworkTitleLabel.AutoSize = true;
            this.ClassworkTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkTitleLabel.Location = new System.Drawing.Point(45, 15);
            this.ClassworkTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassworkTitleLabel.Name = "ClassworkTitleLabel";
            this.ClassworkTitleLabel.Size = new System.Drawing.Size(149, 32);
            this.ClassworkTitleLabel.TabIndex = 29;
            this.ClassworkTitleLabel.Text = "Assignment";
            // 
            // PrivateCommentTextBox
            // 
            this.PrivateCommentTextBox.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrivateCommentTextBox.Location = new System.Drawing.Point(553, 174);
            this.PrivateCommentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrivateCommentTextBox.Multiline = true;
            this.PrivateCommentTextBox.Name = "PrivateCommentTextBox";
            this.PrivateCommentTextBox.PlaceholderText = "Add a private comment to your teacher";
            this.PrivateCommentTextBox.Size = new System.Drawing.Size(218, 33);
            this.PrivateCommentTextBox.TabIndex = 50;
            // 
            // postprivatecomment
            // 
            this.postprivatecomment.BackColor = System.Drawing.Color.RoyalBlue;
            this.postprivatecomment.ForeColor = System.Drawing.SystemColors.Control;
            this.postprivatecomment.Location = new System.Drawing.Point(729, 211);
            this.postprivatecomment.Margin = new System.Windows.Forms.Padding(2);
            this.postprivatecomment.Name = "postprivatecomment";
            this.postprivatecomment.Size = new System.Drawing.Size(47, 22);
            this.postprivatecomment.TabIndex = 27;
            this.postprivatecomment.Text = "Post";
            this.postprivatecomment.UseVisualStyleBackColor = false;
            this.postprivatecomment.Click += new System.EventHandler(this.postprivatecomment_Click);
            // 
            // personicon
            // 
            this.personicon.Image = ((System.Drawing.Image)(resources.GetObject("personicon.Image")));
            this.personicon.InitialImage = null;
            this.personicon.Location = new System.Drawing.Point(515, 174);
            this.personicon.Margin = new System.Windows.Forms.Padding(0);
            this.personicon.Name = "personicon";
            this.personicon.Size = new System.Drawing.Size(36, 33);
            this.personicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personicon.TabIndex = 26;
            this.personicon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.CurrentClassName);
            this.panel2.Location = new System.Drawing.Point(11, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 62);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(17, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(48, 28);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(706, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(747, 26);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(-25, 26);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // CurrentClassName
            // 
            this.CurrentClassName.AutoSize = true;
            this.CurrentClassName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentClassName.Location = new System.Drawing.Point(70, 17);
            this.CurrentClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentClassName.Name = "CurrentClassName";
            this.CurrentClassName.Size = new System.Drawing.Size(109, 28);
            this.CurrentClassName.TabIndex = 2;
            this.CurrentClassName.Text = "Classroom";
            // 
            // ClassworkMarkAsDone
            // 
            this.ClassworkMarkAsDone.BackColor = System.Drawing.Color.Blue;
            this.ClassworkMarkAsDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkMarkAsDone.ForeColor = System.Drawing.Color.AliceBlue;
            this.ClassworkMarkAsDone.Location = new System.Drawing.Point(18, 75);
            this.ClassworkMarkAsDone.Margin = new System.Windows.Forms.Padding(2);
            this.ClassworkMarkAsDone.Name = "ClassworkMarkAsDone";
            this.ClassworkMarkAsDone.Size = new System.Drawing.Size(227, 30);
            this.ClassworkMarkAsDone.TabIndex = 5;
            this.ClassworkMarkAsDone.Text = "Mark as done";
            this.ClassworkMarkAsDone.UseVisualStyleBackColor = false;
            this.ClassworkMarkAsDone.Click += new System.EventHandler(this.ClassworkMarkAsDone_Click);
            // 
            // PrivateCommentsBox
            // 
            this.PrivateCommentsBox.AutoSize = true;
            this.PrivateCommentsBox.Controls.Add(this.panel6);
            this.PrivateCommentsBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrivateCommentsBox.Location = new System.Drawing.Point(518, 233);
            this.PrivateCommentsBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrivateCommentsBox.Name = "PrivateCommentsBox";
            this.PrivateCommentsBox.Padding = new System.Windows.Forms.Padding(2);
            this.PrivateCommentsBox.Size = new System.Drawing.Size(260, 195);
            this.PrivateCommentsBox.TabIndex = 22;
            this.PrivateCommentsBox.TabStop = false;
            this.PrivateCommentsBox.Enter += new System.EventHandler(this.pgroup_Enter);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(2, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(256, 29);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Private comment text...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Private";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.PrivateCommentTextBox);
            this.panel1.Controls.Add(this.postprivatecomment);
            this.panel1.Controls.Add(this.yourWorkPanel);
            this.panel1.Controls.Add(this.personicon);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.assignment);
            this.panel1.Controls.Add(this.PrivateCommentsBox);
            this.panel1.Location = new System.Drawing.Point(11, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 536);
            this.panel1.TabIndex = 1;
            // 
            // yourWorkPanel
            // 
            this.yourWorkPanel.Controls.Add(this.assignmentStatusLabel);
            this.yourWorkPanel.Controls.Add(this.label9);
            this.yourWorkPanel.Controls.Add(this.ClassworkMarkAsDone);
            this.yourWorkPanel.Controls.Add(this.ClassworkAddOrCreate);
            this.yourWorkPanel.Location = new System.Drawing.Point(518, 16);
            this.yourWorkPanel.Name = "yourWorkPanel";
            this.yourWorkPanel.Size = new System.Drawing.Size(269, 120);
            this.yourWorkPanel.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(18, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Your Work";
            // 
            // ClassworkAddOrCreate
            // 
            this.ClassworkAddOrCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassworkAddOrCreate.ForeColor = System.Drawing.Color.Blue;
            this.ClassworkAddOrCreate.Location = new System.Drawing.Point(18, 40);
            this.ClassworkAddOrCreate.Margin = new System.Windows.Forms.Padding(2);
            this.ClassworkAddOrCreate.Name = "ClassworkAddOrCreate";
            this.ClassworkAddOrCreate.Size = new System.Drawing.Size(227, 27);
            this.ClassworkAddOrCreate.TabIndex = 4;
            this.ClassworkAddOrCreate.Text = "Add or create";
            this.ClassworkAddOrCreate.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Privatecomment);
            this.panel5.Controls.Add(this.pictureBox10);
            this.panel5.Location = new System.Drawing.Point(515, 141);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 29);
            this.panel5.TabIndex = 38;
            // 
            // Privatecomment
            // 
            this.Privatecomment.AutoSize = true;
            this.Privatecomment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Privatecomment.Location = new System.Drawing.Point(38, 12);
            this.Privatecomment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Privatecomment.Name = "Privatecomment";
            this.Privatecomment.Size = new System.Drawing.Size(109, 15);
            this.Privatecomment.TabIndex = 2;
            this.Privatecomment.Text = "Private comments";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.InitialImage = null;
            this.pictureBox10.Location = new System.Drawing.Point(9, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(27, 27);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // ViewingClasswork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ViewingClasswork";
            this.Text = "ViewingClasswork";
            this.assignment.ResumeLayout(false);
            this.assignment.PerformLayout();
            this.Postcommentpanel.ResumeLayout(false);
            this.Postcommentpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personcommenticon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commenticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassworkIcon)).EndInit();
            this.ClassworkCommentsBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ClassCommentPanel.ResumeLayout(false);
            this.ClassCommentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personicon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PrivateCommentsBox.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.yourWorkPanel.ResumeLayout(false);
            this.yourWorkPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label assignmentStatusLabel;
        private GroupBox assignment;
        private Label ClassworkPostDateLabel;
        private PictureBox ClassworkIcon;
        private Label ClassworkTotalPoints;
        private Label ClassworkDeadlineLabel;
        private Label ClassworkPersonWhoPosted;
        private Label ClassworkDescription;
        private Label ClassworkTitleLabel;
        private TextBox PrivateCommentTextBox;
        private Button postprivatecomment;
        private PictureBox personicon;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label CurrentClassSection;
        private Label CurrentClassName;
        private Button ClassworkMarkAsDone;
        private GroupBox PrivateCommentsBox;
        private Panel panel1;
        private Panel panel5;
        private Label Privatecomment;
        private PictureBox pictureBox10;
        private Panel panel3;
        private Label label8;
        private PictureBox commenticon;
        private GroupBox ClassworkCommentsBox;
        private Button ClassworkAddOrCreate;
        private Label label9;
        private Panel Postcommentpanel;
        private Button postcommentbutton;
        private Label CurrentPersonEmail2;
        private RichTextBox ClassCommentTextBox;
        private PictureBox personcommenticon;
        private Panel ClassCommentPanel;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label ClassCommentDescription;
        private Label ClassCommenterPersonName;
        private Label label4;
        private Panel yourWorkPanel;
        private Label dueLabel;
        private PictureBox pictureBox1;
        private Button backButton;
        private Panel panel6;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}