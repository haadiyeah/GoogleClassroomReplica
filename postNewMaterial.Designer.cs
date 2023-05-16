
using System.Drawing;
using System.Windows.Forms;

namespace lab10
{
    partial class postNewMaterial
    {
    //     <summary>
    //     Required designer variable.
    //     </summary>
    private System.ComponentModel.IContainer components = null;

    //     <summary>
    //     Clean up any resources being used.
    //     </summary>
    //     <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(postNewMaterial));
            this.Assignbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Assignbutton
            // 
            this.Assignbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Assignbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Assignbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Assignbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Assignbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Assignbutton.Location = new System.Drawing.Point(495, 14);
            this.Assignbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Assignbutton.Name = "Assignbutton";
            this.Assignbutton.Size = new System.Drawing.Size(94, 40);
            this.Assignbutton.TabIndex = 16;
            this.Assignbutton.Text = "Upload";
            this.Assignbutton.UseVisualStyleBackColor = false;
            this.Assignbutton.Click += new System.EventHandler(this.Assignbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Material";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Assignbutton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 64);
            this.panel3.TabIndex = 12;
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleBox.Location = new System.Drawing.Point(10, 25);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.PlaceholderText = "Enter title..";
            this.TitleBox.Size = new System.Drawing.Size(308, 32);
            this.TitleBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Filebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.instruction);
            this.panel1.Controls.Add(this.TitleBox);
            this.panel1.Location = new System.Drawing.Point(124, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 286);
            this.panel1.TabIndex = 11;
            // 
            // Filebutton
            // 
            this.Filebutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Filebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Filebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filebutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Filebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filebutton.Location = new System.Drawing.Point(34, 181);
            this.Filebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Filebutton.Name = "Filebutton";
            this.Filebutton.Size = new System.Drawing.Size(252, 39);
            this.Filebutton.TabIndex = 20;
            this.Filebutton.Text = "Upload File";
            this.Filebutton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Attachment";
            // 
            // instruction
            // 
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instruction.Location = new System.Drawing.Point(10, 86);
            this.instruction.Margin = new System.Windows.Forms.Padding(2);
            this.instruction.Name = "instruction";
            this.instruction.PlaceholderText = "Enter Description..";
            this.instruction.Size = new System.Drawing.Size(308, 23);
            this.instruction.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(22, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // postNewMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 416);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "postNewMaterial";
            this.Text = "Creatematerial";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion
            private Button Assignbutton;
            private Label label3;
            private Panel panel3;
            private TextBox TitleBox;
            private Panel panel1;
            private Button Filebutton;
            private Label label1;
            private TextBox instruction;
        private Button button1;
    }
    }