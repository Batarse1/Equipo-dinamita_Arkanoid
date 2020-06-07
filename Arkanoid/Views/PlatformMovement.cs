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
            platform.Height=Height;
        }

        private void platformTimer_Tick(object sender, EventArgs e)
        {
            if (StaticAttributes.location >= 0 && StaticAttributes.location <= Width-platform.Width)
            {
                platform.Left = StaticAttributes.location;
            }
            else if (StaticAttributes.location < 0)
            {
                platform.Left = 0;
            }
            else{
                platform.Left = Width-platform.Width;
            }
        }

        private void PlatformMovement_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = e.X;
        }

        private void PlatformMovement_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (platform.Left - 20 >= 0)
                    {
                        StaticAttributes.location -= 20;
                    }
                    break;
                case Keys.D:
                    if (platform.Left + 20 <= Width - platform.Width)
                    {
                        StaticAttributes.location += 20;
                    }
                    break;
            }
        }

        private void PlatformMovement_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (platform.Left - 10 >= 0)
                    {
                        StaticAttributes.location -= 20;
                    }
                    break;
                case Keys.Right:
                    if (platform.Left + 10 <= Width - platform.Width)
                    {
                        StaticAttributes.location += 20;
                    }
                    break;
            }
        }

        private void platform_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location += e.X;
        }
    }
}