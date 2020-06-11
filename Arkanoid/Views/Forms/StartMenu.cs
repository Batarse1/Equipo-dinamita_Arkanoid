using System;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;
using Arkanoid.Controllers;

namespace Arkanoid.Views.Forms
{
    public partial class StartMenu : Form
    {
        private SoundPlayer music = new SoundPlayer();
        public StartMenu()
        {
            InitializeComponent();
            //Music
            music.SoundLocation = "overworld-theme-super-mario-world.wav";
            if (StaticAttributes.music)
            {
                music.PlayLooping();
                StaticAttributes.music = true;
            }
        }
        //Play button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            ChooseNickname chooseNickname = new ChooseNickname();
            chooseNickname.Show();
            Hide();
        }
        //Leaderboards button
        private void btnLeaderboards_Click(object sender, EventArgs e)
        {
            Leaderboards leaderboards = new Leaderboards();
            leaderboards.Show();
            Hide();
        }
        //Instructions button
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            instructions.Show();
            Hide();
        }
        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Exit
        private void StartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //Add font
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Fonts/SuperMario256.ttf");
            var superMario256Font10 = new Font(pfc.Families[0],Height * 10 / 100); 
            var superMario256Font3 = new Font(pfc.Families[0],Height * 3 / 100); 
            //Label values
            lblTitle.Text = "Arkanoid by RIBAL";
            lblTitle.Font = superMario256Font10;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Margin = new Padding(0, 0, 0, 0);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            //Button Play values
            btnPlay.BackColor = Color.LemonChiffon;
            btnPlay.Text = "JUGAR";
            btnPlay.Font = superMario256Font3;
            btnPlay.Dock = DockStyle.Fill;
            btnPlay.FlatStyle = FlatStyle.Popup;
            btnPlay.Margin = new Padding(11, 11, 11, 11);
            btnPlay.TextAlign = ContentAlignment.MiddleCenter;
            //Button Leaderboards values
            btnLeaderboards.BackColor = Color.LemonChiffon;
            btnLeaderboards.Text = "PUNTAJES";
            btnLeaderboards.Font = superMario256Font3;
            btnLeaderboards.Dock = DockStyle.Fill;
            btnLeaderboards.FlatStyle = FlatStyle.Popup;
            btnLeaderboards.Margin = new Padding(11, 11, 11, 11);
            btnLeaderboards.TextAlign = ContentAlignment.MiddleCenter;
            //Button Instructions values
            btnInstructions.BackColor = Color.LemonChiffon;
            btnInstructions.Text = "INSTRUCIONES";
            btnInstructions.Font = superMario256Font3;
            btnInstructions.Dock = DockStyle.Fill;
            btnInstructions.FlatStyle = FlatStyle.Popup;
            btnInstructions.Margin = new Padding(11, 11, 11, 11);
            btnInstructions.TextAlign = ContentAlignment.MiddleCenter;
            //Button Exit values
            btnExit.BackColor = Color.LemonChiffon;
            btnExit.Text = "SALIR";
            btnExit.Font = superMario256Font3;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Margin = new Padding(11, 11, 11, 11);
            btnExit.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}