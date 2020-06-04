using System;
using System.Windows.Forms;
using Arkanoid.Controllers;

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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ControllerNickname.AddNickname(txtNickname.Text);
            Game game = new Game(txtNickname.Text);
            game.Show();
            Hide();
        }
    }
}