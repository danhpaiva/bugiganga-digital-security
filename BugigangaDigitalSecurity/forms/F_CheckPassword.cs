using System;
using System.Windows.Forms;

namespace BugigangaDigitalSecurity
{
    public partial class F_CheckPassword : Form
    {
        public F_CheckPassword()
        {
            InitializeComponent();
        }

        private void btn_check_password_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                MessageBox.Show("Digite uma senha");
            }
            else
            {
                CheckPasswordSize(tb_password);
                CheckPasswordSimbols(tb_password);
                CheckUpperLetter(tb_password);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CheckPasswordSize(TextBox textBox)
        {
            if (textBox.TextLength < 8)
            {
                lbl_password.Text = "Senha ruim";
            }
        }

        public void CheckPasswordSimbols(TextBox textBox)
        {
            if (textBox.Text.Contains("@") || textBox.Text.Contains("!") || textBox.Text.Contains(".") || textBox.Text.Contains("_"))
            {
                lbl_password.Text = "okay";
            }
            else
            {
                lbl_password.Text = "Precisa ter um simbolo";
            }
        }

        public void CheckUpperLetter(TextBox textBox)
        {
            if (textBox.Text.Contains("A") || textBox.Text.Contains("E") || textBox.Text.Contains("I") || textBox.Text.Contains("O") || textBox.Text.Contains("U"))
            {
                lbl_password.Text = "Tem letrona";
            }
            else
            {
                lbl_password.Text = " N Tem letrona";
            }
        }
    }
}

