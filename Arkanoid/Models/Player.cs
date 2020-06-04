namespace Arkanoid.Models
{
    public class Player
    {
        public string nickname { get; set; }
        public int score { get; set; }

        public Player(string nickname, int score)
        {
            this.nickname = nickname;
            this.score = score;
        }
    }
}