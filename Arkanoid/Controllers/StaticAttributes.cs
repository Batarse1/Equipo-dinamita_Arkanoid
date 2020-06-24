using System.Windows.Forms;

namespace Arkanoid.Controllers
{
    public static class StaticAttributes
    {
        //Multiple global verifiers that are self explanatory by their name
        public static bool music = false;
        //Saves the current location of the mouse in the "Game" form
        public static int location = 0;
        //Saves the most recent location of the mouse in the "Game" form
        public static int oldLocation = 0;
        public static bool timer = false;
        public static bool nicknameRepeated = false;
        public static bool finished = false;
    }
}