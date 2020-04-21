using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ReIssue : Form
    {
        

        public ReIssue()
        {
            InitializeComponent();
        }

        public ReIssue(string studentId)
        {
            InitializeComponent();
            StudentId.Text = studentId;
        }

        private void submit_Click(object sender, EventArgs e)
        {

            try{ 
            string query = "", query2 = "";
            string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 
            MySqlDataReader reader1, reader2;

            query = "SELECT ISSUED.B_ID , ISSUED.S_ID, ISSUED.ISSUE_DATE, ISSUED.DUE_DATE, " +
                "Book.B_NAME, Book.B_AUTH," +
                " DATEDIFF( CURRENT_TIMESTAMP, ISSUED.DUE_DATE) AS DateDiff, Student.S_id, Student.S_name" +
                ",S_mobile,S_email FROM ISSUED,Book,Student " +
                "WHERE Book.B_id = ISSUED.B_ID and " +
                "ISSUED.B_ID='" + bookId.Text + "' and ISSUED.S_ID='"+ StudentId.Text +"' and Student.S_id= ISSUED.S_ID";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            databaseConnection.Open();
            reader1 = commandDatabase.ExecuteReader();
            String delay = "", student = "";
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {

                    student = reader1.GetString(1);
                    bookDetails.Text += "\nIssuing Student Id=" + reader1.GetString(1) +
                        "\nIssue Date " + reader1.GetString(2) +
                        "\nDue Date = " + reader1.GetString(3) +
                        "\nBook name= " + reader1.GetString(4) +
                        "\nBook Author= " + reader1.GetString(5);
                    studentDetails.Text += "\nName= " + reader1.GetString(8) + "\nMobile Number= "
                        + reader1.GetString(9) + "\nEmail= " + reader1.GetString(10);
                        ;
                    delay = reader1.GetString(6);
                }
                int dif = Int16.Parse(delay);


                    if (dif > 0)
                    {

                        MessageBox.Show("Can't Reissue the Book as it has already been on due date");

                    }
                    else
                    {


                    String query3 = "Update ISSUED Set Due_Date= ADDTIME(CURRENT_TIMESTAMP, \"28 0:00:0\") where b_id='"+bookId.Text+"'";

                    MySqlConnection databaseConnection3 = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase3 = new MySqlCommand(query3, databaseConnection3)
                    {
                        CommandTimeout = 60
                    };
                    databaseConnection3.Open();
                    commandDatabase3.ExecuteNonQuery();
                    databaseConnection3.Close();
                    MessageBox.Show("Book has reissued for 28 day from  today");
                     databaseConnection3.Open();

                    }
                }

            else
            {
                MessageBox.Show("No Such Book exist");
            }

            databaseConnection.Close();





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

        private void Clear_Click(object sender, EventArgs e)
        {
            StudentId.Text = "";
            bookId.Text = "";
            studentDetails.Text = "Student Details";
            bookDetails.Text = "Book Details";
        }
    }
}
