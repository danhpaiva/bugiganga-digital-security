
namespace TrinketDigitalSecurity
{
    partial class F_Menu
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
            this.btn_module_one = new System.Windows.Forms.Button();
            this.btn_module_two = new System.Windows.Forms.Button();
            this.btn_module_three = new System.Windows.Forms.Button();
            this.btn_module_four = new System.Windows.Forms.Button();
            this.btn_module_five = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_module_one
            // 
            this.btn_module_one.Location = new System.Drawing.Point(127, 194);
            this.btn_module_one.Name = "btn_module_one";
            this.btn_module_one.Size = new System.Drawing.Size(124, 23);
            this.btn_module_one.TabIndex = 0;
            this.btn_module_one.Text = "module one";
            this.btn_module_one.UseVisualStyleBackColor = true;
            this.btn_module_one.Click += new System.EventHandler(this.btn_module_one_Click);
            // 
            // btn_module_two
            // 
            this.btn_module_two.Location = new System.Drawing.Point(1006, 194);
            this.btn_module_two.Name = "btn_module_two";
            this.btn_module_two.Size = new System.Drawing.Size(124, 23);
            this.btn_module_two.TabIndex = 1;
            this.btn_module_two.Text = "module two";
            this.btn_module_two.UseVisualStyleBackColor = true;
            // 
            // btn_module_three
            // 
            this.btn_module_three.Location = new System.Drawing.Point(127, 409);
            this.btn_module_three.Name = "btn_module_three";
            this.btn_module_three.Size = new System.Drawing.Size(124, 23);
            this.btn_module_three.TabIndex = 2;
            this.btn_module_three.Text = "module three";
            this.btn_module_three.UseVisualStyleBackColor = true;
            // 
            // btn_module_four
            // 
            this.btn_module_four.Location = new System.Drawing.Point(1006, 409);
            this.btn_module_four.Name = "btn_module_four";
            this.btn_module_four.Size = new System.Drawing.Size(124, 23);
            this.btn_module_four.TabIndex = 3;
            this.btn_module_four.Text = "module four";
            this.btn_module_four.UseVisualStyleBackColor = true;
            // 
            // btn_module_five
            // 
            this.btn_module_five.Location = new System.Drawing.Point(557, 572);
            this.btn_module_five.Name = "btn_module_five";
            this.btn_module_five.Size = new System.Drawing.Size(124, 23);
            this.btn_module_five.TabIndex = 4;
            this.btn_module_five.Text = "module five";
            this.btn_module_five.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "You can interact with the modules below";
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_module_five);
            this.Controls.Add(this.btn_module_four);
            this.Controls.Add(this.btn_module_three);
            this.Controls.Add(this.btn_module_two);
            this.Controls.Add(this.btn_module_one);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trinket Digital Security - Modules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_module_one;
        private System.Windows.Forms.Button btn_module_two;
        private System.Windows.Forms.Button btn_module_three;
        private System.Windows.Forms.Button btn_module_four;
        private System.Windows.Forms.Button btn_module_five;
        private System.Windows.Forms.Label label1;
    }
}