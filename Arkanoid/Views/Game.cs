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
        {     //hola :v
            if (e.X <= Width-Platform.Width)
            {
                Platform.Left = e.X;
            }
        }
    }
}