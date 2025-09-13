using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiles_Shopee
{
    public partial class frm_Staff_Details : Form
    {
        public frm_Staff_Details()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employe_Username.Text = "";
            cmb_Employee_Department.Text = "";
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool flag = false;


            if (tb_Employe_Username.Text != " ")
            {
                Result = tb_Employe_Username.Text;
            }
            else
            {
                MessageBox.Show("Select Empoyee Name");
            }

            if (cmb_Employee_Department.Text != " ")
            {
                Result += " from " + cmb_Employee_Department.Text + " is ";
                flag = true;
                MessageBox.Show("Select Emplyee Department");
               
            }
            if (rb_Male.Checked == true)
            {
                Result += rb_Male.Text + "Employee Prefer Shift Timing";
            }
            else if (rb_Female.Checked == true)
            {
                Result += rb_Female.Text + "Employee Prefer Shift Timing";
            }
            else
            {
                MessageBox.Show("Select Gender of Employee");
            }

            if (rb_Morning.Checked == true)
            {
                Result += rb_Morning.Text + ",";
            }
            else if (rb_Evening.Checked == true)
            {
                Result += rb_Evening.Text + ",";
            }
            else if (rb_Night.Checked == true)
            {
                Result += rb_Night.Text + ",";
            }
            else
            {
                MessageBox.Show("Select Shift Timing");
                flag = true;
            }
            
        }
       
    }
  
}
