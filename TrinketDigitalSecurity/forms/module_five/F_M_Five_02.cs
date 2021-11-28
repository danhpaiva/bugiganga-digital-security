namespace TrinketDigitalSecurity
{
    public partial class F_M_Five_02 : Form
    {
        public F_M_Five_02()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            F_M_Five_01 f_M_Five_01 = new F_M_Five_01();
            f_M_Five_01.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_M_Five_03 f_M_Five_03 = new F_M_Five_03();
            f_M_Five_03.ShowDialog();
            Close();
        }
    }
}
