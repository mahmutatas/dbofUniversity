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
    public partial class Instructor_Page : Form
    {
        public Instructor_Page()
        {
            InitializeComponent();
        }

        private void courseDetails_Click(object sender, EventArgs e)
        {
            showCoursedetails coursedetails = new showCoursedetails();
            coursedetails.ShowDialog();
        }

        private void courseAssigned_Click(object sender, EventArgs e)
        {
            courseAssigned courseAssigned = new courseAssigned();
            courseAssigned.ShowDialog();
        }

        private void updatePerDetails_Click(object sender, EventArgs e)
        {
            updatePerDetails updatePerDetails = new updatePerDetails();
            updatePerDetails.ShowDialog();
        }

        private void registerStd_Click(object sender, EventArgs e)
        {
            rgtStd rgtStd = new rgtStd();
            rgtStd.ShowDialog();
        }
    }
}
