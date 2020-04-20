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
            this.bookAuth = new System.Windows.Forms.TextBox();
            this.Authorlabel = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BookId = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
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
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
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
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
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
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // bookAuth
            // 
            this.bookAuth.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookAuth.Location = new System.Drawing.Point(622, 152);
            this.bookAuth.Name = "bookAuth";
            this.bookAuth.Size = new System.Drawing.Size(177, 20);
            this.bookAuth.TabIndex = 23;
            // 
            // Authorlabel
            // 
            this.Authorlabel.AutoSize = true;
            this.Authorlabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Authorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorlabel.Location = new System.Drawing.Point(434, 152);
            this.Authorlabel.Name = "Authorlabel";
            this.Authorlabel.Size = new System.Drawing.Size(98, 20);
            this.Authorlabel.TabIndex = 22;
            this.Authorlabel.Text = "Book Author";
            // 
            // bookName
            // 
            this.bookName.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookName.Location = new System.Drawing.Point(210, 152);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(177, 20);
            this.bookName.TabIndex = 21;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(22, 152);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 20);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "Book Name ";
            // 
            // BookId
            // 
            this.BookId.BackColor = System.Drawing.Color.LavenderBlush;
            this.BookId.Location = new System.Drawing.Point(424, 86);
            this.BookId.Name = "BookId";
            this.BookId.Size = new System.Drawing.Size(177, 20);
            this.BookId.TabIndex = 19;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(236, 86);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(67, 20);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "Book ID";
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
            this.Controls.Add(this.bookAuth);
            this.Controls.Add(this.Authorlabel);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BookId);
            this.Controls.Add(this.idLabel);
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
        private System.Windows.Forms.TextBox bookAuth;
        private System.Windows.Forms.Label Authorlabel;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox BookId;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}