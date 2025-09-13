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

namespace Employee_Information_App
{
    public partial class frm_Employee_Infor_App : Form
    {
        public frm_Employee_Infor_App()
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
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select count(*) From Login_Form where Username = @Unm And Password =@Pwd";

            Cmd.Parameters.Add("Unm", SqlDbType.VarChar).Value = teju.Text;
            Cmd.Parameters.Add("pwd", SqlDbType.VarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Sucessfully", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                frm_Add_Employee_Details obj = new frm_Add_Employee_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid credential, Enter correct Details!!!";
                lbl_Note.ForeColor = Color.Red;
            }

            teju.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            teju.Focus();
            Con_Close();

          }

        private void tb_Employee_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Note.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }

      
    }

