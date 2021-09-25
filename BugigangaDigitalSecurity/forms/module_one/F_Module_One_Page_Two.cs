using System;
using System.Windows.Forms;

namespace BugigangaDigitalSecurity
{
    public partial class F_Module_One_Page_Two : Form
    {
        public F_Module_One_Page_Two()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_Module_One_Page_Three page_Three = new F_Module_One_Page_Three();
            page_Three.ShowDialog();
            Close();
        }
    }
}
