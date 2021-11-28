namespace TrinketDigitalSecurity
{
    public partial class F_M_One_02 : Form
    {
        public F_M_One_02()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            F_M_One_01 f_M_One_01 = new F_M_One_01();
            f_M_One_01.ShowDialog();
            this.Close();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            F_M_One_01 f_M_One_01 = new F_M_One_01();
            f_M_One_01.ShowDialog();
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
           F_M_One_03 f_M_One_03 = new F_M_One_03();
            f_M_One_03.ShowDialog();
            this.Close();
        }

        private void bnt_popup_01_Click(object sender, EventArgs e)
        {
            F_Popup_01 f_Popup_01 = new F_Popup_01();
            f_Popup_01.ShowDialog();
        }

        private void btn_popup_02_Click(object sender, EventArgs e)
        {
            F_Popup_02 f_Popup_02 = new F_Popup_02();
            f_Popup_02.ShowDialog();
        }

        private void btn_popup_03_Click(object sender, EventArgs e)
        {
            F_Popup_03 f_Popup_03 = new F_Popup_03();   
            f_Popup_03.ShowDialog();
        }
    }
}
