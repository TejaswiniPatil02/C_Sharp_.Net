
namespace Employee_Information_App
{
    partial class frm_Employee_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Employe_List = new System.Windows.Forms.DataGridView();
            this.lbl_Employe_List = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_Employee = new System.Windows.Forms.Button();
            this.lbl_UName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employe_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Employe_List
            // 
            this.dgv_Employe_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employe_List.Location = new System.Drawing.Point(12, 107);
            this.dgv_Employe_List.Name = "dgv_Employe_List";
            this.dgv_Employe_List.RowHeadersWidth = 51;
            this.dgv_Employe_List.RowTemplate.Height = 24;
            this.dgv_Employe_List.Size = new System.Drawing.Size(1096, 336);
            this.dgv_Employe_List.TabIndex = 0;
            // 
            // lbl_Employe_List
            // 
            this.lbl_Employe_List.AutoSize = true;
            this.lbl_Employe_List.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_Employe_List.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employe_List.Location = new System.Drawing.Point(372, 15);
            this.lbl_Employe_List.Name = "lbl_Employe_List";
            this.lbl_Employe_List.Size = new System.Drawing.Size(322, 67);
            this.lbl_Employe_List.TabIndex = 2;
            this.lbl_Employe_List.Text = "Employe List";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Logout.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btn_Logout.Location = new System.Drawing.Point(911, 18);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(141, 64);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_Employee
            // 
            this.btn_Add_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Add_Employee.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Employee.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btn_Add_Employee.Location = new System.Drawing.Point(400, 460);
            this.btn_Add_Employee.Name = "btn_Add_Employee";
            this.btn_Add_Employee.Size = new System.Drawing.Size(247, 56);
            this.btn_Add_Employee.TabIndex = 1;
            this.btn_Add_Employee.Text = "Add Employee";
            this.btn_Add_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_Employee.Click += new System.EventHandler(this.btn_Add_Employee_Click);
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.Color.Khaki;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_UName.Location = new System.Drawing.Point(26, 41);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(78, 25);
            this.lbl_UName.TabIndex = 12;
            this.lbl_UName.Text = "UName";
            // 
            // frm_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 541);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.btn_Add_Employee);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Employe_List);
            this.Controls.Add(this.dgv_Employe_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frm_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employe_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Employe_List;
        private System.Windows.Forms.Label lbl_Employe_List;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_Employee;
        private System.Windows.Forms.Label lbl_UName;
    }
}