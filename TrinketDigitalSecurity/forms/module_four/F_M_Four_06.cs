namespace TrinketDigitalSecurity
{
    public partial class F_M_Four_06 : Form
    {
        public F_M_Four_06()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            F_M_Four_05 f_M_Four_05 = new F_M_Four_05();
            f_M_Four_05.ShowDialog();
            Close();
        }
    }
}
