namespace HymanComm_NotebookApp
{
    partial class NB_EditUsers
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
            this.DeleteUserCredentials_btn = new System.Windows.Forms.Button();
            this.EditUserCredentials_btn = new System.Windows.Forms.Button();
            this.ResetPassword_btn = new System.Windows.Forms.Button();
            this.gv_UserList = new System.Windows.Forms.DataGridView();
            this.SearchUser_lbl = new System.Windows.Forms.Label();
            this.NB_SearchBox = new System.Windows.Forms.TextBox();
            this.EditUser_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteUserCredentials_btn
            // 
            this.DeleteUserCredentials_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteUserCredentials_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteUserCredentials_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserCredentials_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteUserCredentials_btn.Location = new System.Drawing.Point(321, 445);
            this.DeleteUserCredentials_btn.Name = "DeleteUserCredentials_btn";
            this.DeleteUserCredentials_btn.Size = new System.Drawing.Size(201, 34);
            this.DeleteUserCredentials_btn.TabIndex = 7;
            this.DeleteUserCredentials_btn.Text = "Delete";
            this.DeleteUserCredentials_btn.UseVisualStyleBackColor = false;
            this.DeleteUserCredentials_btn.Click += new System.EventHandler(this.DeleteUserCredentials_btn_Click);
            // 
            // EditUserCredentials_btn
            // 
            this.EditUserCredentials_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EditUserCredentials_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditUserCredentials_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserCredentials_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditUserCredentials_btn.Location = new System.Drawing.Point(12, 445);
            this.EditUserCredentials_btn.Name = "EditUserCredentials_btn";
            this.EditUserCredentials_btn.Size = new System.Drawing.Size(201, 34);
            this.EditUserCredentials_btn.TabIndex = 8;
            this.EditUserCredentials_btn.Text = "Edit User Credentials";
            this.EditUserCredentials_btn.UseVisualStyleBackColor = false;
            this.EditUserCredentials_btn.Click += new System.EventHandler(this.EditUserCredentials_btn_Click);
            // 
            // ResetPassword_btn
            // 
            this.ResetPassword_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ResetPassword_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetPassword_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassword_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResetPassword_btn.Location = new System.Drawing.Point(617, 445);
            this.ResetPassword_btn.Name = "ResetPassword_btn";
            this.ResetPassword_btn.Size = new System.Drawing.Size(201, 34);
            this.ResetPassword_btn.TabIndex = 9;
            this.ResetPassword_btn.Text = "Reset Password";
            this.ResetPassword_btn.UseVisualStyleBackColor = false;
            this.ResetPassword_btn.Click += new System.EventHandler(this.ResetPassword_btn_Click);
            // 
            // gv_UserList
            // 
            this.gv_UserList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_UserList.Location = new System.Drawing.Point(12, 151);
            this.gv_UserList.Name = "gv_UserList";
            this.gv_UserList.RowHeadersWidth = 51;
            this.gv_UserList.RowTemplate.Height = 24;
            this.gv_UserList.Size = new System.Drawing.Size(806, 275);
            this.gv_UserList.TabIndex = 10;
            // 
            // SearchUser_lbl
            // 
            this.SearchUser_lbl.AutoSize = true;
            this.SearchUser_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.SearchUser_lbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUser_lbl.Location = new System.Drawing.Point(12, 119);
            this.SearchUser_lbl.Name = "SearchUser_lbl";
            this.SearchUser_lbl.Size = new System.Drawing.Size(210, 20);
            this.SearchUser_lbl.TabIndex = 11;
            this.SearchUser_lbl.Text = "Search by Firstname:";
            // 
            // NB_SearchBox
            // 
            this.NB_SearchBox.Location = new System.Drawing.Point(237, 117);
            this.NB_SearchBox.Name = "NB_SearchBox";
            this.NB_SearchBox.Size = new System.Drawing.Size(235, 22);
            this.NB_SearchBox.TabIndex = 16;
            this.NB_SearchBox.TextChanged += new System.EventHandler(this.Search_tb);
            // 
            // EditUser_lbl
            // 
            this.EditUser_lbl.AutoSize = true;
            this.EditUser_lbl.BackColor = System.Drawing.Color.Transparent;
            this.EditUser_lbl.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUser_lbl.Location = new System.Drawing.Point(187, 43);
            this.EditUser_lbl.Name = "EditUser_lbl";
            this.EditUser_lbl.Size = new System.Drawing.Size(504, 59);
            this.EditUser_lbl.TabIndex = 18;
            this.EditUser_lbl.Text = "View User to Edit ";
            this.EditUser_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NB_EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HymanComm_NotebookApp.Properties.Resources.formImg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 517);
            this.Controls.Add(this.EditUser_lbl);
            this.Controls.Add(this.NB_SearchBox);
            this.Controls.Add(this.SearchUser_lbl);
            this.Controls.Add(this.gv_UserList);
            this.Controls.Add(this.ResetPassword_btn);
            this.Controls.Add(this.EditUserCredentials_btn);
            this.Controls.Add(this.DeleteUserCredentials_btn);
            this.Name = "NB_EditUsers";
            this.Text = "Notebook - Edit Users";
            this.Load += new System.EventHandler(this.NB_EditUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteUserCredentials_btn;
        private System.Windows.Forms.Button EditUserCredentials_btn;
        private System.Windows.Forms.Button ResetPassword_btn;
        private System.Windows.Forms.DataGridView gv_UserList;
        private System.Windows.Forms.Label SearchUser_lbl;
        private System.Windows.Forms.TextBox NB_SearchBox;
        private System.Windows.Forms.Label EditUser_lbl;
    }
}