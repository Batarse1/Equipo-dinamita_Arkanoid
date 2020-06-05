using System;
using System.Windows.Forms;
using Arkanoid.Controllers;

namespace Arkanoid
{
    public partial class PlatformMovement : UserControl
    {
        public PlatformMovement()
        {
            InitializeComponent();
        }

        private void platformTimer_Tick(object sender, EventArgs e)
        {
            if (StaticAttributes.location <= Width-platform.Width)
            {
                platform.Left = StaticAttributes.location;
            }
        }
    }
}