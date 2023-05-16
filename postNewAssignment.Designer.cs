
using System.Drawing;
using System.Windows.Forms;

namespace lab10
{
    partial class postNewAssignment
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
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(postNewAssignment));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Filebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Assignbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeadlineBox = new System.Windows.Forms.MaskedTextBox();
            this.Rubricbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pointBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deadline";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.Filebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TitleBox);
            this.panel1.Location = new System.Drawing.Point(17, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 258);
            this.panel1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter description ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 69);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 115);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Filebutton
            // 
            this.Filebutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Filebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Filebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filebutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Filebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filebutton.Location = new System.Drawing.Point(10, 214);
            this.Filebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Filebutton.Name = "Filebutton";
            this.Filebutton.Size = new System.Drawing.Size(101, 32);
            this.Filebutton.TabIndex = 8;
            this.Filebutton.Text = "File";
            this.Filebutton.UseVisualStyleBackColor = false;
            this.Filebutton.Click += new System.EventHandler(this.Filebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attachment";
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleBox.Location = new System.Drawing.Point(10, 13);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.PlaceholderText = "Title";
            this.TitleBox.Size = new System.Drawing.Size(308, 32);
            this.TitleBox.TabIndex = 12;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Assignbutton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 62);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(15, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Assignbutton
            // 
            this.Assignbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Assignbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Assignbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Assignbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Assignbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Assignbutton.Location = new System.Drawing.Point(503, 13);
            this.Assignbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Assignbutton.Name = "Assignbutton";
            this.Assignbutton.Size = new System.Drawing.Size(94, 35);
            this.Assignbutton.TabIndex = 16;
            this.Assignbutton.Text = "Assign";
            this.Assignbutton.UseVisualStyleBackColor = false;
            this.Assignbutton.Click += new System.EventHandler(this.Assignbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Create new Assignment";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Points";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DeadlineBox);
            this.panel2.Controls.Add(this.Rubricbutton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pointBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(360, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 258);
            this.panel2.TabIndex = 10;
            // 
            // DeadlineBox
            // 
            this.DeadlineBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeadlineBox.Location = new System.Drawing.Point(11, 37);
            this.DeadlineBox.Mask = "0000-00-00 00:00:00";
            this.DeadlineBox.Name = "DeadlineBox";
            this.DeadlineBox.Size = new System.Drawing.Size(157, 27);
            this.DeadlineBox.TabIndex = 21;
            this.DeadlineBox.ValidatingType = typeof(System.DateTime);
            // 
            // Rubricbutton
            // 
            this.Rubricbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Rubricbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Rubricbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rubricbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rubricbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rubricbutton.Location = new System.Drawing.Point(11, 207);
            this.Rubricbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Rubricbutton.Name = "Rubricbutton";
            this.Rubricbutton.Size = new System.Drawing.Size(88, 38);
            this.Rubricbutton.TabIndex = 16;
            this.Rubricbutton.Text = "Rubric";
            this.Rubricbutton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rubric";
            // 
            // pointBox
            // 
            this.pointBox.Location = new System.Drawing.Point(11, 107);
            this.pointBox.Margin = new System.Windows.Forms.Padding(2);
            this.pointBox.Name = "pointBox";
            this.pointBox.PlaceholderText = "100";
            this.pointBox.Size = new System.Drawing.Size(157, 23);
            this.pointBox.TabIndex = 16;
            // 
            // postNewAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 416);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "postNewAssignment";
            this.Text = "CreateClasswork";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private Panel panel1;
        private TextBox TitleBox;
        private Panel panel3;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button Filebutton;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private Button Assignbutton;
        private Label label6;
        private TextBox pointBox;
        private Button Rubricbutton;
        private MaskedTextBox DeadlineBox;
        private Label label7;
        private Button button1;
    }
    #endregion
}