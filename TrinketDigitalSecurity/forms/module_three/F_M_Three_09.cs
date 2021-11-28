namespace TrinketDigitalSecurity
{
    public partial class F_M_Three_09 : Form
    {
        public F_M_Three_09()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            F_M_Three_08 f_M_Three_08 = new F_M_Three_08();
            f_M_Three_08.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_M_Three_10 f_M_Three_10 = new F_M_Three_10();
            f_M_Three_10.ShowDialog();
            Close();
        }
    }
}
