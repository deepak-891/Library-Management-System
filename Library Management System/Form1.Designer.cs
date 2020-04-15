namespace Library_Management_System
{
    partial class StudentFeatures
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
            this.ReIssue = new System.Windows.Forms.LinkLabel();
            this.addStudent = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(-30, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(350, 9, 350, 9);
            this.label1.Size = new System.Drawing.Size(843, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Features";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // issue
            // 
            this.issue.ActiveLinkColor = System.Drawing.Color.White;
            this.issue.AutoSize = true;
            this.issue.BackColor = System.Drawing.Color.Transparent;
            this.issue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.LinkColor = System.Drawing.Color.Red;
            this.issue.Location = new System.Drawing.Point(138, 97);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(135, 24);
            this.issue.TabIndex = 7;
            this.issue.TabStop = true;
            this.issue.Text = "Issued Book";
            // 
            // CheckFine
            // 
            this.CheckFine.ActiveLinkColor = System.Drawing.Color.White;
            this.CheckFine.AutoSize = true;
            this.CheckFine.BackColor = System.Drawing.Color.Transparent;
            this.CheckFine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckFine.LinkColor = System.Drawing.Color.White;
            this.CheckFine.Location = new System.Drawing.Point(138, 182);
            this.CheckFine.Name = "CheckFine";
            this.CheckFine.Size = new System.Drawing.Size(124, 24);
            this.CheckFine.TabIndex = 8;
            this.CheckFine.TabStop = true;
            this.CheckFine.Text = "Check Fine";
            // 
            // ReIssue
            // 
            this.ReIssue.ActiveLinkColor = System.Drawing.Color.White;
            this.ReIssue.AutoSize = true;
            this.ReIssue.BackColor = System.Drawing.Color.Transparent;
            this.ReIssue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReIssue.LinkColor = System.Drawing.Color.White;
            this.ReIssue.Location = new System.Drawing.Point(425, 97);
            this.ReIssue.Name = "ReIssue";
            this.ReIssue.Size = new System.Drawing.Size(154, 24);
            this.ReIssue.TabIndex = 11;
            this.ReIssue.TabStop = true;
            this.ReIssue.Text = "Re Issue Book";
            // 
            // addStudent
            // 
            this.addStudent.ActiveLinkColor = System.Drawing.Color.White;
            this.addStudent.AutoSize = true;
            this.addStudent.BackColor = System.Drawing.Color.Transparent;
            this.addStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.LinkColor = System.Drawing.Color.White;
            this.addStudent.Location = new System.Drawing.Point(138, 266);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(0, 24);
            this.addStudent.TabIndex = 9;
            // 
            // StudentFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 417);
            this.Controls.Add(this.ReIssue);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.CheckFine);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.label1);
            this.Name = "StudentFeatures";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel issue;
        private System.Windows.Forms.LinkLabel CheckFine;
        private System.Windows.Forms.LinkLabel ReIssue;
        private System.Windows.Forms.LinkLabel addStudent;
    }
}