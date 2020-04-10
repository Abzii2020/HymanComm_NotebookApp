namespace HymanComm_NotebookApp
{
    partial class NB_LoginScreen
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
            this.LoginScreen_lb = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_tb = new System.Windows.Forms.TextBox();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.LoginWin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginScreen_lb
            // 
            this.LoginScreen_lb.AutoSize = true;
            this.LoginScreen_lb.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginScreen_lb.Location = new System.Drawing.Point(138, 21);
            this.LoginScreen_lb.Name = "LoginScreen_lb";
            this.LoginScreen_lb.Size = new System.Drawing.Size(232, 36);
            this.LoginScreen_lb.TabIndex = 0;
            this.LoginScreen_lb.Text = "Login Screen";
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(10, 103);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(124, 25);
            this.Username_lbl.TabIndex = 1;
            this.Username_lbl.Text = "Username";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(12, 151);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(122, 25);
            this.Password_lbl.TabIndex = 2;
            this.Password_lbl.Text = "Password";
            // 
            // Username_tb
            // 
            this.Username_tb.Location = new System.Drawing.Point(144, 103);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Size = new System.Drawing.Size(197, 22);
            this.Username_tb.TabIndex = 3;
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(144, 151);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.PasswordChar = '*';
            this.Password_tb.Size = new System.Drawing.Size(197, 22);
            this.Password_tb.TabIndex = 4;
            // 
            // LoginWin_btn
            // 
            this.LoginWin_btn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginWin_btn.Location = new System.Drawing.Point(144, 221);
            this.LoginWin_btn.Name = "LoginWin_btn";
            this.LoginWin_btn.Size = new System.Drawing.Size(226, 46);
            this.LoginWin_btn.TabIndex = 5;
            this.LoginWin_btn.Text = "LOGIN";
            this.LoginWin_btn.UseVisualStyleBackColor = true;
            this.LoginWin_btn.Click += new System.EventHandler(this.LoginWin_btn_Click);
            // 
            // NB_LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 279);
            this.Controls.Add(this.LoginWin_btn);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.Username_tb);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.LoginScreen_lb);
            this.Name = "NB_LoginScreen";
            this.Text = "Notebook Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginScreen_lb;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Username_tb;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Button LoginWin_btn;
    }
}