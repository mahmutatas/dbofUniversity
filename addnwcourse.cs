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
    public partial class addnwcourse : Form
    {
        public addnwcourse()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");

        private void Adbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into course(course_id,title,dept_name,credits)", connection);
            command.Parameters.AddWithValue("@course_id", idBox.Text);
            command.Parameters.AddWithValue("@title", titleBox.Text);
            command.Parameters.AddWithValue("@dept_name", dptBox.Text);
            command.Parameters.AddWithValue("@credits", crdtBox.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Course Added!","System");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }
        }

        private void Btncncl_Click(object sender, EventArgs e) => Close();
    }
}
