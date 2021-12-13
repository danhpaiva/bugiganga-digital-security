namespace TrinketDigitalSecurity
{
    public partial class F_M_Four_02 : Form
    {
        public F_M_Four_02()
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
            F_M_Four_01 f_M_Four_01 = new F_M_Four_01();
            f_M_Four_01.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Hide();
            F_M_Four_03 f_M_Four_03 = new F_M_Four_03();
            f_M_Four_03.ShowDialog();
            Close();
        }

        private void btn_confidential_Click(object sender, EventArgs e)
        {
            F_Popup_06 f_Popup_06 = new F_Popup_06();
            f_Popup_06.ShowDialog();
        }

        private void btn_internal_Click(object sender, EventArgs e)
        {
            F_Popup_07 f_Popup_07 = new F_Popup_07();
            f_Popup_07.ShowDialog();
        }

        private void btn_public_Click(object sender, EventArgs e)
        {
            F_Popup_08 f_Popup_08 = new F_Popup_08();
            f_Popup_08.ShowDialog();
        }
    }
}
