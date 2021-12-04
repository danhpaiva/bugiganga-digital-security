namespace TrinketDigitalSecurity
{
    public partial class F_M_Three_06 : Form
    {
        public F_M_Three_06()
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
            F_M_Three_05 f_M_Three_05 = new F_M_Three_05();
            f_M_Three_05.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Hide();
            F_M_Three_07 f_M_Three_07 = new F_M_Three_07();
            f_M_Three_07.ShowDialog();
            Close();
        }
    }
}
