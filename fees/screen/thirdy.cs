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
    public partial class thirdy : TemplateForm
    {
        public thirdy()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-GCD5HVR;Initial Catalog=fees;Integrated Security=True";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from student1 where COURSE_ID='MCA3' ", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminform ad = new adminform();
            ad.Show();
        }
    }
}
