using System;
using System.Data;
using Npgsql;

namespace Arkanoid.Controllers
{
    public static class DatabaseConnection
    {
        private static string host = "ec2-34-232-147-86.compute-1.amazonaws.com",
            dataBase = "dfpsc1c2f4adr0",
            userID = "pjhyomijchhxwh",
            Password = "20a71ac26aeba3d7d34d4f634466805b544eebc3a1c4da79407a0e48e177d2cb";


        private static string sConnection =
            $"Server={host};Port=5432;User Id={userID};Password={Password};Database={dataBase};" +
            "sslmode=Require;Trust Server Certificate=true ";


        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();

            return ds.Tables[0];

        }

        public static void ExecuteNonQuery(string act)
        {
            Console.WriteLine(sConnection);
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}