using fees.screen.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  

namespace fees.screen
{
    public partial class signup : TemplateForm
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }                                   
        public string constring = "Data Source=DESKTOP-GCD5HVR;Initial Catalog=fees;Integrated Security=True";
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                string q = "insert into admin1(username,password,answer)values('" + username.Text.ToString() + "','" + password.Text.ToString() + "','" + answer.Text.ToString() + "'  )";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESSFULLY ADDED");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin();
            ad.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
