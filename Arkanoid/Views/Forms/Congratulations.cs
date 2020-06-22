using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Arkanoid.Models;

namespace Arkanoid.Views.Forms
{
    public partial class Congratulations : Form
    {
        private Player player = null;
        public Congratulations(Player _player)
        {
            player = _player;
            InitializeComponent();
        }

        private void Congratulations_Load(object sender, EventArgs e)
        {
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //Add font
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Fonts/SuperMario256.ttf");
            var superMario256Font4 = new Font(pfc.Families[0],Height * 4 / 100); 
            var superMario256Font3 = new Font(pfc.Families[0],Height * 3 / 100); 
            //Button Menu values
            btnExit.BackColor = Color.LemonChiffon;
            btnExit.Text = "EXIT";
            btnExit.Font = superMario256Font3;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Margin = new Padding(11, 11, 11, 11);
            btnExit.TextAlign = ContentAlignment.MiddleCenter;
            //
            LblPlayer.ForeColor = Color.White;
            LblPlayer.Text = $"Player: {player.nickname}";
            LblPlayer.Font = superMario256Font3;
            LblPlayer.Dock = DockStyle.Fill;
            LblPlayer.FlatStyle = FlatStyle.Flat;
            LblPlayer.Margin = new Padding(0, 0, 0, 0);
            LblPlayer.TextAlign = ContentAlignment.MiddleCenter;
            //
            var NewScore = (Convert.ToInt32(player.time.Substring(5))+Convert.ToInt32(player.score.Substring(6)))*(Convert.ToInt32(player.lives.Substring(1))+1);
            
            lblScore.ForeColor = Color.White;
            lblScore.Text = $"Score: {NewScore}";
            lblScore.Font = superMario256Font3;
            lblScore.Dock = DockStyle.Fill;
            lblScore.FlatStyle = FlatStyle.Flat;
            lblScore.Margin = new Padding(0, 0, 0, 0);
            lblScore.TextAlign = ContentAlignment.MiddleCenter;           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}