namespace Library_Management_System
{
    partial class addBook
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
            this.mobile = new System.Windows.Forms.TextBox();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Clear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(390, 286);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(99, 52);
            this.Clear.TabIndex = 32;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(585, 292);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 46);
            this.Exit.TabIndex = 31;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(174, 286);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(105, 52);
            this.submit.TabIndex = 30;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // mobile
            // 
            this.mobile.BackColor = System.Drawing.Color.LavenderBlush;
            this.mobile.Location = new System.Drawing.Point(622, 152);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(177, 20);
            this.mobile.TabIndex = 23;
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthor.Location = new System.Drawing.Point(434, 152);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(98, 20);
            this.bookAuthor.TabIndex = 22;
            this.bookAuthor.Text = "Book Author";
            // 
            // studentName
            // 
            this.studentName.BackColor = System.Drawing.Color.LavenderBlush;
            this.studentName.Location = new System.Drawing.Point(210, 152);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(177, 20);
            this.studentName.TabIndex = 21;
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(22, 152);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(96, 20);
            this.bookName.TabIndex = 20;
            this.bookName.Text = "Book Name ";
            // 
            // StudentId
            // 
            this.StudentId.BackColor = System.Drawing.Color.LavenderBlush;
            this.StudentId.Location = new System.Drawing.Point(424, 86);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(177, 20);
            this.StudentId.TabIndex = 19;
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid.Location = new System.Drawing.Point(236, 86);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(67, 20);
            this.bookid.TabIndex = 18;
            this.bookid.Text = "Book ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(-16, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(350, 9, 350, 9);
            this.label1.Size = new System.Drawing.Size(857, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Book";
            // 
            // addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.library;
            this.ClientSize = new System.Drawing.Size(834, 384);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.label1);
            this.Name = "addBook";
            this.Text = "addBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}