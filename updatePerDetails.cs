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
    public partial class updatePerDetails : Form
    {
        public updatePerDetails()
        {
            InitializeComponent();
        }
        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");
        DataSet dataSet = new DataSet();

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("Select * from perDetInst where id like '" + idBox.Text + "%' ", connection);
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("update perDetInst set id =@id, name=@name, age=@age, phone=@phone, adress = @adress ",connection);
            command.Parameters.AddWithValue("@id",idBox.Text);
            command.Parameters.AddWithValue("@name", nameBox.Text);
            command.Parameters.AddWithValue("@age", ageBox.Text);
            command.Parameters.AddWithValue("@phone", phoneBox.Text);
            command.Parameters.AddWithValue("@adress", adressBox.Text);
            command.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["perDetInst"].Clear();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("Select * from perDetInst where id like '" + idBox.Text + "%' ", connection);
            dataAdapter.Fill(dataSet, "perDetInst");
            MessageBox.Show("Informations are updated!", "System");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }        
        }
    }
}
