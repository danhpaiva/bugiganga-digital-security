﻿namespace TrinketDigitalSecurity
{
    public partial class F_M_Three_04 : Form
    {
        public F_M_Three_04()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            F_M_Three_03 f_M_Three_03 = new F_M_Three_03();
            f_M_Three_03.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Hide();
            F_M_Three_05 f_M_Three_05 = new F_M_Three_05();
            f_M_Three_05.ShowDialog();
            Close();
        }
    }
}
