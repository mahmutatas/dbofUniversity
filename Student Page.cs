using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityDatabaseApp
{
    public partial class Student_Page : Form
    {
        public Student_Page()
        {
            InitializeComponent();
        }

        private void updateStudenDet_Click(object sender, EventArgs e)
        {
            seeNupdate seeNupdate = new seeNupdate();
            seeNupdate.ShowDialog();
        }

        private void coursesRegistered_Click(object sender, EventArgs e)
        {
            crsReg crsReg = new crsReg();
            crsReg.ShowDialog();
        }

        private void otherStudents_Click(object sender, EventArgs e)
        {
            listOfstudents listOfstudents = new listOfstudents();
            listOfstudents.ShowDialog();
        }
    }
}
