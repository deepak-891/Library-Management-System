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
            try
            {
               
                string query = "", query2 = "";
                string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 
                MySqlDataReader reader1, reader2;

                query = "SELECT ISSUED.B_ID , ISSUED.S_ID, ISSUED.ISSUE_DATE, ISSUED.DUE_DATE, Book.B_NAME, Book.B_AUTH FROM " +
                    "ISSUED,Book " +
                    "WHERE Book.B_id = ISSUED.B_ID and ISSUED.B_ID='" + bookId.Text + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
                databaseConnection.Open();
                reader1 = commandDatabase.ExecuteReader();
                String dueDate, student;
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {

                        student = reader1.GetString(1);
                        dueDate = reader1.GetString(3);
                        bookDetails.Text += "\nIssuing Student Id=" + reader1.GetString(1) +
                            "\nIssue Date " + reader1.GetString(2) +
                            "\nDue Date = " + reader1.GetString(3) +
                            "\nBook name= " + reader1.GetString(4) +
                            "\nBook Author= " + reader1.GetString(5);
                         ;
                    
                    }
                }
                else
                {
                    MessageBox.Show("No Such Book exist");
                }





                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2)
                {
                    CommandTimeout = 60
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }


    
}
