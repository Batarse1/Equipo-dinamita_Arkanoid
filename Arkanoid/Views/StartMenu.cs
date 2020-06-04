using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arkanoid.Controllers;

namespace Arkanoid
{
    public partial class StartMenu : Form
    {
        private SoundPlayer music = new SoundPlayer();
        public StartMenu()
        {
            InitializeComponent();
            music.SoundLocation = "overworld-theme-super-mario-world.wav";
            if (StaticAttributes.music == false)
            {
                music.PlayLooping();
                StaticAttributes.music = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ChooseNickname chooseNickname = new ChooseNickname();
            chooseNickname.Show();
            Hide();
        }
        
        private void btnLeaderboards_Click(object sender, EventArgs e)
        {
            Leaderboards leaderboards = new Leaderboards();
            leaderboards.Show();
            Hide();
        }
        
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            instructions.Show();
            Hide();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        
        private void StartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}