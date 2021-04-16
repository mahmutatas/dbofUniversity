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
    public partial class crsReg : Form
    {
        DataSet dataSet = new DataSet();
        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");
        public crsReg()
        {
            InitializeComponent();
        }

        private void Adbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("Select * from takes where id like '" + idBox.Text + "%' ", connection);
            dataAdapter.Fill(dataSet, "takes");
            dataGridView1.DataSource = dataSet.Tables["takes"];
            connection.Close();
        }
    }
}
