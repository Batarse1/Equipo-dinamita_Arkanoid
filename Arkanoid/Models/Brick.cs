using System.Windows.Forms;

namespace Arkanoid.Models
{
    public class Brick : PictureBox
    {
        public int hits { get; set; }

        public Brick() : base() { }
    }
}