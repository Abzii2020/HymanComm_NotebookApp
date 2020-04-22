namespace HymanComm_NotebookApp
{
    partial class NB_Homepage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1508, 145);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notebook Application";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_btn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(1347, 414);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(856, 110);
            this.Login_btn.TabIndex = 1;
            this.Login_btn.Text = "Click here to Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // NB_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HymanComm_NotebookApp.Properties.Resources.formImg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2218, 781);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NB_Homepage";
            this.Text = "Welcome to Notebook ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_btn;
    }
}

