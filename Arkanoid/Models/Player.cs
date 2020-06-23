namespace Arkanoid.Models
{
    public class Player
    {
        public string nickname { get; set; }
        public string lives { get; set; }
        public string time { get; set; }
        public string score { get; set; }

        public Player(string nickname, string lives, string time, string score)
        {
            this.nickname = nickname;
            this.lives = lives;
            this.time = time;
            this.score = score;
        }

        public Player(string nickname, string score)
        {
            this.nickname = nickname;
            this.score = score;
        }

        public Player(string nickname)
        {
            this.nickname = nickname;
        }
    }
}