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
    public partial class FEETRANSACTION : TemplateForm
    {
        public FEETRANSACTION()
        {
            InitializeComponent();
            fillcombo();
            fillcombo1();
            
           
        }

        private void FEETRANSACTION_Load(object sender, EventArgs e)
        {

        }
        public string constring = "Data Source=DESKTOP-GCD5HVR;Initial Catalog=fees;Integrated Security=True";
        private void button4_Click(object sender, EventArgs e)
        {
            adminform ad = new adminform();
            ad.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
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
                    comboBox5.Items.Add(sName);
                }

            }
        }
        void fillcombo1()
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string y = "select * from student1  ";
                SqlCommand cmd = new SqlCommand(y, con);

                cmd.ExecuteNonQuery();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    String sName = rdr["ENROLLMENT_NUMBER"].ToString();
                    
                    comboBox4.Items.Add(sName);
                }

            }
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Transaction2(ENROLLMENT_NUMBER,AMOUNT_PAID,COURSE_ID,DEPOSIT_DATE,BANK_DEPOSIT_DATE,STATUS,MODE,TYPE,BANK_NAME,BANK_RELEASE_DATE)values('" + comboBox4.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + comboBox5.Text.ToString() + "' ,'" + textBox8.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox3.Text.ToString() + "' ,'" + comboBox2.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + textBox9.Text.ToString() + "','" + textBox10.Text.ToString() + "' )";
                SqlCommand cmd = new SqlCommand(q, con);
                    
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESSFULLY ADDED");

            }
        }
        
            

            

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mca1 ad = new mca1();
            ad.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mca2 ad = new mca2();
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mca3 ad = new mca3();
            ad.Show();
        }
    }
}
