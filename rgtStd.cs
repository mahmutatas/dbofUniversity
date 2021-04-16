using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UniversityDatabaseApp
{
    public partial class rgtStd : Form
    {
        public rgtStd()
        {
            InitializeComponent();
        }

        private void CnclBtn_Click(object sender, EventArgs e) => Close();

        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");
        private void RgtBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into takes(std_id,course_id,sec_id,semester,year)", connection);
            command.Parameters.AddWithValue("@std_id", stdIdBox.Text);
            command.Parameters.AddWithValue("@course_id", courseIdBox.Text);
            command.Parameters.AddWithValue("@sec_id", sec_idBox.Text);
            command.Parameters.AddWithValue("@semester", semesterBox.Text);
            command.Parameters.AddWithValue("@year", yearBox.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Student has been registered!","System");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }

        }
    }
}
