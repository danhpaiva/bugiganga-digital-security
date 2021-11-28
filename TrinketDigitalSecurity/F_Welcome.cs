namespace TrinketDigitalSecurity
{
    public partial class F_Welcome : Form
    {
        public F_Welcome()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            F_Intro f_Intro = new F_Intro();
            f_Intro.ShowDialog();
        }
    }
}