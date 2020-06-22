using System;
using System.Windows.Forms;

namespace Arkanoid.Controllers
{
    public static class ControllerScore
    {
        public static void AddScore(string nickname, int score)
        {
            try
            {
                string sql = $"INSERT INTO SCORE (score, nickname) VALUES ({score},'{nickname}')";
                DatabaseConnection.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}