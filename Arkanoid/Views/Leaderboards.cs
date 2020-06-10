using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Leaderboards : Form
    {
        public Leaderboards()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
            Hide();
        }
    }
}