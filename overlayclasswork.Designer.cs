namespace lab10
{
    partial class overlayclasswork
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overlayclasswork));
            this.AssignmentButton = new System.Windows.Forms.Button();
            this.Materialbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignmentButton
            // 
            this.AssignmentButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AssignmentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AssignmentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AssignmentButton.Location = new System.Drawing.Point(55, 57);
            this.AssignmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.AssignmentButton.Name = "AssignmentButton";
            this.AssignmentButton.Size = new System.Drawing.Size(118, 33);
            this.AssignmentButton.TabIndex = 0;
            this.AssignmentButton.Text = "Assignment";
            this.AssignmentButton.UseVisualStyleBackColor = false;
            this.AssignmentButton.Click += new System.EventHandler(this.AssignmentButton_Click);
            // 
            // Materialbutton
            // 
            this.Materialbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Materialbutton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Materialbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Materialbutton.Location = new System.Drawing.Point(55, 94);
            this.Materialbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Materialbutton.Name = "Materialbutton";
            this.Materialbutton.Size = new System.Drawing.Size(118, 31);
            this.Materialbutton.TabIndex = 1;
            this.Materialbutton.Text = "Material";
            this.Materialbutton.UseVisualStyleBackColor = false;
            this.Materialbutton.Click += new System.EventHandler(this.Materialbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose classwork type:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.QuestionButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Materialbutton);
            this.panel1.Controls.Add(this.AssignmentButton);
            this.panel1.Location = new System.Drawing.Point(15, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 185);
            this.panel1.TabIndex = 3;
            // 
            // QuestionButton
            // 
            this.QuestionButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.QuestionButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuestionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.QuestionButton.Location = new System.Drawing.Point(55, 129);
            this.QuestionButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(118, 31);
            this.QuestionButton.TabIndex = 3;
            this.QuestionButton.Text = "Question";
            this.QuestionButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(15, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // overlayclasswork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 249);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "overlayclasswork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "overlayclasswork";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AssignmentButton;
        private Button Materialbutton;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Button QuestionButton;
    }
}