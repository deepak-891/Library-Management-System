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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            StudentId.Text = "";
            bookId.Text = "";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string b_id = bookId.Text;
            string s_id = StudentId.Text;
            DateTime now = System.DateTime.Now.Date;
            DateTime next= new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, now.Day); ;
            string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 
            string query = "Select * from ISSUED where B_id='"+b_id+"'";
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
                    reader.Close();
                    string query2 = "Insert Into ISSUED Values('" + s_id + "','" + b_id + "','"+ now.Date.ToString("yyyy-MM-dd") +"','"+ next.Date.ToString("yyyy-MM-dd") + "')";
                    string query3 = "Select S_name,Fine from Student where S_id='" + s_id + "'";
                    string query4 = "Select B_NAME from Book where B_id='" + b_id + "'";
                    
                    commandDatabase = new MySqlCommand(query3, databaseConnection)
                    {
                        CommandTimeout = 60
                    };
                    reader= commandDatabase.ExecuteReader();
                    reader.Read();
                    int fine = Convert.ToInt32(reader.GetValue(1).ToString());
                    studentDetails.Text = "Student Name: " + reader.GetValue(0).ToString()+" Fine: "+fine;
                    reader.Close();
                    commandDatabase = new MySqlCommand(query4, databaseConnection)
                    {
                        CommandTimeout = 60
                    };
                    reader = commandDatabase.ExecuteReader();
                    reader.Read();
                    bookDetails .Text = "Book Name: " + reader.GetValue(0).ToString();
                    reader.Close();
                    if (fine <= 0)
                    {
                        commandDatabase = new MySqlCommand(query2, databaseConnection)
                        {
                            CommandTimeout = 60
                        };
                        reader = commandDatabase.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Book Issued Successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Some Error occured.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cant issue book Beacause, the student has fine of Rs. " + fine);
                    }

                   
                }
                else
                {
                    MessageBox.Show("Book ALready issued");
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
