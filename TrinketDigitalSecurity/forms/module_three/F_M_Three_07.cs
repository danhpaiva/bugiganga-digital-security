namespace TrinketDigitalSecurity
{
    public partial class F_M_Three_07 : Form
    {
        public F_M_Three_07()
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
            F_M_Three_06 f_M_Three_06 = new F_M_Three_06();
            f_M_Three_06.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Hide();
            F_M_Three_08 f_M_Three_08 = new F_M_Three_08();
            f_M_Three_08.ShowDialog();
            Close();
        }
    }
}
