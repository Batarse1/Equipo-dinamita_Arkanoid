using System;
using System.Windows.Forms;
using Arkanoid.Controllers;

namespace Arkanoid
{
    public partial class Game : Form
    {
        private UserControl current = null;
        public Game(string nickname)
        {
            InitializeComponent();
            current = new PlatformMovement();
            current.Dock = DockStyle.Fill;
            tableLayoutPanelGame.Controls.Add(current, 0,3);
            tableLayoutPanelGame.SetColumnSpan(current, 3);
        }

        private void tableLayoutPanelGame_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = e.X;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}