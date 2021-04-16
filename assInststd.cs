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
    public partial class assInststd : Form
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");

        public assInststd()
        {
            InitializeComponent();
        }

        private void AdBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into instructor(id)", connection);
            SQLiteCommand command2 = new SQLiteCommand("insert into student(id)", connection);

            command.Parameters.AddWithValue("@id", instIdBox.Text);
            command2.Parameters.AddWithValue("@id", stdIdBox.Text);
            
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
