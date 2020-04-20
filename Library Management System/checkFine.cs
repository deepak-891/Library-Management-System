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
    public partial class checkFine : Form
    {
        private string studentId1;

        public checkFine()
        {
            InitializeComponent();
        }

        public checkFine(string studentId1)
        {
            this.studentId1 = studentId1;
        }
    }
}
