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
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_Student_details obj = new frm_Add_Student_details();
            obj.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
                 
        }

        
    }
}
