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
    public partial class frm_Employee_List : Form
    {
        public frm_Employee_List()
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Shure ??", "LOG OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm_Employee_Infor_App obj = new frm_Employee_Infor_App();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_Employee_Details obj = new frm_Add_Employee_Details();
            obj.Show();
            this.Hide();
        }

        private void frm_Employee_List_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Content.UName;
            Con_Open();
            dgv_Employe_List.DataSource = "";
            SqlDataAdapter SDA = new SqlDataAdapter("select *from Add_Employee_Details", Con);

            DataTable dt = new DataTable();
            SDA.Fill(dt);

            dgv_Employe_List.DataSource = dt;
            Con_Close();
        }
    }
}
