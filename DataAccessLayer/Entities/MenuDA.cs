﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Connection;
using Npgsql;

namespace DataAccessLayer.Entities
{
    public class MenuDA : ConnectionSql
    {
        DataTable menu = new DataTable();

        //Metodo para obtener los datos de la tabla Menu
        public DataTable showMenu()
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Menu ORDER BY PlatilloID DESC";

                    NpgsqlDataReader reader = command.ExecuteReader();

                    menu.Clear();
                    menu.Load(reader);
                    return menu;
                }
            }
        }

        //Metodo que inserta un registro al menu
        public void insertMenu(string name, string description, string state, double price)
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Menu (NombrePlatillo, DescripcionPlatillo, Estado, Precio) VALUES (@name, @description, @state, @price)";

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@price", price);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo que obtiene el valor de un registro del menu en especifico
        public DataTable getMenu(long dishID, string dishName) 
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Menu WHERE PlatilloID = @id OR NombrePlatillo = @Name";

                    command.Parameters.AddWithValue("@id", dishID);
                    command.Parameters.AddWithValue("@name", dishName);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    menu.Clear();
                    menu.Load(reader);
                    return menu;
                }
            }
        }

        //Metodo que actualiza el valor de un registro del menu
        public void updateMenu(long id, string name, string description, string state, double price)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE Menu SET NombrePlatillo = @name, DescripcionPlatillo = @description, Estado = @state, Precio = @price WHERE PlatilloID = @id";

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@price", price);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
