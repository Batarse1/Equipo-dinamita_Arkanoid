using System;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;
using Arkanoid.Controllers;
using Arkanoid.Exceptions;
using Arkanoid.Models;
using Arkanoid.Views.UserControls;

namespace Arkanoid.Views.Forms
{
    public partial class Game : Form
    {
        private SoundPlayer music = new SoundPlayer();
        private Player player = null;
        private int idleCont = 0;
        private int notStart = 0;
        public Game(string nickname)
        {
            InitializeComponent();
            music.SoundLocation = "overworld-theme-super-mario-world.wav";
            //Add player values
            player = new Player(nickname,"X3","Time: 800","Score: 0");
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //Create user control
            UserControl marioAndPlatformAndBricks = new MarioAndPlatformAndBricks(player);
            marioAndPlatformAndBricks.Dock = DockStyle.Fill;
            tableLayoutPanelGame.Controls.Add(marioAndPlatformAndBricks, 0,1);
            tableLayoutPanelGame.SetColumnSpan(marioAndPlatformAndBricks, 4);       
            tableLayoutPanelGame.SetRowSpan(marioAndPlatformAndBricks,3);
            //Add pictureBoxLives
            pictureBoxLives.BackgroundImage = Image.FromFile("../../Resources/Life/MarioFace.png");
            pictureBoxLives.BackgroundImageLayout = ImageLayout.Stretch;
            //Add font
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Fonts/SuperMario256.ttf");
            var superMario256Font = new Font(pfc.Families[0],Height * 4 / 100); 
            //Add labels values
            lblClockTimer.Text = player.time;
            lblClockTimer.Font = superMario256Font;
            lblClockTimer.Dock = DockStyle.Fill;
            lblClockTimer.FlatStyle = FlatStyle.Flat;
            lblClockTimer.Margin = new Padding(0, 0, 0, 0);
            lblClockTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.Text = player.score;
            lblScore.Font = superMario256Font;
            lblScore.Dock = DockStyle.Fill;
            lblScore.FlatStyle = FlatStyle.Flat;
            lblScore.Margin = new Padding(0, 0, 0, 0);
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblLives.Text = player.lives = "x3";
            lblLives.Font = superMario256Font;
            lblLives.Dock = DockStyle.Fill;
            lblLives.FlatStyle = FlatStyle.Flat;
            lblLives.Margin = new Padding(0, 0, 0, 0);
            lblLives.TextAlign = ContentAlignment.MiddleLeft;
        }

        public void tableLayoutPanelGame_MouseMove(object sender, MouseEventArgs e)
        {
            //TableLayoutColumnStyleCollection columnStyles = tableLayoutPanelGame.ColumnStyles;
            //TableLayoutRowStyleCollection rowStyles = tableLayoutPanelGame.RowStyles;
            //Detect mouse move only in the game panel
            if(e.Y>(tableLayoutPanelGame.RowStyles[0].Height*tableLayoutPanelGame.Height)/100){
                StaticAttributes.location = e.X;
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit game
            Application.Exit();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            if (Star.time != 0)
            {
                Star.time--;
                if(Star.time == 0)
                {
                    if(GameData.dirX>0){
                        GameData.dirX = 3; 
                    }
                    else{
                        GameData.dirX = -3;
                    }
                    if (GameData.dirY > 0)
                    {
                        GameData.dirY = 4; 
                    }
                    else{
                        GameData.dirY = -4;
                    }
                    music.PlayLooping();
                    Star.loseStar = true;
                }
            }
            if (StaticAttributes.timer)
            {
                player.time = Convert.ToString($"Time: {Convert.ToInt32(lblClockTimer.Text.Substring(5)) - 1}");
                lblClockTimer.Text = player.time;
                lblScore.Text = player.score;
                lblLives.Text = player.lives;
                //Time out
                if(player.time.Equals("Time: 0")){
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
            }
            else
            {
                try
                {
                    if (NotStartedException())
                    {
                        throw new NotStartedException("Press space to start");
                    }
                    if (IdlePlayerException())
                    {
                        throw new IdlePlayerException("IDLE player detected");
                    }
                }
                catch (NotStartedException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (IdlePlayerException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
        private bool NotStartedException()
        {
            notStart++;
            if (notStart == 20)
            {
                notStart = 0;
                SendKeys.Send("{ESC}");
            }
            if (notStart != 15) return false;
            return true;
        }
        private bool IdlePlayerException()
        {
            if (StaticAttributes.oldLocation == StaticAttributes.location)
            {
                idleCont++;
            }
            else
            {
                StaticAttributes.oldLocation = StaticAttributes.location;
                idleCont=0;
            }

            if (idleCont == 35)
            {
                idleCont = 0;
                SendKeys.Send("{ESC}");
            }
            if (idleCont != 30) return false;
            return true;
        }
    }
}