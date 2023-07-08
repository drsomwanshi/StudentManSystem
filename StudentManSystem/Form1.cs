using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newStudentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudent s=new NewStudent();
            s.MdiParent = this;
            s.Show();
        }

        private void showAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudent s=new ShowStudent();
            s.MdiParent=this;   
            s.Show();
        }
    }
}
