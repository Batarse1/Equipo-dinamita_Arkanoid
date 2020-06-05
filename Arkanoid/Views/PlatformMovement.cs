using System.Windows.Forms;

namespace Arkanoid
{
    public partial class PlatformMovement : UserControl
    {
        private MouseEventArgs mouse;
        public PlatformMovement(MouseEventArgs e)
        {
            mouse = e;
            InitializeComponent();
        }
    }
}