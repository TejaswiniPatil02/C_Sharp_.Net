
namespace BCA_Student__App
{
    partial class frm_Student_List
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
            this.lbl_Student_List = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_Student_Details = new System.Windows.Forms.Button();
            this.dgv_Student_list = new System.Windows.Forms.DataGridView();
            this.lbl_UName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_list)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Student_List
            // 
            this.lbl_Student_List.AutoSize = true;
            this.lbl_Student_List.BackColor = System.Drawing.Color.LightYellow;
            this.lbl_Student_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_List.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_Student_List.Location = new System.Drawing.Point(344, 21);
            this.lbl_Student_List.Name = "lbl_Student_List";
            this.lbl_Student_List.Size = new System.Drawing.Size(264, 52);
            this.lbl_Student_List.TabIndex = 13;
            this.lbl_Student_List.Text = "Student List";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Maroon;
            this.btn_logout.Location = new System.Drawing.Point(906, 25);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(107, 49);
            this.btn_logout.TabIndex = 14;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_Student_Details
            // 
            this.btn_Student_Details.BackColor = System.Drawing.Color.Pink;
            this.btn_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_Details.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Student_Details.Location = new System.Drawing.Point(365, 537);
            this.btn_Student_Details.Name = "btn_Student_Details";
            this.btn_Student_Details.Size = new System.Drawing.Size(347, 74);
            this.btn_Student_Details.TabIndex = 15;
            this.btn_Student_Details.Text = "Add Student Details";
            this.btn_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Student_Details.Click += new System.EventHandler(this.btn_Student_Details_Click);
            // 
            // dgv_Student_list
            // 
            this.dgv_Student_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv_Student_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_list.Location = new System.Drawing.Point(-14, 80);
            this.dgv_Student_list.Name = "dgv_Student_list";
            this.dgv_Student_list.RowHeadersWidth = 51;
            this.dgv_Student_list.RowTemplate.Height = 24;
            this.dgv_Student_list.Size = new System.Drawing.Size(1056, 451);
            this.dgv_Student_list.TabIndex = 16;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_UName.Location = new System.Drawing.Point(12, 21);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(95, 29);
            this.lbl_UName.TabIndex = 17;
            this.lbl_UName.Text = "UName";
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 609);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.dgv_Student_list);
            this.Controls.Add(this.btn_Student_Details);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_Student_List);
            this.Name = "frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Student_List;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_Student_Details;
        private System.Windows.Forms.DataGridView dgv_Student_list;
        private System.Windows.Forms.Label lbl_UName;
    }
}