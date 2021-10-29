using System;
using System.Windows.Forms;

namespace TrinketDigitalSecurity
{
    public partial class F_Module_One_02 : Form
    {
        public F_Module_One_02()
        {
            InitializeComponent();
        }

        private void F_Module_One_02_Load(object sender, EventArgs e)
        {
            lbl_text_one.Text = $"The three fundamental pillars that guide information security," + "known as CID, determine whether an asset is safe or not. Click on the 'letters' to find out more!";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            lbl_info_c.Text = $"Confidentiality\n" +
                "Having confidentiality is ensuring that the information will only be accessed by those who have proper authorization.";
            lbl_info_c.Visible = true;
            btn_i.Enabled = true;
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            lbl_info_i.Text = $"Confidentiality\n" +
                "Having confidentiality is ensuring that the information will only be accessed by those who have proper authorization.";
            lbl_info_i.Visible = true;
            btn_d.Enabled = true;
        }
    }
}
