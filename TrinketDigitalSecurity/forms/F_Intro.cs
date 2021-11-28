namespace TrinketDigitalSecurity
{
    public partial class F_Intro : Form
    {
        public F_Intro()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_Menu_Modules f_Menu_Modules = new F_Menu_Modules();
            f_Menu_Modules.ShowDialog(this);
            this.Close();
        }
    }
}
