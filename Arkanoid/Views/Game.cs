using System;
using System.Windows.Forms;
using Arkanoid.Controllers;

namespace Arkanoid
{
    public partial class Game : Form
    {
        private UserControl current = null;
        public Game(string nickname)
        {
            InitializeComponent();
            //Maximize Window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            
            //Add PlatformMovement User Control
            current = new PlatformMovement();
            current.Dock = DockStyle.Fill;
            tableLayoutPanelGame.Controls.Add(current, 0,2);
            tableLayoutPanelGame.SetColumnSpan(current, 5);
        }

        private void tableLayoutPanelGame_MouseMove(object sender, MouseEventArgs e)
        {
            //TableLayoutColumnStyleCollection columnStyles = tableLayoutPanelGame.ColumnStyles;
            //TableLayoutRowStyleCollection rowStyles = tableLayoutPanelGame.RowStyles;
            if(e.Y>(tableLayoutPanelGame.RowStyles[0].Height*tableLayoutPanelGame.Height)/100){
                StaticAttributes.location = e.X;
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblClockTimer.Text = Convert.ToString(Convert.ToInt32(lblClockTimer.Text) - 1);
            if(lblClockTimer.Text.Equals("0")){
                MessageBox.Show("Perdiste...");
                Application.Exit();
            }
        }
    }
}