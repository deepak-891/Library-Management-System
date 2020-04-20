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
    public partial class returnBook : Form
    {
        public returnBook()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            bookId.Text = "";
            bookDetails.Text = "Book Details";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 


            string query = "Select * from ISSUED where B_ID='"+ bookId.Text+"'";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);


            MySqlDataReader reader,reader1;


            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };

            try
            {
                databaseConnection.Open();
                reader1 = commandDatabase.ExecuteReader();
                if (reader1.HasRows)
                {
                    databaseConnection.Close();

                    databaseConnection.Open();
                    reader1.Close();
                    query = "Select * from book where B_id='" + bookId.Text + "';";
                      
                     reader = commandDatabase.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        bookDetails.Text += "\n Book Name = " + reader.GetString(1) + "\n AutherName= " + reader.GetString(2);
                    }
                    reader.Close();
                    databaseConnection.Close();

                    databaseConnection.Open();

                    query = "Delete From ISSUED Where B_id='" + bookId.Text + "'";

                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Book has been returned securely");
                }
                else
                {
                    MessageBox.Show("This Book is Never Been Issued aur Doesn't Exist");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
