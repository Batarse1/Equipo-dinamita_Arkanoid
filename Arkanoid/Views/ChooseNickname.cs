using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class ChooseNickname : Form
    {
        public ChooseNickname()
        {
            InitializeComponent();
        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {
            lblNickname.Text=txtNickname.Text;
        }

        private void ChooseNickname_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
            Hide();
        }
    }
}