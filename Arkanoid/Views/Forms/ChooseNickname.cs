using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Arkanoid.Views.Forms;

namespace Arkanoid
{
    public partial class ChooseNickname : Form
    {
        public ChooseNickname()
        {
            InitializeComponent();
        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {
            lblNickname.Text=txtNickname.Text;
        }

        private void ChooseNickname_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
            Hide();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game game = new Game(txtNickname.Text);
            game.Show();
            Hide();
        }

        private void ChooseNickname_Load(object sender, EventArgs e)
        {
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //Add font
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Fonts/SuperMario256.ttf");
            var superMario256Font4 = new Font(pfc.Families[0],Height * 4 / 100); 
            //Button return values
            btnReturn.BackColor = Color.Snow;
            btnReturn.Text = "VOLVER";
            btnReturn.Font = superMario256Font4;
            btnReturn.Dock = DockStyle.Fill;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Margin = new Padding(0, 0, 0, 0);
            btnReturn.TextAlign = ContentAlignment.MiddleCenter;
            btnReturn.TabStop = false;
            //Button play values
            btnPlay.BackColor = Color.Snow;
            btnPlay.Text = "JUGAR";
            btnPlay.Font = superMario256Font4;
            btnPlay.Dock = DockStyle.Fill;
            btnPlay.FlatStyle = FlatStyle.Popup;
            btnPlay.Margin = new Padding(0, 0, 0, 0);
            btnPlay.TextAlign = ContentAlignment.MiddleCenter;
            btnPlay.TabStop = false;
            //Label values askfornickname
            lblAskForNickname.Text = "ALIAS";
            lblAskForNickname.Font = superMario256Font4;
            lblAskForNickname.Dock = DockStyle.Fill;
            lblAskForNickname.FlatStyle = FlatStyle.Flat;
            lblAskForNickname.Margin = new Padding(0, 0, 0, 0);
            lblAskForNickname.TextAlign = ContentAlignment.MiddleCenter;
            //Label values nickname
            lblNickname.Text = "";
            lblNickname.Font = superMario256Font4;
            lblNickname.Dock = DockStyle.Fill;
            lblNickname.FlatStyle = FlatStyle.Flat;
            lblNickname.Margin = new Padding(0, 0, 0, 0);
            lblNickname.TextAlign = ContentAlignment.MiddleCenter;
            //Label values nickname
            txtNickname.Font = superMario256Font4;
            txtNickname.Margin = new Padding(0, 0, 0, 0);
        }
    }
}