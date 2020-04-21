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

        private void submit_Click(object sender, EventArgs e)
        {

            string query = "", query2 = "";
            string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 
            MySqlDataReader reader1, reader2;

            query = "SELECT ISSUED.B_id, Book.B_NAME, Book.B_AUTH, DATEDIFF(CURRENT_TIMESTAMP, ISSUED.DUE_DATE) * 6 AS Fine FROM ISSUED, Book where Book.B_id = ISSUED.B_ID" +
                " and DATEDIFF(CURRENT_TIMESTAMP, ISSUED.DUE_DATE) >= and ISSUED.S_ID = '" + studentId.Text + "'";


            try{ 
          MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            databaseConnection.Open();

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
