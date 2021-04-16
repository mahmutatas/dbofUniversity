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
    public partial class courseAssigned : Form
    {
        public courseAssigned()
        {
            InitializeComponent();
        }
        DataSet dataSet = new DataSet();
        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");

        private void Adbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("Select * from teaches where id like '"+idBox.Text+"%' ", connection);
            dataAdapter.Fill(dataSet, "teaches");
            dataGridView1.DataSource = dataSet.Tables["teaches"];
            connection.Close();
        }

        private void courseAssigned_Load(object sender, EventArgs e)
        {
            
        }
    }
}
