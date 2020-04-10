namespace HymanComm_NotebookApp
{
    partial class NB_MainWindow
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
            this.EditUser_btn = new System.Windows.Forms.Button();
            this.ViewUserStatus_btn = new System.Windows.Forms.Button();
            this.AddNewUser_btn = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accessControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditUser_btn
            // 
            this.EditUser_btn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EditUser_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUser_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUser_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditUser_btn.Location = new System.Drawing.Point(667, 344);
            this.EditUser_btn.Name = "EditUser_btn";
            this.EditUser_btn.Size = new System.Drawing.Size(218, 96);
            this.EditUser_btn.TabIndex = 1;
            this.EditUser_btn.Text = "EDIT USERS";
            this.EditUser_btn.UseVisualStyleBackColor = false;
            this.EditUser_btn.Click += new System.EventHandler(this.EditUser_btn_Click);
            // 
            // ViewUserStatus_btn
            // 
            this.ViewUserStatus_btn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ViewUserStatus_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ViewUserStatus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewUserStatus_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUserStatus_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ViewUserStatus_btn.Location = new System.Drawing.Point(667, 223);
            this.ViewUserStatus_btn.Name = "ViewUserStatus_btn";
            this.ViewUserStatus_btn.Padding = new System.Windows.Forms.Padding(3);
            this.ViewUserStatus_btn.Size = new System.Drawing.Size(218, 96);
            this.ViewUserStatus_btn.TabIndex = 2;
            this.ViewUserStatus_btn.Text = "VIEW USER STATUS";
            this.ViewUserStatus_btn.UseVisualStyleBackColor = false;
            this.ViewUserStatus_btn.Click += new System.EventHandler(this.ViewUserStatus_btn_Click);
            // 
            // AddNewUser_btn
            // 
            this.AddNewUser_btn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddNewUser_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddNewUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewUser_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewUser_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddNewUser_btn.Location = new System.Drawing.Point(667, 104);
            this.AddNewUser_btn.Name = "AddNewUser_btn";
            this.AddNewUser_btn.Size = new System.Drawing.Size(218, 96);
            this.AddNewUser_btn.TabIndex = 3;
            this.AddNewUser_btn.Text = "ADD NEW USERS";
            this.AddNewUser_btn.UseVisualStyleBackColor = false;
            this.AddNewUser_btn.Click += new System.EventHandler(this.AddNewUser_bt_Click);
            // 
            // Status
            // 
            this.Status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.Status.Location = new System.Drawing.Point(0, 529);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(958, 26);
            this.Status.TabIndex = 4;
            this.Status.Text = "Login Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accessControlToolStripMenuItem
            // 
            this.accessControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.accessControlToolStripMenuItem.Name = "accessControlToolStripMenuItem";
            this.accessControlToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.accessControlToolStripMenuItem.Text = "Access Control";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // NB_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HymanComm_NotebookApp.Properties.Resources.formImg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 555);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.AddNewUser_btn);
            this.Controls.Add(this.ViewUserStatus_btn);
            this.Controls.Add(this.EditUser_btn);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NB_MainWindow";
            this.Text = "Notebook Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NB_MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.NB_MainWindow_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditUser_btn;
        private System.Windows.Forms.Button ViewUserStatus_btn;
        private System.Windows.Forms.Button AddNewUser_btn;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accessControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}