namespace TrinketDigitalSecurity
{
    public partial class F_M_Three_08 : Form
    {
        public F_M_Three_08()
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
            F_M_Three_07 f_M_Three_07 = new F_M_Three_07();
            f_M_Three_07.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Hide();
            F_M_Three_09 f_M_Three_09 = new F_M_Three_09();
            f_M_Three_09.ShowDialog();
            Close();
        }
    }
}
