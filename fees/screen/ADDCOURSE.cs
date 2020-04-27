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
using System.Data.SqlClient;

namespace fees.screen
{
    public partial class ADDCOURSE : TemplateForm
    {
        public ADDCOURSE()
        {
            InitializeComponent();
        }

        private void ADDCOURSE_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminform ad = new adminform();
            ad.Show();
        }
        public string constring = "Data Source=DESKTOP-GCD5HVR;Initial Catalog=fees;Integrated Security=True";
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string y = "insert into COURSE(COURSE_ID,COURSE_NAME)values('" + COURSE_ID.Text.ToString() + "','" + COURSE_NAME.Text.ToString()  + "'    )";
                SqlCommand cmd = new SqlCommand(y, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESSFULLY ADDED");
            }
           

        }
    }
}
