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
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
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

        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Text="";
            tb_Mob_No.Clear();
            dtp_DOB.ResetText();
            cmb_Course.Items.Clear();

            tb_Name.Focus();
        }

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd1 = new SqlCommand();
            Cmd1.Connection = Con;
            Cmd1.CommandText = "Select Count(*)from Add_Student_Details";

            Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());

            Cmd1.Dispose();

            if(Cnt > 0)
            {
                Cmd1.Connection = Con;
                Cmd1.CommandText = "Select Max(Roll_No)from Add_Student_Details";

                Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }
            Con_Close();
            return Cnt + 1;
        }
       
        private void btn_Add_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_Student_details obj = new frm_Add_Student_details();
            obj.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "select * from Student_Details where Roll_No = @roll_No";

            cmd.Parameters.Add("@roll_No", SqlDbType.Int).Value =int.Parse( tb_Roll_No.Text);

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mob_No.Text = (Dr["Mobile_No"].ToString());
                dtp_DOB.Text = (Dr["DOB"].ToString());
                cmb_Course.Text = (Dr["Course"].ToString());
            }
            else
            {
                MessageBox.Show("Invalid Roll NO", "No Roll No Find", MessageBoxButtons.OK,MessageBoxIcon.Error);
                tb_Roll_No.Clear();
            }
            Con_Close();

           
        }
    }
}
