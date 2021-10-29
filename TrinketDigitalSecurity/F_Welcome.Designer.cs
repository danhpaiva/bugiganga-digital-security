
namespace TrinketDigitalSecurity
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
            this.btn_welcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_welcome
            // 
            this.btn_welcome.Location = new System.Drawing.Point(512, 558);
            this.btn_welcome.Name = "btn_welcome";
            this.btn_welcome.Size = new System.Drawing.Size(229, 64);
            this.btn_welcome.TabIndex = 0;
            this.btn_welcome.Text = "Welcome";
            this.btn_welcome.UseVisualStyleBackColor = true;
            this.btn_welcome.Click += new System.EventHandler(this.btn_welcome_Click);
            // 
            // F_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trinket Digital Security - Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_welcome;
    }
}

