using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityDatabaseApp
{
    public partial class addnwstudent : Form
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");

        public addnwstudent()
        {
            InitializeComponent();
        }

        private void AdBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into student(id,name,dept_name,tot_cred)", connection);
            command.Parameters.AddWithValue("@id", idBox.Text);
            command.Parameters.AddWithValue("@name", nmBox.Text);
            command.Parameters.AddWithValue("@dept_name", deptBox.Text);
            command.Parameters.AddWithValue("@tot_cred", totcredBox.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Student Added!","System");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }
        }

        private void CnclBtn_Click(object sender, EventArgs e) => Close();
    }
}
