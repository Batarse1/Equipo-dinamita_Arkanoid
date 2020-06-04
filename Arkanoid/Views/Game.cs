using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Game : Form
    {
        public Game(string nickname)
        {
            InitializeComponent();
        }

        private void Game_mouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <= Width-Platform.Width)
            {
                Platform.Left = e.X;
            }
        }
    }
}