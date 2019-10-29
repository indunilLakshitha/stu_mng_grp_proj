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
    public partial class frmStudentMenu : Form
    {
        public frmStudentMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel2.Controls.Clear();
            frmStudentAdd menu = new frmStudentAdd();
            menu.TopLevel = false; ;
            panel2.Controls.Add(menu);
            menu.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmStudentView menu = new frmStudentView();
            menu.TopLevel = false; ;
            panel2.Controls.Add(menu);
            menu.Show();
        }
    }
}
