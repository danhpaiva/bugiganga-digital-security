namespace TrinketDigitalSecurity
{
    public partial class F_M_Four_03 : Form
    {
        public F_M_Four_03()
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
            F_M_Four_02 f_M_Four_02 = new F_M_Four_02();
            f_M_Four_02.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Hide();
            F_M_Four_04 f_M_Four_04 = new F_M_Four_04();
            f_M_Four_04.ShowDialog();
            Close ();
        }
    }
}
