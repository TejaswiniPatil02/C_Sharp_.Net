
namespace Tiles_Shopee
{
    partial class frm_Staff_Details
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
            this.lbl_Staff_Details = new System.Windows.Forms.Label();
            this.lbl_Employe_Name = new System.Windows.Forms.Label();
            this.lbl_Employe_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.tb_Employe_Username = new System.Windows.Forms.TextBox();
            this.cmb_Employee_Department = new System.Windows.Forms.ComboBox();
            this.pnl_Radio_Btn = new System.Windows.Forms.Panel();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.lbl_Shift_time = new System.Windows.Forms.Label();
            this.pnl_Shift_Time = new System.Windows.Forms.Panel();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.pnl_Radio_Btn.SuspendLayout();
            this.pnl_Shift_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Staff_Details
            // 
            this.lbl_Staff_Details.AutoSize = true;
            this.lbl_Staff_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Details.Location = new System.Drawing.Point(410, 9);
            this.lbl_Staff_Details.Name = "lbl_Staff_Details";
            this.lbl_Staff_Details.Size = new System.Drawing.Size(258, 52);
            this.lbl_Staff_Details.TabIndex = 0;
            this.lbl_Staff_Details.Text = "Staff Deatils";
            // 
            // lbl_Employe_Name
            // 
            this.lbl_Employe_Name.AutoSize = true;
            this.lbl_Employe_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employe_Name.Location = new System.Drawing.Point(167, 151);
            this.lbl_Employe_Name.Name = "lbl_Employe_Name";
            this.lbl_Employe_Name.Size = new System.Drawing.Size(145, 25);
            this.lbl_Employe_Name.TabIndex = 1;
            this.lbl_Employe_Name.Text = "Employe Name";
            // 
            // lbl_Employe_Department
            // 
            this.lbl_Employe_Department.AutoSize = true;
            this.lbl_Employe_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employe_Department.Location = new System.Drawing.Point(167, 258);
            this.lbl_Employe_Department.Name = "lbl_Employe_Department";
            this.lbl_Employe_Department.Size = new System.Drawing.Size(205, 25);
            this.lbl_Employe_Department.TabIndex = 2;
            this.lbl_Employe_Department.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(167, 345);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(77, 25);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // tb_Employe_Username
            // 
            this.tb_Employe_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employe_Username.Location = new System.Drawing.Point(472, 152);
            this.tb_Employe_Username.MaxLength = 40;
            this.tb_Employe_Username.Name = "tb_Employe_Username";
            this.tb_Employe_Username.Size = new System.Drawing.Size(287, 26);
            this.tb_Employe_Username.TabIndex = 4;
            // 
            // cmb_Employee_Department
            // 
            this.cmb_Employee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Department.FormattingEnabled = true;
            this.cmb_Employee_Department.Items.AddRange(new object[] {
            "Cleaning",
            "Sales",
            "Managment"});
            this.cmb_Employee_Department.Location = new System.Drawing.Point(472, 255);
            this.cmb_Employee_Department.Name = "cmb_Employee_Department";
            this.cmb_Employee_Department.Size = new System.Drawing.Size(287, 28);
            this.cmb_Employee_Department.TabIndex = 5;
            // 
            // pnl_Radio_Btn
            // 
            this.pnl_Radio_Btn.Controls.Add(this.rb_Female);
            this.pnl_Radio_Btn.Controls.Add(this.rb_Male);
            this.pnl_Radio_Btn.Location = new System.Drawing.Point(472, 345);
            this.pnl_Radio_Btn.Name = "pnl_Radio_Btn";
            this.pnl_Radio_Btn.Size = new System.Drawing.Size(287, 41);
            this.pnl_Radio_Btn.TabIndex = 6;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(26, 5);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(59, 21);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(160, 5);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(75, 21);
            this.rb_Female.TabIndex = 1;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // lbl_Shift_time
            // 
            this.lbl_Shift_time.AutoSize = true;
            this.lbl_Shift_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_time.Location = new System.Drawing.Point(167, 455);
            this.lbl_Shift_time.Name = "lbl_Shift_time";
            this.lbl_Shift_time.Size = new System.Drawing.Size(100, 25);
            this.lbl_Shift_time.TabIndex = 7;
            this.lbl_Shift_time.Text = "Shift Time";
            // 
            // pnl_Shift_Time
            // 
            this.pnl_Shift_Time.Controls.Add(this.rb_Night);
            this.pnl_Shift_Time.Controls.Add(this.rb_Evening);
            this.pnl_Shift_Time.Controls.Add(this.rb_Morning);
            this.pnl_Shift_Time.Location = new System.Drawing.Point(472, 455);
            this.pnl_Shift_Time.Name = "pnl_Shift_Time";
            this.pnl_Shift_Time.Size = new System.Drawing.Size(287, 39);
            this.pnl_Shift_Time.TabIndex = 8;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Location = new System.Drawing.Point(12, 8);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(80, 21);
            this.rb_Morning.TabIndex = 0;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Location = new System.Drawing.Point(120, 8);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(80, 21);
            this.rb_Evening.TabIndex = 1;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Location = new System.Drawing.Point(219, 8);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(62, 21);
            this.rb_Night.TabIndex = 2;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(210, 570);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(127, 50);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(517, 570);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(127, 50);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_Staff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1001, 653);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.pnl_Shift_Time);
            this.Controls.Add(this.lbl_Shift_time);
            this.Controls.Add(this.pnl_Radio_Btn);
            this.Controls.Add(this.cmb_Employee_Department);
            this.Controls.Add(this.tb_Employe_Username);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employe_Department);
            this.Controls.Add(this.lbl_Employe_Name);
            this.Controls.Add(this.lbl_Staff_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Staff_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Staff_Details";
            this.pnl_Radio_Btn.ResumeLayout(false);
            this.pnl_Radio_Btn.PerformLayout();
            this.pnl_Shift_Time.ResumeLayout(false);
            this.pnl_Shift_Time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Staff_Details;
        private System.Windows.Forms.Label lbl_Employe_Name;
        private System.Windows.Forms.Label lbl_Employe_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox tb_Employe_Username;
        private System.Windows.Forms.ComboBox cmb_Employee_Department;
        private System.Windows.Forms.Panel pnl_Radio_Btn;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Label lbl_Shift_time;
        private System.Windows.Forms.Panel pnl_Shift_Time;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
    }
}