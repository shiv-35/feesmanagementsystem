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
    public partial class AdminLogin : TemplateForm
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm ad = new LoginForm();
            ad.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup ad = new signup();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GCD5HVR;Initial Catalog=fees;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from admin1 where username='"+username.Text+ "'and password='" + password.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()== "1")
            {
                this.Hide();
                adminform ad = new adminform();
                ad.Show();
            }
            else
            {
                MessageBox.Show("please check your username and password");
            }
        }
    }
}
