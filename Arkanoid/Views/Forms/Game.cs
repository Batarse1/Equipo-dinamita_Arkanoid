using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Arkanoid.Controllers;
using Arkanoid.Models;
using Arkanoid.Views.UserControls;

namespace Arkanoid.Views.Forms
{
    public partial class Game : Form
    {
        public Game(string nickname)
        {
            InitializeComponent();
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //Create user control
            UserControl marioAndPlatformAndBricks = new MarioAndPlatformAndBricks();
            marioAndPlatformAndBricks.Dock = DockStyle.Fill;
            tableLayoutPanelGame.Controls.Add(marioAndPlatformAndBricks, 0,1);
            tableLayoutPanelGame.SetColumnSpan(marioAndPlatformAndBricks, 4);       
            tableLayoutPanelGame.SetRowSpan(marioAndPlatformAndBricks,3);
            //Add player values
            Player.nickname = nickname;
            Player.lives = "X3";
            Player.time = "Tiempo: 800";
            Player.score = "Puntaje: 0";
            //Add font
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Fonts/SuperMario256.ttf");
            var superMario256Font = new Font(pfc.Families[0],Height * 4 / 100); 
            //Add labels values
            lblClockTimer.Text = Player.time;
            lblClockTimer.Font = superMario256Font;
            lblClockTimer.Dock = DockStyle.Fill;
            lblClockTimer.FlatStyle = FlatStyle.Flat;
            lblClockTimer.Margin = new Padding(0, 0, 0, 0);
            lblClockTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.Text = Player.score;
            lblScore.Font = superMario256Font;
            lblScore.Dock = DockStyle.Fill;
            lblScore.FlatStyle = FlatStyle.Flat;
            lblScore.Margin = new Padding(0, 0, 0, 0);
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblLives.Text = Player.lives = "x3";
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
            //Change labels
            Player.time = Convert.ToString($"Tiempo: {Convert.ToInt32(lblClockTimer.Text.Substring(7)) - 1}");
            lblClockTimer.Text = Player.time;
            lblScore.Text = Player.score;
            lblLives.Text = Player.lives;
            //Time out
            if(Player.time.Equals("Tiempo: 0")){
                MessageBox.Show("Perdiste...");
                Application.Exit();
            }
        }
    }
}