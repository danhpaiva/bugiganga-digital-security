namespace TrinketDigitalSecurity
{
    public partial class F_M_Three_11 : Form
    {
        public F_M_Three_11()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Hide();
            F_Menu_Modules f_Menu_Modules = new F_Menu_Modules();
            f_Menu_Modules.ShowDialog();
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            F_M_Three_10 f_M_Three_10 = new F_M_Three_10();
            f_M_Three_10.ShowDialog();
            Close();
        }
    }
}
