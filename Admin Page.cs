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
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void newCourse_Click(object sender, EventArgs e)
        {
            addnwcourse addnwcourse = new addnwcourse();
            addnwcourse.ShowDialog();
        }

        private void newTeacher_Click(object sender, EventArgs e)
        {
            addnwteacher addnwteacher = new addnwteacher();
            addnwteacher.ShowDialog();
        }

        private void newStudent_Click(object sender, EventArgs e)
        {
            addnwstudent addnwstudent = new addnwstudent();
            addnwstudent.ShowDialog();
        }

        private void assignTeaching_Click(object sender, EventArgs e)
        {
            asscourseInst asscourseInst = new asscourseInst();
            asscourseInst.ShowDialog();
        }

        private void assignAdvisor_Click(object sender, EventArgs e)
        {
            assInststd assInststd = new assInststd();
            assInststd.ShowDialog();
        }
    }
}
