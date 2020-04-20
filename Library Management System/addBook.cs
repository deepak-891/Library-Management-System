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
    public partial class addBook : Form
    {
        public addBook()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String B_id = BookId.Text;
            String B_name = bookName.Text;
            String B_auth = bookAuth.Text;
            string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 
            string query = "Insert Into Book Values('" + B_id + "','" + B_name + "','" + B_auth + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Book Added Successfully.");
                }
                else
                {
                    MessageBox.Show("Some Error occured.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            BookId.Text = "";
            bookAuth.Text = "";
            bookName.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
