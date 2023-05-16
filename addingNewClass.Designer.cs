using System.Windows.Forms;

namespace lab10
{
    partial class addingNewClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterClassSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.createNewClass = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.classDesc = new System.Windows.Forms.TextBox();
            this.enterRoom = new System.Windows.Forms.TextBox();
            this.section = new System.Windows.Forms.TextBox();
            this.enterClassName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.enterClassSubject);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.createNewClass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.classDesc);
            this.panel1.Controls.Add(this.enterRoom);
            this.panel1.Controls.Add(this.section);
            this.panel1.Controls.Add(this.enterClassName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(188, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 403);
            this.panel1.TabIndex = 13;
            // 
            // enterClassSubject
            // 
            this.enterClassSubject.Location = new System.Drawing.Point(147, 130);
            this.enterClassSubject.Name = "enterClassSubject";
            this.enterClassSubject.PlaceholderText = "Enter Class Subject";
            this.enterClassSubject.Size = new System.Drawing.Size(285, 23);
            this.enterClassSubject.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Class Subject";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(253, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // createNewClass
            // 
            this.createNewClass.BackColor = System.Drawing.Color.RoyalBlue;
            this.createNewClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewClass.ForeColor = System.Drawing.Color.GhostWhite;
            this.createNewClass.Location = new System.Drawing.Point(106, 334);
            this.createNewClass.Name = "createNewClass";
            this.createNewClass.Size = new System.Drawing.Size(127, 43);
            this.createNewClass.TabIndex = 23;
            this.createNewClass.Text = "Create";
            this.createNewClass.UseVisualStyleBackColor = false;
            this.createNewClass.Click += new System.EventHandler(this.createNewClass_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(379, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "*required";
            // 
            // classDesc
            // 
            this.classDesc.Location = new System.Drawing.Point(147, 265);
            this.classDesc.Name = "classDesc";
            this.classDesc.PlaceholderText = "Enter a short description";
            this.classDesc.Size = new System.Drawing.Size(285, 23);
            this.classDesc.TabIndex = 21;
            // 
            // enterRoom
            // 
            this.enterRoom.Location = new System.Drawing.Point(147, 222);
            this.enterRoom.Name = "enterRoom";
            this.enterRoom.PlaceholderText = "Enter the room, if applicable";
            this.enterRoom.Size = new System.Drawing.Size(285, 23);
            this.enterRoom.TabIndex = 20;
            // 
            // section
            // 
            this.section.Location = new System.Drawing.Point(147, 177);
            this.section.Name = "section";
            this.section.PlaceholderText = "Enter the section";
            this.section.Size = new System.Drawing.Size(285, 23);
            this.section.TabIndex = 19;
            // 
            // enterClassName
            // 
            this.enterClassName.Location = new System.Drawing.Point(147, 80);
            this.enterClassName.Name = "enterClassName";
            this.enterClassName.PlaceholderText = "Enter class name (Required)";
            this.enterClassName.Size = new System.Drawing.Size(285, 23);
            this.enterClassName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Class name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 47);
            this.label2.TabIndex = 13;
            this.label2.Text = "Create new Classroom";
            // 
            // addingNewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 449);
            this.Controls.Add(this.panel1);
            this.Name = "addingNewClass";
            this.Text = "Create new class";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button createNewClass;
        private Label label6;
        private TextBox classDesc;
        private TextBox enterRoom;
        private TextBox section;
        private TextBox enterClassName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label7;
        private TextBox enterClassSubject;
    }
}

