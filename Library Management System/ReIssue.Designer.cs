namespace Library_Management_System
{
    partial class ReIssue
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
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.bookDetails = new System.Windows.Forms.Label();
            this.studentDetails = new System.Windows.Forms.Label();
            this.bookId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Clear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(554, 383);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(99, 52);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(312, 389);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 46);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(96, 383);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(105, 52);
            this.submit.TabIndex = 27;
            this.submit.Text = "Re-Issue Book";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // bookDetails
            // 
            this.bookDetails.AutoSize = true;
            this.bookDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDetails.Location = new System.Drawing.Point(502, 166);
            this.bookDetails.Name = "bookDetails";
            this.bookDetails.Size = new System.Drawing.Size(99, 20);
            this.bookDetails.TabIndex = 26;
            this.bookDetails.Text = "Book Details";
            // 
            // studentDetails
            // 
            this.studentDetails.AutoSize = true;
            this.studentDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.studentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDetails.Location = new System.Drawing.Point(82, 166);
            this.studentDetails.Name = "studentDetails";
            this.studentDetails.Size = new System.Drawing.Size(119, 20);
            this.studentDetails.TabIndex = 25;
            this.studentDetails.Text = "Student Details";
            // 
            // bookId
            // 
            this.bookId.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookId.Location = new System.Drawing.Point(536, 95);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(177, 20);
            this.bookId.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Book Id";
            // 
            // StudentId
            // 
            this.StudentId.BackColor = System.Drawing.Color.LavenderBlush;
            this.StudentId.Location = new System.Drawing.Point(147, 95);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(177, 20);
            this.StudentId.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(-37, -3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(350, 9, 350, 9);
            this.label1.Size = new System.Drawing.Size(922, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = "Re-issue Book";
            // 
            // ReIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.bookDetails);
            this.Controls.Add(this.studentDetails);
            this.Controls.Add(this.bookId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReIssue";
            this.Text = "Library management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label bookDetails;
        private System.Windows.Forms.Label studentDetails;
        private System.Windows.Forms.TextBox bookId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}