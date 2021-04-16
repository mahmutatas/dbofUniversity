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
    public partial class Main_Page : Form
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=university.db");
        public Main_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Main_Page_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Main_Page_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Main_Page_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;  
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*'; 
            }
        }

        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }
        bool isThere, isThere2, isThere3;
        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            Admin_Page adminP = new Admin_Page();
            Instructor_Page instP = new Instructor_Page();
            Student_Page stdP = new Student_Page();

            connection.Open();
            SQLiteCommand command = new SQLiteCommand("Select * from admin", connection);
            SQLiteCommand commandI = new SQLiteCommand("Select * from inst", connection);
            SQLiteCommand commandS = new SQLiteCommand("Select * from std", connection);

            SQLiteDataReader reader = command.ExecuteReader();
            SQLiteDataReader readerI = commandI.ExecuteReader();
            SQLiteDataReader readerS = commandS.ExecuteReader();

            while (reader.Read())
            {
                if (username == reader["username"].ToString().TrimEnd() && pass == reader["pass"].ToString().TrimEnd())
                {
                    isThere = true;
                    adminP.ShowDialog();
                    break;
                }
                else
                {
                    isThere = false;
                }
            }

            while (readerI.Read())
            {
                if (username == readerI["username"].ToString().TrimEnd() && pass == readerI["pass"].ToString().TrimEnd())
                {
                    isThere2 = true;
                    instP.ShowDialog();
                    break;
                }
                else
                {
                    isThere2 = false;
                }
            }

            while (readerS.Read())
            {
                if (username == readerS["username"].ToString().TrimEnd() && pass == readerS["pass"].ToString().TrimEnd())
                {
                    isThere3 = true;
                    stdP.ShowDialog();
                    break;
                }
                else
                {
                    isThere3 = false;
                }
            }
            connection.Close();
            if (isThere == false && isThere2 == false && isThere3 == false)
            {
                MessageBox.Show("Username or password is wrong!!", "System");
            }
        }
    }
}
