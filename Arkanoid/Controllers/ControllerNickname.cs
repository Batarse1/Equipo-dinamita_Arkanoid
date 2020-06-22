using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Arkanoid.Models;

namespace Arkanoid.Controllers
{
    public static class ControllerNickname
    {
        public static void AddNickname(string nickname)
        {
            try
            {
                string sql = $"INSERT INTO PLAYER VALUES ('{nickname}')";
                DatabaseConnection.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

    }
}