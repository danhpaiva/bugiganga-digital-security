using System;
using System.Windows.Forms;

namespace TrinketDigitalSecurity
{
    public partial class F_Module_One_01 : Form
    {
        public F_Module_One_01()
        {
            InitializeComponent();
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            lbl_answer_appears.Text = "O termo é usado para se referir à defesa de dados e à prática que assegura que\n" +
                "informações sigilosas possam ser acessadas somente por aqueles a quem estas se referem (em outras palavras, seus responsáveis de direito).\n" +
                "O principal objetivo da segurança da informação é a proteção dos ativos da informação. Isso engloba todas as informações\n" +
                "da empresa, dados de funcionarios e consumidores, relatórios, seja em meios tecnológicos ou físicos.";
        }
    }
}
