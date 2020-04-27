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
    public partial class FEESTRUCTURE : TemplateForm
    {
        public FEESTRUCTURE()
        {
            InitializeComponent();
            fillcombo();
           
        }

        private void FEESTRUCTURE_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
                string q = "insert into STRUCTURE2(COURSE_ID,DUE_DATE,TUITION_FEES,SECURITY_FEES,MISC_FEES,ADMSN_FEES,STUDENT_ACTIVITY_FEES,EXAMINATION_FEES,START_YEAR,END_YEAR,TOTAL_FEES)values('" + comboBox2.Text.ToString() + "','" + DUE_DATE.Text.ToString() + "','" + TUITION_FEES.Text.ToString() + "' ,'" + SECURITY_FEES.Text.ToString() + "','" + MISC_FEES.Text.ToString() + "','" + ADMSN_FEES.Text.ToString() + "' ,'" + STUDENT_ACTIVITY_FEES.Text.ToString() + "','" + EXAMINATION_FEES.Text.ToString() + "','" + START_YEAR.Text.ToString() + "','" + END_YEAR.Text.ToString() + "','"+(Convert.ToDouble(TUITION_FEES.Text)+Convert.ToDouble(SECURITY_FEES.Text)+ Convert.ToDouble(MISC_FEES.Text)+ Convert.ToDouble(ADMSN_FEES.Text)+ Convert.ToDouble(STUDENT_ACTIVITY_FEES.Text)+ Convert.ToDouble(EXAMINATION_FEES.Text)).ToString()+ "' )";
                SqlCommand cmd = new SqlCommand(q, con);
           
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESSFULLY ADDED");

            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= "update STRUCTURE2 set DUE_DATE = '" + DUE_DATE.Text.ToString() + "' ,TUITION_FEES ='" + TUITION_FEES.Text.ToString() + "' ,SECURITY_FEES = '" + SECURITY_FEES.Text.ToString() + "' ,MISC_FEES = '" + MISC_FEES.Text.ToString() + "',ADMSN_FEES = '" + ADMSN_FEES.Text.ToString() + "' ,STUDENT_ACTIVITY_FEES = '" + STUDENT_ACTIVITY_FEES.Text.ToString() + "' ,EXAMINATION_FEES = '" + EXAMINATION_FEES.Text.ToString() + "',START_YEAR = '" + START_YEAR.Text.ToString() + "',END_YEAR = '" + END_YEAR.Text.ToString() + "'";


               


                }
    }
}
