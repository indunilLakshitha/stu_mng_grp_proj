using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class frmAdminRegister : Form
    {
        public frmAdminRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string connetionString = null;

            connetionString = "server=localhost;database=wisdomDb;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);

            try
            {
                conn.Open();
                //MessageBox.Show("succecess");
                conn.Close();
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

                conn.Dispose();
            }
        }
    }
}
