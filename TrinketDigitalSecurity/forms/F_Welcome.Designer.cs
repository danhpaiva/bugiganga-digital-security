﻿namespace TrinketDigitalSecurity
{
    partial class F_Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Welcome));
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_home_page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.Transparent;
            this.btn_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enter.FlatAppearance.BorderSize = 0;
            this.btn_enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.ForeColor = System.Drawing.Color.Transparent;
            this.btn_enter.Location = new System.Drawing.Point(525, 477);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(230, 65);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(44, 670);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(70, 30);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_home_page
            // 
            this.btn_home_page.BackColor = System.Drawing.Color.Transparent;
            this.btn_home_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home_page.FlatAppearance.BorderSize = 0;
            this.btn_home_page.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_home_page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_home_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home_page.Location = new System.Drawing.Point(318, 166);
            this.btn_home_page.Name = "btn_home_page";
            this.btn_home_page.Size = new System.Drawing.Size(650, 200);
            this.btn_home_page.TabIndex = 2;
            this.btn_home_page.UseVisualStyleBackColor = false;
            this.btn_home_page.Click += new System.EventHandler(this.btn_home_page_Click);
            // 
            // F_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrinketDigitalSecurity.Properties.Resources.Prancheta_1_100;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_home_page);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrinketDigitalSecurity";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_enter;
        private Button btn_exit;
        private Button btn_home_page;
    }
}