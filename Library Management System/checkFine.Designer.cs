﻿namespace Library_Management_System
{
    partial class checkFine
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
            this.addStudent = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.studentId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.ActiveLinkColor = System.Drawing.Color.White;
            this.addStudent.AutoSize = true;
            this.addStudent.BackColor = System.Drawing.Color.Transparent;
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.LinkColor = System.Drawing.Color.White;
            this.addStudent.Location = new System.Drawing.Point(140, 276);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(0, 25);
            this.addStudent.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(-29, -4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(350, 9, 350, 9);
            this.label1.Size = new System.Drawing.Size(878, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fine Check";
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Thistle;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkColor = System.Drawing.Color.Black;
            this.linkLabel5.Location = new System.Drawing.Point(55, 86);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(112, 25);
            this.linkLabel5.TabIndex = 21;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Student ID";
            // 
            // studentId
            // 
            this.studentId.Location = new System.Drawing.Point(216, 86);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(168, 20);
            this.studentId.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 311);
            this.dataGridView1.TabIndex = 23;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(671, 62);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 46);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "Back";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(461, 62);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(105, 52);
            this.submit.TabIndex = 24;
            this.submit.Text = "Check";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // checkFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.label1);
            this.Name = "checkFine";
            this.Text = "Check fine";
            this.Load += new System.EventHandler(this.checkFine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel addStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button submit;
    }
}