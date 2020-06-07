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
            int thickness =  SystemInformation.BorderSize.Width;
            if (StaticAttributes.location-platform.Width/2 >= 0 && StaticAttributes.location <= Width - platform.Width - 2*thickness)
            {
                platform.Left = StaticAttributes.location-platform.Width/2;
            }
            else if (StaticAttributes.location-platform.Width/2 < 0)
            {
                platform.Left = 0;
            }
            else{
                platform.Left = Width-platform.Width - 2*thickness;
            }
        }

        private void PlatformMovement_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = e.X;
        }

        private void PlatformMovement_KeyDown(object sender, KeyEventArgs e)
        {
            int thickness =  SystemInformation.BorderSize.Width;
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (platform.Left - 20 >= 0)
                    {
                        StaticAttributes.location -= 20;
                    }
                    break;
                case Keys.D:
                    if (platform.Left + 20 <= Width - platform.Width - 2*thickness)
                    {
                        StaticAttributes.location += 20;
                    }
                    break;
            }
        }

        private void PlatformMovement_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int thickness =  SystemInformation.BorderSize.Width;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (platform.Left - 10 >= 0)
                    {
                        StaticAttributes.location -= 20;
                    }
                    break;
                case Keys.Right:
                    if (platform.Left + 10 <= Width - platform.Width - 2*thickness)
                    {
                        StaticAttributes.location += 20;
                    }
                    break;
            }
        }

        private void platform_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = platform.Left + e.X;
        }

        private void PlatformMovement_Load(object sender, EventArgs e)
        {
            platform.Height=Height;
            platform.Left = (Width - platform.Width)/2;
            StaticAttributes.location=platform.Left;
        }
    }
}