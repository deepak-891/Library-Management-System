using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class StudentFeatures : Form
    {
        private string studentId;

        public StudentFeatures()
        {
            InitializeComponent();
        }

        public StudentFeatures(string user)
        {
            InitializeComponent();
            this.studentId = user;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

      }

        private void issue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            issuedBook issued = new issuedBook(studentId);
            issued.Show();
        }

        private void ReIssue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReIssue reis = new ReIssue(studentId);
            reis.Show();
        }

        private void CheckFine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkFine check = new checkFine(studentId);
            check.Show();
        }
    }
}
