namespace Library_Management_System
{
    partial class Features
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
            this.label1 = new System.Windows.Forms.Label();
            this.issue = new System.Windows.Forms.LinkLabel();
            this.CheckFine = new System.Windows.Forms.LinkLabel();
            this.addStudent = new System.Windows.Forms.LinkLabel();
            this.returnBook = new System.Windows.Forms.LinkLabel();
            this.ReIssue = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(-84, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(350, 9, 350, 9);
            this.label1.Size = new System.Drawing.Size(843, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Features";
            // 
            // issue
            // 
            this.issue.ActiveLinkColor = System.Drawing.Color.White;
            this.issue.AutoSize = true;
            this.issue.BackColor = System.Drawing.Color.Lime;
            this.issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.LinkColor = System.Drawing.Color.Black;
            this.issue.Location = new System.Drawing.Point(75, 108);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(118, 25);
            this.issue.TabIndex = 1;
            this.issue.TabStop = true;
            this.issue.Text = "Issue Book";
            this.issue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CheckFine
            // 
            this.CheckFine.ActiveLinkColor = System.Drawing.Color.White;
            this.CheckFine.AutoSize = true;
            this.CheckFine.BackColor = System.Drawing.Color.Red;
            this.CheckFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckFine.LinkColor = System.Drawing.Color.White;
            this.CheckFine.Location = new System.Drawing.Point(75, 193);
            this.CheckFine.Name = "CheckFine";
            this.CheckFine.Size = new System.Drawing.Size(121, 25);
            this.CheckFine.TabIndex = 2;
            this.CheckFine.TabStop = true;
            this.CheckFine.Text = "Check Fine";
            this.CheckFine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckFine_LinkClicked);
            // 
            // addStudent
            // 
            this.addStudent.ActiveLinkColor = System.Drawing.Color.White;
            this.addStudent.AutoSize = true;
            this.addStudent.BackColor = System.Drawing.Color.Sienna;
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.LinkColor = System.Drawing.Color.White;
            this.addStudent.Location = new System.Drawing.Point(75, 277);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(130, 25);
            this.addStudent.TabIndex = 3;
            this.addStudent.TabStop = true;
            this.addStudent.Text = "Add Student";
            this.addStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addStudent_LinkClicked);
            // 
            // returnBook
            // 
            this.returnBook.ActiveLinkColor = System.Drawing.Color.White;
            this.returnBook.AutoSize = true;
            this.returnBook.BackColor = System.Drawing.Color.Aqua;
            this.returnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBook.LinkColor = System.Drawing.Color.Black;
            this.returnBook.Location = new System.Drawing.Point(408, 108);
            this.returnBook.Name = "returnBook";
            this.returnBook.Size = new System.Drawing.Size(131, 25);
            this.returnBook.TabIndex = 4;
            this.returnBook.TabStop = true;
            this.returnBook.Text = "Return Book";
            this.returnBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.returnBook_LinkClicked);
            // 
            // ReIssue
            // 
            this.ReIssue.ActiveLinkColor = System.Drawing.Color.White;
            this.ReIssue.AutoSize = true;
            this.ReIssue.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ReIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReIssue.LinkColor = System.Drawing.Color.SeaShell;
            this.ReIssue.Location = new System.Drawing.Point(408, 193);
            this.ReIssue.Name = "ReIssue";
            this.ReIssue.Size = new System.Drawing.Size(152, 25);
            this.ReIssue.TabIndex = 5;
            this.ReIssue.TabStop = true;
            this.ReIssue.Text = "Re-Issue Book";
            this.ReIssue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReIssue_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(408, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add Librarian";
            // 
            // Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library;
            this.ClientSize = new System.Drawing.Size(650, 415);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ReIssue);
            this.Controls.Add(this.returnBook);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.CheckFine);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Features";
            this.Text = "Features";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel issue;
        private System.Windows.Forms.LinkLabel CheckFine;
        private System.Windows.Forms.LinkLabel addStudent;
        private System.Windows.Forms.LinkLabel returnBook;
        private System.Windows.Forms.LinkLabel ReIssue;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}