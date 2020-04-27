using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fees.screen.Templates;

namespace fees.screen
{
    public partial class adminform : TemplateForm
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADDCOURSE ad = new ADDCOURSE();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin();
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            STUDENTLIST ad = new STUDENTLIST();
            ad.Show();
        }

        private void ADD_STUDENT_Click(object sender, EventArgs e)
        {
            ADDSTUDENT ad = new ADDSTUDENT();
            ad.Show();
        }

        private void adminform_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FEESTRUCTURE ad = new FEESTRUCTURE();
            ad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FEETRANSACTION ad = new FEETRANSACTION();
            ad.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            STUDENTLIST ad = new STUDENTLIST();
            ad.Show();
        }
    }
}
