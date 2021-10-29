using System;
using System.Windows.Forms;

namespace TrinketDigitalSecurity
{
    public partial class F_Welcome : Form
    {
        public F_Welcome()
        {
            InitializeComponent();
        }

        private void btn_welcome_Click(object sender, EventArgs e)
        {
            F_Menu f_Menu = new F_Menu();
            f_Menu.ShowDialog();
        }
    }
}
