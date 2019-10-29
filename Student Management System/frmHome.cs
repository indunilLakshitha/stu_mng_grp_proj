using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmStudentMenu menu = new frmStudentMenu();
            menu.TopLevel = false; ;
            panel3.Controls.Add(menu);
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmlectureMenu menu = new frmlectureMenu();
            menu.TopLevel = false; ;
            panel3.Controls.Add(menu);
            menu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmExams menu = new frmExams();
            menu.TopLevel = false; ;
            panel3.Controls.Add(menu);
            menu.Show();
        }
    }
}
