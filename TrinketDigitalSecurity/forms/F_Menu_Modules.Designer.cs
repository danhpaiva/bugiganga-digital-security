namespace TrinketDigitalSecurity
{
    partial class F_Menu_Modules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Menu_Modules));
            this.btn_module_one = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_module_one
            // 
            this.btn_module_one.BackColor = System.Drawing.Color.Transparent;
            this.btn_module_one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_module_one.FlatAppearance.BorderSize = 0;
            this.btn_module_one.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_module_one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_module_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_module_one.ForeColor = System.Drawing.Color.Transparent;
            this.btn_module_one.Location = new System.Drawing.Point(193, 151);
            this.btn_module_one.Name = "btn_module_one";
            this.btn_module_one.Size = new System.Drawing.Size(146, 149);
            this.btn_module_one.TabIndex = 4;
            this.btn_module_one.UseVisualStyleBackColor = false;
            this.btn_module_one.Click += new System.EventHandler(this.btn_module_one_Click);
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
            this.btn_exit.Location = new System.Drawing.Point(1236, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 41);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // F_Menu_Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrinketDigitalSecurity.Properties.Resources.Prancheta_3_100;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_module_one);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Menu_Modules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Menu_Modules";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_module_one;
        private Button btn_exit;
    }
}