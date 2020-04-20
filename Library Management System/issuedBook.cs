using MySql.Data.MySqlClient;
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
    public partial class issuedBook : Form
    {
        private string studentId1;

        public issuedBook()
        {
            InitializeComponent();
        }

        public issuedBook(string studentId1)
        {
            this.studentId1 = studentId1;
            InitializeComponent();
            this.studentId.Text = studentId1;
        }


        private void submit_Click(object sender, EventArgs e)
        {

            string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 

            String query = "Select * from ADMIN";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };

            try
            {
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = commandDatabase;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            dataGridView1.DataSource = bSource;
            sda.Update(dbdataset);

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }   


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
