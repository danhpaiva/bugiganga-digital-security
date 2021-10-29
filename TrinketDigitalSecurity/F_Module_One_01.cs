using System;
using System.Windows.Forms;

namespace TrinketDigitalSecurity
{
    public partial class F_Module_One_01 : Form
    {
        public F_Module_One_01()
        {
            InitializeComponent();
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            if (lbl_answer_appears.Text == string.Empty)
            {
                lbl_answer_appears.Text = "The term is used to refer to data defense and the practice that ensures that\n" +
                "sensitive information can only be accessed by those to whom it refers\n(in other words, their legal guardians).\n" +
                "The main purpose of information security is the protection of information assets.\nThis encompasses all information" +
                "company, employee and consumer data,\nreports, whether in technological or physical means.";
                btn_next.Enabled = true;
            }
            else
            {
                lbl_answer_appears.Text = string.Empty;
                btn_next.Enabled = false;
            }
        }
    }
}
