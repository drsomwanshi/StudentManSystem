using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace StudentManSystem
{
    public partial class NewStudent : Form
    {
        //gloabal area
        OleDbConnection con;
        OleDbCommand cmd;

        public NewStudent()
        {
            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#Prog\StudentManSystem\StudentManSystem\StudentMan.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into student (sname,saddress,sclass,scontact,sfee) values('"+textBox1.Text +"','"+ textBox2.Text +"','"+ comboBox1.Text +"','"+ textBox3.Text +"',"+ textBox4.Text +")"; 
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            textBox1.Focus();
        }
    }
}
