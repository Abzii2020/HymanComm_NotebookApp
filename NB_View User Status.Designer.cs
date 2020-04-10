namespace HymanComm_NotebookApp
{
    partial class NB_ViewUserStatus
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
            this.DeactivateUser_btn = new System.Windows.Forms.Button();
            this.gv_ViewUserStatus = new System.Windows.Forms.DataGridView();
            this.SearchUser_lbl = new System.Windows.Forms.Label();
            this.NB_Searchbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ViewUserStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // DeactivateUser_btn
            // 
            this.DeactivateUser_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DeactivateUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeactivateUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeactivateUser_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeactivateUser_btn.Location = new System.Drawing.Point(291, 451);
            this.DeactivateUser_btn.Name = "DeactivateUser_btn";
            this.DeactivateUser_btn.Size = new System.Drawing.Size(278, 34);
            this.DeactivateUser_btn.TabIndex = 10;
            this.DeactivateUser_btn.Text = "Activate / Deactivate User";
            this.DeactivateUser_btn.UseVisualStyleBackColor = false;
            this.DeactivateUser_btn.Click += new System.EventHandler(this.DeactivateUser_btn_Click);
            // 
            // gv_ViewUserStatus
            // 
            this.gv_ViewUserStatus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_ViewUserStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ViewUserStatus.Location = new System.Drawing.Point(12, 151);
            this.gv_ViewUserStatus.Name = "gv_ViewUserStatus";
            this.gv_ViewUserStatus.RowHeadersWidth = 51;
            this.gv_ViewUserStatus.RowTemplate.Height = 24;
            this.gv_ViewUserStatus.Size = new System.Drawing.Size(806, 275);
            this.gv_ViewUserStatus.TabIndex = 11;
            // 
            // SearchUser_lbl
            // 
            this.SearchUser_lbl.AutoSize = true;
            this.SearchUser_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.SearchUser_lbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUser_lbl.Location = new System.Drawing.Point(12, 116);
            this.SearchUser_lbl.Name = "SearchUser_lbl";
            this.SearchUser_lbl.Size = new System.Drawing.Size(210, 20);
            this.SearchUser_lbl.TabIndex = 13;
            this.SearchUser_lbl.Text = "Search by Firstname:";
            // 
            // NB_Searchbox
            // 
            this.NB_Searchbox.Location = new System.Drawing.Point(237, 114);
            this.NB_Searchbox.Name = "NB_Searchbox";
            this.NB_Searchbox.Size = new System.Drawing.Size(235, 22);
            this.NB_Searchbox.TabIndex = 14;
            this.NB_Searchbox.TextChanged += new System.EventHandler(this.Search_tb);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 59);
            this.label1.TabIndex = 16;
            this.label1.Text = "View User Status ";
            // 
            // NB_ViewUserStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HymanComm_NotebookApp.Properties.Resources.formImg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NB_Searchbox);
            this.Controls.Add(this.SearchUser_lbl);
            this.Controls.Add(this.gv_ViewUserStatus);
            this.Controls.Add(this.DeactivateUser_btn);
            this.Name = "NB_ViewUserStatus";
            this.Text = "Notebook - View User Status";
            this.Load += new System.EventHandler(this.NB_ViewUserStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ViewUserStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeactivateUser_btn;
        private System.Windows.Forms.DataGridView gv_ViewUserStatus;
        private System.Windows.Forms.Label SearchUser_lbl;
        private System.Windows.Forms.TextBox NB_Searchbox;
        private System.Windows.Forms.Label label1;
    }
}