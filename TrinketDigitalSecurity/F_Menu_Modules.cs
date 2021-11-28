namespace TrinketDigitalSecurity
{
    public partial class F_Menu_Modules : Form
    {
        public F_Menu_Modules()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_module_one_Click(object sender, EventArgs e)
        {
            F_M_One_01 f_M_One_01 = new F_M_One_01();
            f_M_One_01.ShowDialog();
        }
    }
}
