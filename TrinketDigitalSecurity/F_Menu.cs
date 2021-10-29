using System;
using System.Windows.Forms;

namespace TrinketDigitalSecurity
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void btn_module_one_Click(object sender, EventArgs e)
        {
            F_Module_One_01 f_Module_One_01 = new F_Module_One_01();
            f_Module_One_01.ShowDialog();
        }
    }
}
