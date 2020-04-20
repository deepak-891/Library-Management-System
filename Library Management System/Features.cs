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
    public partial class Features : Form
    {
        public Features()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IssueBook issue = new IssueBook();
            issue.Show();
        }

        private void returnBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            returnBook retrn= new returnBook();
            retrn.Show();
        }

        private void CheckFine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkFine chk = new checkFine();
            chk.Show();
        }

        private void ReIssue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReIssue reis = new ReIssue();
            reis.Show();
        }

        private void addStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addStudent add = new addStudent();
            add.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
