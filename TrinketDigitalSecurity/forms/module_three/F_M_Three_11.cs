using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinketDigitalSecurity
{
    public partial class F_M_Three_11 : Form
    {
        public F_M_Three_11()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            F_M_Three_10 f_M_Three_10 = new F_M_Three_10();
            f_M_Three_10.ShowDialog();
            Close();
        }
    }
}
