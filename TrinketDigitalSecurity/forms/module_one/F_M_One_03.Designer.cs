namespace TrinketDigitalSecurity
{
    partial class F_M_One_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_M_One_03));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btn_exit.Location = new System.Drawing.Point(1242, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(35, 35);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_menu.Location = new System.Drawing.Point(835, 577);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(169, 51);
            this.btn_menu.TabIndex = 9;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.Location = new System.Drawing.Point(21, 316);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 90);
            this.btn_back.TabIndex = 10;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // F_M_One_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrinketDigitalSecurity.Properties.Resources.Prancheta_9_100;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_M_One_03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module I";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_exit;
        private Button btn_menu;
        private Button btn_back;
    }
}