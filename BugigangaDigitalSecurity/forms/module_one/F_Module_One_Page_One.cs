using System;
using System.Windows.Forms;

namespace BugigangaDigitalSecurity
{
    public partial class F_Module_One_Page_One : Form
    {
        public F_Module_One_Page_One()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_Module_One_Page_Two page_Two = new F_Module_One_Page_Two();
            page_Two.ShowDialog();
            Close();
        }
    }
}
