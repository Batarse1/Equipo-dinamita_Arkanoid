using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controllers;
using Arkanoid.Models;

namespace Arkanoid.Views.UserControls
{
    public partial class MarioAndPlatformAndBricks : UserControl
    {
        private Brick[,] bricksMatrix;
        
        public MarioAndPlatformAndBricks()
        {
            InitializeComponent();
        }

        private void Mario_and_bricks_Load(object sender, EventArgs e)
        {
            int thickness =  SystemInformation.BorderSize.Width;
            int xAxis = 10;
            int yAxis = 5;
            int brickHeight = ((((Height - 2*thickness)*30)/100)/yAxis);
            int brickWidth = (Width - 2*thickness) / xAxis;
            int initialX = ((Width)-xAxis*brickWidth)/2;
            bricksMatrix = new Brick[xAxis,yAxis];
            for (int i = 0; i < xAxis; i++)
            {
                for (int j = 0; j < yAxis; j++)
                {
                    bricksMatrix[i,j] = new Brick();

                    if (j == 0)
                    {
                        bricksMatrix[i,j].hits = 2;
                    }
                    else
                    {
                        bricksMatrix[i,j].hits = 1;
                    }
                    bricksMatrix[i,j].BackgroundImage = Image.FromFile("../../Resources/brick.png");
                    bricksMatrix[i,j].BackgroundImageLayout = ImageLayout.Stretch;
                    bricksMatrix[i,j].Height = brickHeight;
                    bricksMatrix[i,j].Width = brickWidth;
                    bricksMatrix[i,j].Left = initialX + i * brickWidth;
                    bricksMatrix[i,j].Top = j * brickHeight;
                    bricksMatrix[i,j].Tag = "tileTag";
                    bricksMatrix[i,j].MouseMove += bricksMatrix_MouseMove;
                    Controls.Add(bricksMatrix[i,j]);
                }
            }
            int platformHeight = (Height - 2*thickness)*3 /100;
            int platformWidth = (Width - 2*thickness)*10 / 100;
            int heightDistance = (Height - 2*thickness)*1 /100;
            
            platform.BackgroundImage = Image.FromFile("../../Resources/brick.png");
            platform.BackgroundImageLayout = ImageLayout.Stretch;
            platform.Width = platformWidth;
            platform.Height = platformHeight;
            platform.Left = (Width - 2*thickness - platform.Width)/2;
            platform.Top = Height - 2*thickness - platformHeight - heightDistance;
            platform.MouseMove += platform_MouseMove;
            
            int marioHeight = (Height - 2*thickness)*20 /100;
            int marioWidth = (Width - 2*thickness)*6 / 100;
          
            mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/StandingMario.png");
            mario.BackgroundImageLayout = ImageLayout.Stretch;
            mario.Width = marioWidth;
            mario.Height = marioHeight;
            mario.Left = (Width - 2*thickness - marioWidth)/2;
            mario.Top = platform.Top-marioHeight;
            mario.MouseMove += mario_MouseMove;
            
            StaticAttributes.location=platform.Left;
        }

        private void MarioAndBricks_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = e.X;
        }
        private void platform_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = platform.Left + e.X;
        }
        private void mario_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = mario.Left + e.X;
        }
        private void bricksMatrix_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void MarioAndBricks_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int thickness = SystemInformation.BorderSize.Width;
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

        private void MarioAndBricks_KeyDown(object sender, KeyEventArgs e)
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
                case Keys.Space:
                    if (GameData.dirX > 0 && GameData.dirY < 0 && !GameData.gameInitiated)
                    {
                        mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/RightJumpingMario.png");
                    }
                    GameData.gameInitiated = true;
                    break;
            }
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

            if (!GameData.gameInitiated)
            {
                mario.Left = platform.Left + platform.Width/2 - mario.Width/2;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (GameData.gameInitiated)
            {
                mario.Left += GameData.dirX;
                mario.Top += GameData.dirY;
                collider2D();
            }
        }

        private void collider2D()
        {
            int thickness = SystemInformation.BorderSize.Width;
            int xAxis = 10;
            int yAxis = 5;
            if (mario.Bottom > Height)
            {
                Application.Exit();
            }

            if (mario.Left < 0 || mario.Right > Width - 2 * thickness)
            {
                GameData.dirX *= -1;
                if (GameData.dirX > 0)
                {
                    mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/RightJumpingMario.png");
                }
                else
                {
                    mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/LeftJumpingMario.png");
                }
                return;
            }

            if (mario.Bounds.IntersectsWith(platform.Bounds))
            {
                GameData.dirY *= -1;
                return;
            }
            
            for (int i=0;i<xAxis;i++)
            {
                for (int j = 0; j < yAxis; j++)
                {
                    if (bricksMatrix[i,j] != null && mario.Bounds.IntersectsWith(bricksMatrix[i,j].Bounds))
                    {
                        bricksMatrix[i,j].hits--;
                        if (bricksMatrix[i,j].hits == 0)
                        {
                            Controls.Remove(bricksMatrix[i,j]);
                            bricksMatrix[i, j] = null;
                        }
                        
                        GameData.dirY *= -1;
                        return;
                    }
                }
            }
        }
    }
}