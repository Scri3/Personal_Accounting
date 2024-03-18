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
using System.Data.Sql;

namespace HomeWork_14010229
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hesabDari_Shakhsi_University_Final_ProjectDataSet.Makharej_Zendegi' table. You can move, or remove it, as needed.
            this.makharej_ZendegiTableAdapter.Fill(this.hesabDari_Shakhsi_University_Final_ProjectDataSet.Makharej_Zendegi);
            // TODO: This line of code loads data into the 'homeWork_Session10_AmoozeshkadeDataSet1.Courses' table. You can move, or remove it, as needed.
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int total= Convert.ToInt32(textBox4.Text)+ Convert.ToInt32(textBox5.Text)+ Convert.ToInt32(textBox6.Text)+ Convert.ToInt32(textBox7.Text)+ Convert.ToInt32(textBox8.Text)+ Convert.ToInt32(textBox9.Text)+ Convert.ToInt32(textBox10.Text)+ Convert.ToInt32(textBox11.Text);
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=HesabDari_Shakhsi_University_Final_Project;Integrated Security=True");

                conn.Open();

                SqlDataAdapter adp = new SqlDataAdapter();

                string Q1 = string.Format("insert into [HesabDari_Shakhsi_University_Final_Project].[dbo].[Makharej_Zendegi] (Year,Month,Day,Food,Clothing,Car,Shahrie,Ghabz,Internet,Sharje_Mobile,Others,Total) values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})", Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text),total);
                SqlCommand cmd = new SqlCommand(Q1, conn);

                adp.InsertCommand = cmd;
                adp.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();

                conn.Close();

                MessageBox.Show(".مخارج شما با موفقیت ثبت شد"+"\n"+"."+ "خرج کلی شما در تاریخ " + textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text  + "مبلغ " +  Convert.ToString(total) + " تومان می باشد" );
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                textBox9.Text = null;
                textBox10.Text = null;
                textBox11.Text = null;
                Form1_Load(null,null);
            }
            catch (Exception)
            {

                MessageBox.Show("Please insert data correctly!");
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                textBox9.Text = null;
                textBox10.Text = null;
                textBox11.Text = null;

                Form1_Load(null, null);

            }



        }

        
    }
}
