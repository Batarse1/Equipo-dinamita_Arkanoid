using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controllers;
using Arkanoid.Models;
using Arkanoid.Views.Forms;

namespace Arkanoid.Views.UserControls
{
    public partial class MarioAndPlatformAndBricks : UserControl
    {
        private Brick[,] bricksMatrix;
        private int number_of_bricks = 0;
        private bool finished = false;
        private Player player;
        public MarioAndPlatformAndBricks(Player _player)
        {
            player = _player;
            InitializeComponent();
        }

        private void Mario_and_bricks_Load(object sender, EventArgs e)
        {
            //Making bricks
            int thickness =  SystemInformation.BorderSize.Width;
            int xAxis = 10;
            int yAxis = 4;
            number_of_bricks = xAxis * yAxis;
            int brickHeight = ((((Height - 2*thickness)*40)/100)/yAxis);
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
                        bricksMatrix[i,j].BackgroundImage = Image.FromFile("../../Resources/Bricks/brick.png");
                    }
                    else
                    {
                        bricksMatrix[i,j].hits = 1;
                        bricksMatrix[i,j].BackgroundImage = Image.FromFile("../../Resources/Bricks/brokenBrick.png");
                    }
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
            
            //Making platform
            int platformHeight = (Height - 2*thickness)*3 /100;
            int platformWidth = (Width - 2*thickness)*10 / 100;
            int heightDistance = (Height - 2*thickness)*1 /100;
            
            platform.BackgroundImage = Image.FromFile("../../Resources/Platform/Platform.png");
            platform.BackgroundImageLayout = ImageLayout.Stretch;
            platform.Width = platformWidth;
            platform.Height = platformHeight;
            platform.Left = (Width - 2*thickness - platform.Width)/2;
            platform.Top = Height - 2*thickness - platformHeight - heightDistance;
            platform.MouseMove += platform_MouseMove;
            
            //Making Mario
            int marioHeight = (Height - 2*thickness)*12 /100;
            int marioWidth = (Width - 2*thickness)*3 / 100;
          
            mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/StandingMario.png");
            mario.BackgroundImageLayout = ImageLayout.Stretch;
            mario.Width = marioWidth;
            mario.Height = marioHeight;
            mario.Left = (Width - 2*thickness - marioWidth)/2;
            mario.Top = platform.Top-marioHeight;
            mario.MouseMove += mario_MouseMove;
            
            StaticAttributes.location=platform.Left;
        }
        //MouseMove event for empty places
        private void MarioAndBricks_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = e.X;
        }
        //MouseMove event for platform
        private void platform_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = platform.Left + e.X;
        }
        //MouseMove event for Mario
        private void mario_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = mario.Left + e.X;
        }
        private void bricksMatrix_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void MarioAndBricks_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Left and right arrow buttons
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
            //A, D and Space buttons
            int thickness =  SystemInformation.BorderSize.Width;
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (platform.Left - 10 >= 0)
                    {
                        StaticAttributes.location -= 20;
                    }
                    break;
                case Keys.D:
                    if (platform.Left + 10 <= Width - platform.Width - 2*thickness)
                    {
                        StaticAttributes.location += 20;
                    }
                    break;
                case Keys.Space:
                    if (GameData.dirX > 0 && GameData.dirY < 0 && !GameData.gameInitiated)
                    {
                        StaticAttributes.timer = true;    
                        mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/RightJumpingMario.png");
                    }
                    GameData.gameInitiated = true;
                    break;
            }
        }

        private void platformTimer_Tick(object sender, EventArgs e)
        {
            //Platform movement
            int thickness =  SystemInformation.BorderSize.Width;
            if (StaticAttributes.location-platform.Width/2 >= 0 && StaticAttributes.location-platform.Width/2 <= Width - platform.Width + 2*thickness)
            {
                platform.Left = StaticAttributes.location-platform.Width/2;
            }
            else if (StaticAttributes.location-platform.Width/2 < 0)
            {
                platform.Left = 0;
            }
            else{
                platform.Left = Width-platform.Width+2*thickness;
            }

            if (!GameData.gameInitiated)
            {
                mario.Left = platform.Left + platform.Width/2 - mario.Width/2;
            }
        }

        private void Collider2D_Tick(object sender, EventArgs e)
        {
            //Bricks collider
            if (GameData.gameInitiated)
            {
                int xAxis = 10;
                int yAxis = 4;
                for (int j = yAxis-1; j >= 0; j--)
                {
                    for (int i=0;i<xAxis;i++)
                    {
                        if(bricksMatrix[i,j] != null)
                        {
                            if (mario.Bounds.IntersectsWith(bricksMatrix[i,j].Bounds))
                            {
                                bricksMatrix[i,j].hits--;
                                if(bricksMatrix[i,j].hits == 1){
                                    bricksMatrix[i,j].BackgroundImage = Image.FromFile("../../Resources/Bricks/brokenBrick.png");
                                }
                                else{
                                    Controls.Remove(bricksMatrix[i,j]);
                                    bricksMatrix[i, j] = null;
                                    player.score = Convert.ToString($"Score: {Convert.ToInt32(player.score.Substring(6)) + 100}");
                                    number_of_bricks--;
                                    if (number_of_bricks == 0)
                                    {
                                        var NewScore = (Convert.ToInt32(player.time.Substring(5))+Convert.ToInt32(player.score.Substring(6)))*(Convert.ToInt32(player.lives.Substring(1))+1);
                                        ControllerPlayer.AddNickname(player.nickname);                                        
                                        ControllerPlayer.AddScore(player.nickname, NewScore);
                                        finished = true;
                                        Congratulations congratulations = new Congratulations(player);
                                        congratulations.Show();
                                        Hide();
                                    }
                                } 
                                GameData.dirY *= -1; 
                                return;
                            }
                        }
                    }
                }                
            }
        }

        private void MarioTimer_Tick_1(object sender, EventArgs e)
        {
            int thickness = SystemInformation.BorderSize.Width;
            if (GameData.gameInitiated)
            {
                //Movement of Mario
                mario.Left += GameData.dirX;
                mario.Top += GameData.dirY;
            }
            if (mario.Bottom > Height)
            {               
                int lives = Convert.ToInt16(player.lives.Substring(1)) - 1;
                if (lives<0 && !finished)
                {
                    ControllerPlayer.AddNickname(player.nickname);                                        
                    ControllerPlayer.AddScore(player.nickname, 0);
                    finished = true;
                    GameOver gameOver = new GameOver();
                    gameOver.Show();
                    Hide();
                }
                else
                {
                    //restart game
                    if (GameData.gameInitiated)
                    {
                        int marioHeight = (Height - 2*thickness)*12 /100;
                        player.lives = $"x{lives}";
                        GameData.gameInitiated = false;
                        mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/StandingMario.png");
                        mario.Top = platform.Top-marioHeight;
                        GameData.dirX = 3;
                        GameData.dirY = -4;
                    }
                }
            }
            else if (mario.Top < 0)
            {
                //Rebound with top screen
                GameData.dirY *= -1; 
                return;
            }
            else if (mario.Left < 0 || mario.Right > Width - 2 * thickness)
            {
                //Rebound with walls
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
            else if (mario.Bounds.IntersectsWith(platform.Bounds))
            {
                //Rebound with platform
                GameData.dirY *= -1;
                return;
            }
        }
    }
}