using System;
using System.Windows.Forms;

namespace BugigangaDigitalSecurity
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_module_one_Click(object sender, EventArgs e)
        {
            F_Module_One_Page_One page_One = new F_Module_One_Page_One();
            page_One.ShowDialog();
        }

        private void btn_check_password_Click(object sender, EventArgs e)
        {
            F_CheckPassword f_CheckPassword = new F_CheckPassword();
            f_CheckPassword.ShowDialog();
        }
    }
}
