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
    public partial class frmlectureMenu : Form
    {
        public frmlectureMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmTutorAdd menu = new frmTutorAdd();
            menu.TopLevel = false; ;
            panel2.Controls.Add(menu);
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmTutorView menu = new frmTutorView();
            menu.TopLevel = false; ;
            panel2.Controls.Add(menu);
            menu.Show();
        }
    }
}
