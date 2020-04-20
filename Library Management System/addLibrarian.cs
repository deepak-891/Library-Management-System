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
    public partial class addLibrarian : Form
    {
        public addLibrarian()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String S_id = StudentId.Text;
            String S_name = studentName.Text;
            String eml = email.Text;
            String Pswd = password.Text;
            String add = address.Text;
            String mbl = mobile.Text;
            string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 
            string query = "Insert Into ADMIN Values('" + S_id + "','" + S_name + "'," + Convert.ToInt64(mbl) + ",'" + eml + "','" + add + "')";
            string query2 = "Insert Into ADMIN_login Values('" + S_id + "','" + Pswd + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2)
            {
                CommandTimeout = 60
            };
            MySqlDataReader reader1, reader2;

            try
            {
                databaseConnection.Open();
                databaseConnection2.Open();
                reader1 = commandDatabase.ExecuteReader();
                reader2 = commandDatabase2.ExecuteReader();
                if (!reader1.HasRows && !reader2.HasRows)
                {
                    MessageBox.Show("Admin Added Successfully.");
                }
                else
                {
                    MessageBox.Show("Some Error occured.");
                }
                databaseConnection.Close();
                databaseConnection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            StudentId.Text = "";
            studentName.Text = "";
            email.Text = "";
            mobile.Text = "";
            address.Text = "";
            password.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
