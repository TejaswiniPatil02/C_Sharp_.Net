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


namespace BCA_Student__App
{
    public partial class frm_Add_Student_details : Form
    {
        public frm_Add_Student_details()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DBG5OTJ;Initial Catalog=BCA_Student_App_DB;Integrated Security=True");

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
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }


        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.ResetText();
            cmb_Course.SelectedIndex = 1;

            tb_Name.Focus();
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd1 = new SqlCommand();

            Cmd1.Connection = Con;
            Cmd1.CommandText = "Select count(*) from Student_Details";

            Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());

            Cmd1.Dispose();

            if (Cnt > 0)
            {
                Cmd1.Connection = Con;
                Cmd1.CommandText = "Select Max(Roll_No)from Student_Details";

                Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }
            Con_Close();
            return Cnt + 1;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if(tb_Roll_No.Text !=""&& tb_Name.Text !="" && tb_Mob_No.Text !="" && dtp_DOB.Text !="" && cmb_Course.Text !="")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Student_Details values(@RNo,@Nm,@MobNo,@Dob,@Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Sucessfully", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Info.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
           
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Close this App??", "CLOSING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(Res == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void frm_student_details_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Content.UName;
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

            tb_Roll_No.Focus();
            cmb_Course.SelectedIndex = 1;
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student();
            obj.Show();
            this.Hide();
        }
    }
}
