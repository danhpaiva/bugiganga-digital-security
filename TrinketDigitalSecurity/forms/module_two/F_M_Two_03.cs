namespace TrinketDigitalSecurity
{
    public partial class F_M_Two_03 : Form
    {
        public F_M_Two_03()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            F_M_Two_02 f_M_Two_02 = new F_M_Two_02();
            f_M_Two_02.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_M_Two_04 f_M_Two_04 = new F_M_Two_04();
            f_M_Two_04.ShowDialog();
            Close();
        }
    }
}
