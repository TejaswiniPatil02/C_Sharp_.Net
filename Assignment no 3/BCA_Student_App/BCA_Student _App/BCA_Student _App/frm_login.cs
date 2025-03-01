using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA_Student__App
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text =="Admin"&& tb_Password.Text=="a123")
            {
                MessageBox.Show("Login Successfully","Welome");
                frm_Add_Student_details obj = new frm_Add_Student_details();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login Failed,Enter Correct Username/Password", "Failed");
            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
           
        }
    }
}
