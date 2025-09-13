using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Information_App
{
    public partial class frm_Add_Employee_Details : Form
    {
        public frm_Add_Employee_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DBG5OTJ;Initial Catalog=Employee_Information_App;Integrated Security=True;Pooling=False");

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
            tb_Employee_Id.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mob_No.Clear();
            tb_Age.Clear();
            tb_Address.Clear();

            tb_Name.Focus();
        }
        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd1 = new SqlCommand();

            Cmd1.Connection = Con;
            Cmd1.CommandText = "Select Count(*) from Add_Employee_Details";

            Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());

            Cmd1.Dispose();

            if (Cnt > 0)
            {
                Cmd1.Connection = Con;
                Cmd1.CommandText = "Select Max(Id_Number) from Add_Employee_Details";

                Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }
            Con_Close();
            return Cnt + 1;

        }



        private void frm_Add_Employee_Details_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Content.UName;

            tb_Employee_Id.Text = Convert.ToString(Auto_Incr());

            tb_Employee_Id.Focus();
            
        }
      



        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You shure??", "LOG OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm_Employee_Infor_App obj = new frm_Employee_Infor_App();
            obj.Show();
            this.Hide();
        }

        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            frm_Employee_List obj = new frm_Employee_List();
            obj.Show();
            this.Hide();
              
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Close this App???", "CLOSING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(Res == DialogResult.Yes)
            {
                this.Close();
            }
           

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Employee_Id.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && tb_Age.Text != "" && tb_Address.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Add_Employee_Details Values(@IDNo,@Nm,@MobNo,@Age,@Address)";

                Cmd.Parameters.Add("IDNo", SqlDbType.Int).Value = tb_Employee_Id.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Age", SqlDbType.Float).Value = tb_Age.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();

            }
            else
            {
                MessageBox.Show("Incomplete Info.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void lbl_UName_Click(object sender, EventArgs e)
        {
            Shared_Content.UName = tb_Name.Text;

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar ==(char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
    }









        }
    

