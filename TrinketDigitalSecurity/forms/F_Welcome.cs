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
            Hide();
            F_Intro f_Intro = new F_Intro();
            f_Intro.ShowDialog();
            Close();
        }

        private void btn_home_page_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://github.com/danhpaiva/trinket-digital-security");
        }
    }
}