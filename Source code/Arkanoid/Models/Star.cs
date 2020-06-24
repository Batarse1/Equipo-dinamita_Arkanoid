namespace Arkanoid.Models
{
    public static class Star
    {
        //Speed of the star Icon, a timer for when it's activated, a global verifier to see if it's initiated and another
        // global verifier, to check if it's effect has concluded
        public static bool starInitiated = false;
        public static int dirX = 6, dirY = 6;
        public static int time = 0;
        public static bool loseStar = false;
    }
}