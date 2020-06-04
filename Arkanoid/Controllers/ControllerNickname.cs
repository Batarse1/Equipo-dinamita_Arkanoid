using System;
using System.Windows.Forms;

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