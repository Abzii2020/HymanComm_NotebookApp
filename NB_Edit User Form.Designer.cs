﻿namespace HymanComm_NotebookApp
{
    partial class NB_EditUserForm
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
            this.EditUserForm_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Username_tb = new System.Windows.Forms.TextBox();
            this.Lastname_tb = new System.Windows.Forms.TextBox();
            this.Firstname_lb = new System.Windows.Forms.Label();
            this.Lastname_lb = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.AccessLevel_lbl = new System.Windows.Forms.Label();
            this.PromoDate_lbl = new System.Windows.Forms.Label();
            this.Firstname_tb = new System.Windows.Forms.TextBox();
            this.Promo_Date = new System.Windows.Forms.DateTimePicker();
            this.AccessLevel_cb = new System.Windows.Forms.ComboBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Id_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_lb = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditUserForm_lbl
            // 
            this.EditUserForm_lbl.AutoSize = true;
            this.EditUserForm_lbl.BackColor = System.Drawing.Color.Transparent;
            this.EditUserForm_lbl.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserForm_lbl.Location = new System.Drawing.Point(270, 44);
            this.EditUserForm_lbl.Name = "EditUserForm_lbl";
            this.EditUserForm_lbl.Size = new System.Drawing.Size(269, 59);
            this.EditUserForm_lbl.TabIndex = 20;
            this.EditUserForm_lbl.Text = "Edit User";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.03863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.96137F));
            this.tableLayoutPanel1.Controls.Add(this.Username_tb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lastname_tb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Firstname_lb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lastname_lb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Username_lbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AccessLevel_lbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PromoDate_lbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Firstname_tb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Promo_Date, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.AccessLevel_cb, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 303);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // Username_tb
            // 
            this.Username_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_tb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_tb.Location = new System.Drawing.Point(348, 134);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Size = new System.Drawing.Size(327, 32);
            this.Username_tb.TabIndex = 9;
            // 
            // Lastname_tb
            // 
            this.Lastname_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lastname_tb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname_tb.Location = new System.Drawing.Point(348, 74);
            this.Lastname_tb.Name = "Lastname_tb";
            this.Lastname_tb.Size = new System.Drawing.Size(327, 32);
            this.Lastname_tb.TabIndex = 8;
            // 
            // Firstname_lb
            // 
            this.Firstname_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Firstname_lb.AutoSize = true;
            this.Firstname_lb.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname_lb.Location = new System.Drawing.Point(56, 20);
            this.Firstname_lb.Name = "Firstname_lb";
            this.Firstname_lb.Size = new System.Drawing.Size(104, 20);
            this.Firstname_lb.TabIndex = 0;
            this.Firstname_lb.Text = "Firstname";
            this.Firstname_lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lastname_lb
            // 
            this.Lastname_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lastname_lb.AutoSize = true;
            this.Lastname_lb.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname_lb.Location = new System.Drawing.Point(58, 80);
            this.Lastname_lb.Name = "Lastname_lb";
            this.Lastname_lb.Size = new System.Drawing.Size(101, 20);
            this.Lastname_lb.TabIndex = 1;
            this.Lastname_lb.Text = "Lastname";
            this.Lastname_lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(56, 140);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(104, 20);
            this.Username_lbl.TabIndex = 2;
            this.Username_lbl.Text = "Username";
            this.Username_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccessLevel_lbl
            // 
            this.AccessLevel_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccessLevel_lbl.AutoSize = true;
            this.AccessLevel_lbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessLevel_lbl.Location = new System.Drawing.Point(44, 200);
            this.AccessLevel_lbl.Name = "AccessLevel_lbl";
            this.AccessLevel_lbl.Size = new System.Drawing.Size(129, 20);
            this.AccessLevel_lbl.TabIndex = 4;
            this.AccessLevel_lbl.Text = "Access Level";
            this.AccessLevel_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PromoDate_lbl
            // 
            this.PromoDate_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PromoDate_lbl.AutoSize = true;
            this.PromoDate_lbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoDate_lbl.Location = new System.Drawing.Point(29, 261);
            this.PromoDate_lbl.Name = "PromoDate_lbl";
            this.PromoDate_lbl.Size = new System.Drawing.Size(159, 20);
            this.PromoDate_lbl.TabIndex = 6;
            this.PromoDate_lbl.Text = "Promotion Date";
            this.PromoDate_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Firstname_tb
            // 
            this.Firstname_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Firstname_tb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname_tb.Location = new System.Drawing.Point(348, 14);
            this.Firstname_tb.Name = "Firstname_tb";
            this.Firstname_tb.Size = new System.Drawing.Size(327, 32);
            this.Firstname_tb.TabIndex = 7;
            // 
            // Promo_Date
            // 
            this.Promo_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Promo_Date.CalendarFont = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Promo_Date.Location = new System.Drawing.Point(346, 260);
            this.Promo_Date.Name = "Promo_Date";
            this.Promo_Date.Size = new System.Drawing.Size(330, 22);
            this.Promo_Date.TabIndex = 16;
            // 
            // AccessLevel_cb
            // 
            this.AccessLevel_cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccessLevel_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccessLevel_cb.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessLevel_cb.FormattingEnabled = true;
            this.AccessLevel_cb.Location = new System.Drawing.Point(348, 196);
            this.AccessLevel_cb.Name = "AccessLevel_cb";
            this.AccessLevel_cb.Size = new System.Drawing.Size(327, 28);
            this.AccessLevel_cb.TabIndex = 14;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_btn.Location = new System.Drawing.Point(8, 436);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(188, 34);
            this.Update_btn.TabIndex = 22;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancel_btn.Location = new System.Drawing.Point(687, 436);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(127, 34);
            this.Cancel_btn.TabIndex = 23;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Id_lbl
            // 
            this.Id_lbl.AutoSize = true;
            this.Id_lbl.Location = new System.Drawing.Point(396, 79);
            this.Id_lbl.Name = "Id_lbl";
            this.Id_lbl.Size = new System.Drawing.Size(0, 17);
            this.Id_lbl.TabIndex = 24;
            this.Id_lbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 25;
            // 
            // Id_lb
            // 
            this.Id_lb.AutoSize = true;
            this.Id_lb.Location = new System.Drawing.Point(380, 436);
            this.Id_lb.Name = "Id_lb";
            this.Id_lb.Size = new System.Drawing.Size(0, 17);
            this.Id_lb.TabIndex = 26;
            this.Id_lb.Visible = false;
            // 
            // NB_EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HymanComm_NotebookApp.Properties.Resources.formImg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 517);
            this.Controls.Add(this.Id_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id_lbl);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EditUserForm_lbl);
            this.Name = "NB_EditUserForm";
            this.Text = "Notebook - Edit User";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditUserForm_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Username_tb;
        private System.Windows.Forms.TextBox Lastname_tb;
        private System.Windows.Forms.Label Firstname_lb;
        private System.Windows.Forms.Label Lastname_lb;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label AccessLevel_lbl;
        private System.Windows.Forms.Label PromoDate_lbl;
        private System.Windows.Forms.TextBox Firstname_tb;
        private System.Windows.Forms.DateTimePicker Promo_Date;
        private System.Windows.Forms.ComboBox AccessLevel_cb;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label Id_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Id_lb;
    }
}