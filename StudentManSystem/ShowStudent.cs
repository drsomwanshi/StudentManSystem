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
    public partial class ShowStudent : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adp;
        DataSet ds;
        
        public ShowStudent()
        {
            InitializeComponent();
        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#Prog\StudentManSystem\StudentManSystem\StudentMan.accdb");
            adp = new OleDbDataAdapter("select * from student", con);
            ds=new DataSet();
            adp.Fill(ds,"stud");
            dataGridView1.DataSource = ds.Tables["stud"];
            dataGridView1.Refresh();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            adp = new OleDbDataAdapter("select * from student where Sclass='"+ comboBox2.Text +"'", con);
            ds = new DataSet();
            adp.Fill(ds, "stud");
            dataGridView1.DataSource = ds.Tables["stud"];
            dataGridView1.Refresh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            adp = new OleDbDataAdapter("select * from student where Sname like '" + textBox1.Text + "%'", con);
            ds = new DataSet();
            adp.Fill(ds, "stud");
            dataGridView1.DataSource = ds.Tables["stud"];
            dataGridView1.Refresh();
        }
    }
}
