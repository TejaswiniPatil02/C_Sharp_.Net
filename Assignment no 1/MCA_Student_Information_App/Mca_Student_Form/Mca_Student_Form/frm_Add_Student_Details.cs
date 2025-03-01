using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mca_Student_Form
{
    public partial class frm_Add_Student_Details : Form
    {
        public frm_Add_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DBG5OTJ;Initial Catalog=MCA_Student_Information_App_DB;Integrated Security=True;Pooling=False");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Clear_Control()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_D_O_B.ResetText();
            cmb_Course.SelectedIndex = 1;


            tb_Roll_No.Focus();
 
        }
       

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Click(object sender, EventArgs e)
        {
            frm_login_form obj = new frm_login_form();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con.Open();
            

            if (tb_Roll_No.Text !=""&& tb_Name.Text !=""&& tb_Mob_No.Text!=""&& cmb_Course.Text !="" )
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "insert into Student_Details values(@RNo,@Nm,@MobNo,@Dob,@Course)";
                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_D_O_B.Text;

                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("record saved sucessfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();
            }
               

            else
            {
                MessageBox.Show("invalid credentials", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Clear_Control();

            }

            Con.Close();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }
    }
}
