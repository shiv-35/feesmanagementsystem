using System;
using fees.screen.Templates;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fees.screen
{
    public partial class STUDENTLIST : TemplateForm
    {
        public STUDENTLIST()
        {
            InitializeComponent();
        }

        private void STUDENTLIST_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminform ad = new adminform();
            ad.Show();
        }

        private void ADD_STUDENT_Click(object sender, EventArgs e)
        {
            Firsty ad = new Firsty();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secondy ad = new secondy();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thirdy ad = new thirdy();
            ad.Show();
        }
    }
}
