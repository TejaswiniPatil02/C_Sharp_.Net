using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mca_Student_Form
{
    public partial class frm_login_form : Form
    {
        public frm_login_form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_username.Text == "Admin" && tb_pasword.Text == "a123")
            {
                MessageBox.Show("You wannt to log in??", "LOGGING", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_Student_Details ASD = new frm_Add_Student_Details();
                ASD.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalis Credential", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
