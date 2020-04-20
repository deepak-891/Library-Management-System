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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        
        private void Login_Click(object sender, EventArgs e)
        {
            if (Username.Text != null && Username.Text != "" && Password.Text != null && Password.Text != "" && loginAs.SelectedItem!= "None")
            {
                String user, pass;
                user = Username.Text;
                pass = Password.Text;
                string connectionString = "datasource=remotemysql.com;port=3306;username=4PWYWxK833;password=kcyuAYHJX7;database=4PWYWxK833;";                // using the code here... 


                string query="";
                if (loginAs.SelectedIndex == 2) { 
                 query = "SELECT * FROM Student_login where S_id='" + user + "' and PASSWORD='"+ pass+"'";
                }
                else if(loginAs.SelectedIndex == 1)
                {
                    query = "SELECT * FROM ADMIN_login where A_id='" + user + "' and PASSWORD='" + pass + "'";

                }

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand( query, databaseConnection)
                {
                    CommandTimeout = 60
                };
                MySqlDataReader reader;


                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (loginAs.SelectedIndex == 1)
                        {
                            this.Close();

                            Form f1 = new Features();
                            f1.ShowDialog();
                            databaseConnection.Close();

                        }
                        else if(loginAs.SelectedIndex == 2)
                        {
                            this.Close();

                            Form f1 = new StudentFeatures(user);
                            f1.ShowDialog();
                            databaseConnection.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Check Credential");
                    }
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Please Enter Va;id Username and password");
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
