﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Arkanoid.Views.Forms
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }
        private void Instructions_Load(object sender, EventArgs e)
        {
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //Instruccions background
            pictureBoxControls.BackgroundImage = Image.FromFile("../../Resources/Backgrounds/Instructions.png");
            pictureBoxToadMessage.BackgroundImage = Image.FromFile("../../Resources/Backgrounds/ToadMessage.png");
            pictureBoxPeachMessage.BackgroundImage = Image.FromFile("../../Resources/Backgrounds/PeachMessage.png");
            //Add font
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Fonts/SuperMario256.ttf");
            var superMario256Font4 = new Font(pfc.Families[0],Height * 4 / 100); 
            //Button return values
            btnReturn.BackColor = Color.LemonChiffon;
            btnReturn.Text = "RETURN";
            btnReturn.Font = superMario256Font4;
            btnReturn.Dock = DockStyle.Fill;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Margin = new Padding(11, 11, 11, 11);
            btnReturn.TextAlign = ContentAlignment.MiddleCenter;
            btnReturn.TabStop = false;
        }
        
        //The button that closes the application
        private void btnReturn_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
            Hide();
        }

        //When the form is closed abruptly, so It can close properly
        private void Instructions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}