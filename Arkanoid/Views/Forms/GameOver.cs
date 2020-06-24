using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Arkanoid.Views.Forms
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

       private void GameOver_Load(object sender, EventArgs e)
        {
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //Add font
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Fonts/SuperMario256.ttf");
            var superMario256Font3 = new Font(pfc.Families[0],Height * 3 / 100); 
            //Button Menu values
            btnExit.BackColor = Color.LemonChiffon;
            btnExit.Text = "EXIT";
            btnExit.Font = superMario256Font3;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Margin = new Padding(11, 11, 11, 11);
            btnExit.TextAlign = ContentAlignment.MiddleCenter;
        }

       //The button that closes the application
       private void btnExit_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }
        
       //When the form is closed abruptly, so It can close properly
       private void GameOver_FormClosing(object sender, FormClosingEventArgs e)
       {
           Application.Exit();
       }
    }
}