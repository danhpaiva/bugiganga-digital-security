namespace TrinketDigitalSecurity
{
    public partial class F_M_One_03 : Form
    {
        public F_M_One_03()
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
            F_M_One_02 f_M_One_02 = new F_M_One_02();
            f_M_One_02.ShowDialog();
            Close();
        }
    }
}
