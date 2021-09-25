
namespace BugigangaDigitalSecurity
{
    partial class F_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.btn_welcome = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pb_principal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_welcome
            // 
            this.btn_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.btn_welcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_welcome.FlatAppearance.BorderSize = 0;
            this.btn_welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_welcome.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_welcome.ForeColor = System.Drawing.Color.White;
            this.btn_welcome.Location = new System.Drawing.Point(534, 512);
            this.btn_welcome.Name = "btn_welcome";
            this.btn_welcome.Size = new System.Drawing.Size(200, 50);
            this.btn_welcome.TabIndex = 0;
            this.btn_welcome.Text = "Welcome";
            this.btn_welcome.UseVisualStyleBackColor = false;
            this.btn_welcome.Click += new System.EventHandler(this.btn_welcome_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(174)))), ((int)(((byte)(186)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1248, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pb_principal
            // 
            this.pb_principal.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_principal.Image = global::BugigangaDigitalSecurity.Properties.Resources.detective_icon;
            this.pb_principal.Location = new System.Drawing.Point(486, 127);
            this.pb_principal.Name = "pb_principal";
            this.pb_principal.Size = new System.Drawing.Size(300, 300);
            this.pb_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_principal.TabIndex = 2;
            this.pb_principal.TabStop = false;
            this.pb_principal.Click += new System.EventHandler(this.pb_principal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(413, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bugiganga Digital Security";
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_principal);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bugiganga Digital Security";
            ((System.ComponentModel.ISupportInitialize)(this.pb_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_welcome;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pb_principal;
        private System.Windows.Forms.Label label1;
    }
}

