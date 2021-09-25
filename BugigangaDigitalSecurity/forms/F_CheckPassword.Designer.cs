
namespace BugigangaDigitalSecurity
{
    partial class F_CheckPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CheckPassword));
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_check_password = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(59, 103);
            this.tb_password.MaxLength = 50;
            this.tb_password.Name = "tb_password";
            this.tb_password.PlaceholderText = "Enter a password";
            this.tb_password.Size = new System.Drawing.Size(164, 23);
            this.tb_password.TabIndex = 1;
            // 
            // btn_check_password
            // 
            this.btn_check_password.Location = new System.Drawing.Point(248, 103);
            this.btn_check_password.Name = "btn_check_password";
            this.btn_check_password.Size = new System.Drawing.Size(75, 23);
            this.btn_check_password.TabIndex = 2;
            this.btn_check_password.Text = "button1";
            this.btn_check_password.UseVisualStyleBackColor = true;
            this.btn_check_password.Click += new System.EventHandler(this.btn_check_password_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(415, 106);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(38, 15);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "label1";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(174)))), ((int)(((byte)(186)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1249, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // F_CheckPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_check_password);
            this.Controls.Add(this.tb_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_CheckPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CheckPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_check_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_close;
    }
}