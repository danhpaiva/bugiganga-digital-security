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

        private void btn_module_two_Click(object sender, EventArgs e)
        {
            F_M_Two_01 f_M_Two_01 = new F_M_Two_01();
            f_M_Two_01.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_M_Three_01 f_M_Three_01 = new F_M_Three_01();
            f_M_Three_01.ShowDialog();
        }

        private void btn_module_four_Click(object sender, EventArgs e)
        {
            F_M_Four_01 f_M_Four_01 = new F_M_Four_01();
            f_M_Four_01.ShowDialog();
        }
    }
}
