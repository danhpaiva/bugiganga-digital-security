using System;
using System.Windows.Forms;

namespace BugigangaDigitalSecurity
{
    public partial class F_Module_One_Page_Three : Form
    {
        public F_Module_One_Page_Three()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_Module_One_Page_Four page_Four = new F_Module_One_Page_Four();
            page_Four.ShowDialog();
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
