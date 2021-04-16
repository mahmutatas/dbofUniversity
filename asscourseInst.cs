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
    public partial class asscourseInst : Form
    {

        public asscourseInst()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");
        private void AdBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into instructor(id)", connection);
            SQLiteCommand command2 = new SQLiteCommand("insert into section(course_id,sec_id,semester,year)", connection);

            command.Parameters.AddWithValue("@id", instIdBox.Text);
            command2.Parameters.AddWithValue("@course_id", courseIdBox.Text);
            command2.Parameters.AddWithValue("@sec_id", sec_idBox.Text);
            command2.Parameters.AddWithValue("@semester", semesterBox.Text);
            command2.Parameters.AddWithValue("@year", yearBox.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Assign successfully!","System");
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
