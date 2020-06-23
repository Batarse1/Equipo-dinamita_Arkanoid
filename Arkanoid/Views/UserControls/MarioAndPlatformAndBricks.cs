using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Arkanoid.Controllers;
using Arkanoid.Models;
using Arkanoid.Views.Forms;

namespace Arkanoid.Views.UserControls
{
    public partial class MarioAndPlatformAndBricks : UserControl
    {
        private SoundPlayer starMusic = new SoundPlayer();
        private Brick[,] bricksMatrix;
        private PictureBox star = new PictureBox();
        private int number_of_bricks = 0;
        private Player player;
        public MarioAndPlatformAndBricks(Player _player)
        {
            player = _player;
            InitializeComponent();
        }

        private void Mario_and_bricks_Load(object sender, EventArgs e)
        {        
            //Making bricks
            starMusic.SoundLocation = "super-mario-bros-nes-music-star-theme-cut.wav";
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
            //Making star
            int StarWidth = (Height - 2*thickness)*10 /100;;
            int StarHeight = StarWidth;
            int StarLeft = 0;
            int StarTop = 0;
            star.BackgroundImage = Image.FromFile("../../Resources/Star/Star.png");
            star.BackgroundImageLayout = ImageLayout.Stretch;
            star.Width = StarWidth;
            star.Height = StarHeight;
            star.Left = StarLeft;
            star.Top = StarTop;

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
            if (GameData.gameInitiated || Star.starInitiated)
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
                                    player.score = Convert.ToString($"Score: {Convert.ToInt32(player.score.Substring(6)) + 100}");
                                }
                                else{
                                    Controls.Remove(bricksMatrix[i,j]);
                                    bricksMatrix[i, j] = null;
                                    player.score = Convert.ToString($"Score: {Convert.ToInt32(player.score.Substring(6)) + 100}");
                                    number_of_bricks--;
                                    if (number_of_bricks == 0)
                                    {
                                        StaticAttributes.finished = true;
                                        var NewScore = (Convert.ToInt32(player.time.Substring(5))+Convert.ToInt32(player.score.Substring(6)))*(Convert.ToInt32(player.lives.Substring(1))+1);
                                        if(!StaticAttributes.nicknameRepeated){
                                            ControllerPlayer.AddNickname(player.nickname);                                                                                                                        
                                        }
                                        ControllerPlayer.AddScore(player.nickname, NewScore);
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
            if(Convert.ToInt32(player.time.Substring(5)) == 500)
            {
                Star.starInitiated = true;
                Controls.Add(star);
            }
            if (GameData.gameInitiated)
            {
                //Movement of Mario
                mario.Left += GameData.dirX;
                mario.Top += GameData.dirY;
            }
            if (Star.starInitiated)
            {
                star.Left += Star.dirX;
                star.Top += Star.dirY;
            }
            if (mario.Bottom > Height)
            {               
                int lives = Convert.ToInt16(player.lives.Substring(1)) - 1;
                if (lives<0 && !StaticAttributes.finished)
                {
                    StaticAttributes.finished = true;
                    if (!StaticAttributes.nicknameRepeated)
                    {
                        ControllerPlayer.AddNickname(player.nickname);                                                                
                    }
                    ControllerPlayer.AddScore(player.nickname, 0);
                    GameOver gameOver = new GameOver();
                    gameOver.Show();
                    Hide();
                }
                else
                {
                    //restart game
                    if (Star.time != 0)
                    {
                        starMusic.Stop();
                        Star.time =1;
                    }
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
            }
            else if (mario.Left < 0 || mario.Right > Width - 2 * thickness)
            {
                //Rebound with walls
                GameData.dirX *= -1;
                if (GameData.dirX > 0)
                {
                    if(Star.time!=0){
                        mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/RightJumpingMarioStar.png");
                    }
                    else{
                        mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/RightJumpingMario.png");
                    }
                }
                else
                {
                    if(Star.time!=0){
                        mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/LeftJumpingMarioStar.png");
                    }
                    else
                    {
                        mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/LeftJumpingMario.png");
                    }
                }
            }
            else if (mario.Bounds.IntersectsWith(platform.Bounds))
            {
                //Rebound with platform
                GameData.dirY *= -1;
            }
            if (star.Bottom > Height)
            {
                star.Dispose();
            }
            else if(star.Top<0)
            {
                Star.dirY *= -1;
            }
            else if(star.Left < 0 || star.Right > Width - 2 * thickness)
            {
                Star.dirX *= -1;
            }
            else if (star.Bounds.IntersectsWith(platform.Bounds))
            {
                Star.dirY *= -1;
            }
            if (mario.Bounds.IntersectsWith(star.Bounds) && GameData.gameInitiated && Star.starInitiated)
            {
                starMusic.Play();
                Star.time=12;
                if(GameData.dirX>0)
                {
                    GameData.dirX = 10;                        
                    mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/RightJumpingMarioStar.png");                
                }
                else{
                    GameData.dirX = -10;
                    mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/LeftJumpingMarioStar.png");
                }
                if(GameData.dirY>0){
                    GameData.dirY = 10;
                }
                else{
                    GameData.dirY = -10;
                }
                star.Dispose();
            }
            if(Star.loseStar){
                if(GameData.dirX>0)
                {                      
                    mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/RightJumpingMario.png");                
                }
                else{
                    mario.BackgroundImage = Image.FromFile("../../Resources/MarioSprites/LeftJumpingMario.png");
                }
                Star.loseStar = false;
            }
        }
    }
}