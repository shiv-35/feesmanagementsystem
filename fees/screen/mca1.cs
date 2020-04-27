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
    public partial class mca1 : TemplateForm
    {
        public mca1()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-GCD5HVR;Initial Catalog=fees;Integrated Security=True";
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection(constring);
            SqlCon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(" select COURSE_ID,TOTAL_FEES from STRUCTURE2 where COURSE_ID= 'MCA1'", SqlCon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FEETRANSACTION ad = new FEETRANSACTION();
            ad.Show();
        }
    }
}
