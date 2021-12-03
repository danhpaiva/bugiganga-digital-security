namespace TrinketDigitalSecurity
{
    public partial class F_M_Two_04 : Form
    {
        public F_M_Two_04()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            F_M_Two_03 f_M_Two_03 = new F_M_Two_03();
            f_M_Two_03.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_M_Two_05 f_M_Two_05 = new F_M_Two_05();
            f_M_Two_05.ShowDialog();
            Close();
        }

        private void btn_external_Click(object sender, EventArgs e)
        {
            F_Popup_04 f_Popup_04 = new F_Popup_04();
            f_Popup_04.ShowDialog();
        }

        private void btn_internal_Click(object sender, EventArgs e)
        {
            F_Popup_05 f_Popup_05 = new F_Popup_05();
            f_Popup_05.ShowDialog();
        }
    }
}
