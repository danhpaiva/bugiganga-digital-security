using System;
using System.Windows.Forms;

namespace BugigangaDigitalSecurity
{
    public partial class F_Module_One_Page_Four : Form
    {
        public F_Module_One_Page_Four()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_Module_One_Page_Five page_Five = new F_Module_One_Page_Five();
            page_Five.ShowDialog();
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
