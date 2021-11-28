namespace TrinketDigitalSecurity
{
    public partial class F_M_Five_03 : Form
    {
        public F_M_Five_03()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            F_M_Five_02 f_M_Five_02 = new F_M_Five_02();
            f_M_Five_02.ShowDialog();
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_M_Five_04 f_M_Five_04 = new F_M_Five_04();
            f_M_Five_04.ShowDialog();
            Close();
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://www.security.org/how-secure-is-my-password/");
        }
    }
}
