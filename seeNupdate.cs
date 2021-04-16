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
    public partial class seeNupdate : Form
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");
        DataSet dataSet = new DataSet();
        public seeNupdate()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("update perDetStd set id =@id, name=@name, age=@age, phone=@phone, adress = @adress ", connection);
            command.Parameters.AddWithValue("@id", idBox.Text);
            command.Parameters.AddWithValue("@name", nameBox.Text);
            command.Parameters.AddWithValue("@age", ageBox.Text);
            command.Parameters.AddWithValue("@phone", phoneBox.Text);
            command.Parameters.AddWithValue("@adress", adressBox.Text);
            command.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["perDetStd"].Clear();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("Select * from perDetStd where id like '" + idBox.Text + "%' ", connection);
            dataAdapter.Fill(dataSet, "perDetStd");
            MessageBox.Show("Informations are updated!", "System");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("Select * from perDetStd where id like '" + idBox.Text + "%' ", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idBox.Text = reader["id"].ToString();
                nameBox.Text = reader["name"].ToString();
                ageBox.Text = reader["age"].ToString();
                phoneBox.Text = reader["phone"].ToString();
                adressBox.Text = reader["adress"].ToString();
            }
            connection.Close();
        }

        private void cnclbtn_Click(object sender, EventArgs e) => Close();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
