using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Controllers;
using Arkanoid.Models;

namespace Arkanoid
{
    public partial class MarioAndBricks : UserControl
    {
        private Brick[,] bricksMatrix;
            
        public MarioAndBricks()
        {
            InitializeComponent();
        }

        private void Mario_and_bricks_Load(object sender, EventArgs e)
        {
            int thickness =  SystemInformation.BorderSize.Width;
            int xAxis = 18;
            int yAxis = 5;
            int brickHeight = ((((Height - 2*thickness)*30)/100)/yAxis);
            int brickWidth = (Width - 2*thickness) / xAxis;
            int initialX = ((Width)-xAxis*brickWidth)/2;
            bricksMatrix = new Brick[xAxis,yAxis];
            for (int i = 0; i < xAxis; i++)
            {
                for (int j = 0; j < yAxis; j++)
                {
                    bricksMatrix[i,j] = new Brick();

                    if (j == 0)
                    {
                        bricksMatrix[i, j].hits = 2;
                    }
                    else
                    {
                        bricksMatrix[i, j].hits = 1;
                    }
                    bricksMatrix[i, j].BackgroundImage = Image.FromFile("../../Resources/brick.png");
                    bricksMatrix[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    bricksMatrix[i, j].Height = brickHeight;
                    bricksMatrix[i, j].Width = brickWidth;
                    bricksMatrix[i, j].Left = initialX + i * brickWidth;
                    bricksMatrix[i, j].Top = j * brickHeight;
                    bricksMatrix[i, j].Tag = "tileTag";
                    bricksMatrix[i, j].MouseMove += new System.Windows.Forms.MouseEventHandler(bricksMatrix_MouseMove);
                    Controls.Add(bricksMatrix[i,j]);
                }
            }
        }

        private void MarioAndBricks_MouseMove(object sender, MouseEventArgs e)
        {
            StaticAttributes.location = e.X;
        }
        private void bricksMatrix_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}