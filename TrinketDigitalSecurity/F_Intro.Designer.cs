namespace TrinketDigitalSecurity
{
    partial class F_Intro
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
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
            this.btn_exit.Location = new System.Drawing.Point(1202, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(78, 41);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.Transparent;
            this.btn_next.Location = new System.Drawing.Point(820, 601);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(174, 51);
            this.btn_next.TabIndex = 3;
            this.btn_next.UseVisualStyleBackColor = false;
            // 
            // F_Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrinketDigitalSecurity.Properties.Resources.Prancheta_2_100;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Menu_Modules";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_exit;
        private Button btn_next;
    }
}