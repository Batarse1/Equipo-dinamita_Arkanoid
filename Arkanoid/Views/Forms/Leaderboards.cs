using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Arkanoid.Controllers;
using Arkanoid.Models;

namespace Arkanoid.Views.Forms
{
    public partial class Leaderboards : Form
    {    
        //Initialazing the Label arrays
        private Label[] nicknameLabels;
        private Label[] scoreLabels;
        public Leaderboards()
        {
            InitializeComponent();
        }
        
        //A button that takes you back to the main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
            Hide();
        }

        private void Leaderboards_Load(object sender, EventArgs e)
        {
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //ImageBackground
            BackgroundImage = Image.FromFile("../../Resources/Backgrounds/Leaderboards.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            //Add font
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Fonts/SuperMario256.ttf");
            var superMario256Font3 = new Font(pfc.Families[0],Height * 3 / 100); 
            //label
            Label lblLeaderboards = new Label();
            lblLeaderboards.Text = "Leaderboards";
            lblLeaderboards.Font = superMario256Font3;
            lblLeaderboards.Dock = DockStyle.Fill;
            lblLeaderboards.FlatStyle = FlatStyle.Flat;
            lblLeaderboards.Margin = new Padding(0, 0, 0, 0);
            lblLeaderboards.TextAlign = ContentAlignment.MiddleCenter;
            lblLeaderboards.ForeColor = Color.White;
            tableLayoutShowLeaderboard.Controls.Add(lblLeaderboards, 3,0);
            tableLayoutShowLeaderboard.SetColumnSpan(lblLeaderboards,2);
            //label array
            List<Player> topPlayers = ControllerPlayer.TopPlayer();
            int topPlayersCount = topPlayers.Count;
            nicknameLabels = new Label[topPlayersCount];
            scoreLabels = new Label[topPlayersCount];
            for (var i = 0; i < topPlayersCount ; i++)
            {
                nicknameLabels[i] = new Label();
                scoreLabels[i] = new Label();
                
                nicknameLabels[i].Text = topPlayers[i].nickname;
                nicknameLabels[i].Font = superMario256Font3;
                nicknameLabels[i].Dock = DockStyle.Fill;
                nicknameLabels[i].FlatStyle = FlatStyle.Flat;
                nicknameLabels[i].Margin = new Padding(0, 0, 0, 0);
                nicknameLabels[i].TextAlign = ContentAlignment.MiddleLeft;
                nicknameLabels[i].ForeColor = Color.White;
                
                scoreLabels[i].Text = topPlayers[i].score;
                scoreLabels[i].Font = superMario256Font3;
                scoreLabels[i].Dock = DockStyle.Fill;
                scoreLabels[i].FlatStyle = FlatStyle.Flat;
                scoreLabels[i].Margin = new Padding(0, 0, 0, 0);
                scoreLabels[i].TextAlign = ContentAlignment.MiddleRight;
                scoreLabels[i].ForeColor = Color.White;
                
                tableLayoutShowLeaderboard.Controls.Add(nicknameLabels[i], 3,i+2);
                tableLayoutShowLeaderboard.Controls.Add(scoreLabels[i], 4,i+2);
            }
            //Button return values
            btnReturn.BackColor = Color.LemonChiffon;
            btnReturn.Text = "RETURN";
            btnReturn.Font = superMario256Font3;
            btnReturn.Dock = DockStyle.Fill;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Margin = new Padding(11, 11, 11, 11);
            btnReturn.TextAlign = ContentAlignment.MiddleCenter;
            btnReturn.TabStop = false;
        }

        //When the form is closed abruptly, so It can close properly
        private void Leaderboards_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}