using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Arkanoid.Models;

namespace Arkanoid.Controllers
{
    public static class ControllerPlayer
    {
        //Adds nickname
        public static void AddNickname(string nickname)
        {
            try
            {
                string sql = $"INSERT INTO PLAYER VALUES ('{nickname}')";
                DatabaseConnection.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred");
            }
        }
        
        //Adds score
        public static void AddScore(string nickname, int score)
        {
            try
            {
                string sql = $"INSERT INTO SCORE (score, nickname) VALUES ({score},'{nickname}')";
                DatabaseConnection.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred");
            }
        }

        //Gets the top players
        public static List<Player> TopPlayer()
        {
            var topPlayers = new List<Player>();
            try
            {
                DataTable dt = DatabaseConnection.ExecuteQuery("SELECT pl.nickname, sc.score FROM PLAYER pl, SCORE sc WHERE pl.nickname = sc.nickname ORDER BY sc.score DESC LIMIT 10");
                foreach (DataRow dr in dt.Rows)
                {
                    topPlayers.Add(new Player(dr[0].ToString(),dr[1].ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has ocurred");
            }
            return topPlayers;
        }
        
        //Gets all the nicknames on the database
        public static List<Player> NicknameList()
        {
            var nicknameList = new List<Player>();
            try
            {
                DataTable dt = DatabaseConnection.ExecuteQuery("SELECT pl.nickname FROM PLAYER pl");
                foreach (DataRow dr in dt.Rows)
                {
                    nicknameList.Add(new Player(dr[0].ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has ocurred");
            }
            return nicknameList;
        }
    }
}