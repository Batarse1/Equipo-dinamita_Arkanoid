﻿using System;
using System.Data;
using Npgsql;

namespace Arkanoid.Controllers
{
    public static class DatabaseConnection
    {
        private static string sConnection = "Server=127.0.0.1;" +
                                        "Port=5432;" +
                                        "UserId=postgres;" +
                                        "Password=carro0707;" +
                                        "Database=Proyecto;";
        
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