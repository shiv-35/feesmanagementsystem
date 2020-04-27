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
using System.Configuration;

namespace fees.screen
{
    public partial class ADDSTUDENT : TemplateForm
    {
        public ADDSTUDENT()
        {
            InitializeComponent();
            fillcombo();
        }

        private void ADDSTUDENT_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string constring = "Data Source=DESKTOP-GCD5HVR;Initial Catalog=fees;Integrated Security=True";

        private void button4_Click(object sender, EventArgs e)
        {
            adminform ad = new adminform();
            ad.Show();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string Sqlquery = "insert into student1 values(@ENROLLMENT_NUMBER,@NAME,@ADMISSION_YEAR,@COURSE_ID,@BATCH)";
            SqlCommand com = new SqlCommand(Sqlquery, con);
            con.Open();
            com.Parameters.AddWithValue("@ENROLLMENT_NUMBER", enrollmentnumber.Text.ToString());
            com.Parameters.AddWithValue("@NAME", name.Text.ToString());
            com.Parameters.AddWithValue("@ADMISSION_YEAR", admissionyear.Text.ToString());
            com.Parameters.AddWithValue("@BATCH", comboBox2.Text.ToString());
            com.Parameters.AddWithValue("@COURSE_ID", comboBox1.Text.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show("data added successfully");
            con.Close();

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void fillcombo()
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string y = "select * from COURSE";
                SqlCommand cmd = new SqlCommand(y, con);
              
                cmd.ExecuteNonQuery();
              
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    String sName = rdr["COURSE_ID"].ToString();
                    comboBox2.Items.Add(sName);
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
