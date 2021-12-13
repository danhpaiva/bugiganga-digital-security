namespace TrinketDigitalSecurity
{
    partial class F_M_Three_08
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_M_Three_08));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
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
            this.btn_exit.Location = new System.Drawing.Point(1244, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(35, 35);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.btn_back.Location = new System.Drawing.Point(25, 315);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 90);
            this.btn_back.TabIndex = 18;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.btn_next.Location = new System.Drawing.Point(1199, 315);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(50, 90);
            this.btn_next.TabIndex = 19;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // F_M_Three_08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrinketDigitalSecurity.Properties.Resources.Prancheta_25_100;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_M_Three_08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_M_Three_08";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_exit;
        private Button btn_back;
        private Button btn_next;
    }
}