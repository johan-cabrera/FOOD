﻿using DataAccessLayer.Connection;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class UsuariosDA : ConnectionSql
    {
        DataTable users = new DataTable();

        //Metodo para obtener los datos de la tabla usuarios
        public DataTable showUsers()
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT UsuarioID, Nombres, Apellidos, Rol, Telefono, Correo FROM Usuarios";

                    NpgsqlDataReader reader = command.ExecuteReader();

                    users.Clear();
                    users.Load(reader);
                    return users;
                }
            }
        }

        //Metodo que inserta un nuevo usuario
        public void insertUser(string userID, string name, string lastname, string email, string phone, string rol, string password, DateTime creationDate, DateTime birthdate, Byte[] image)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Usuarios VALUES (@id, @name, @lastname, @email, @phone, @rol, @password, @creationDate, @birthDate, @image)";

                    command.Parameters.AddWithValue("@id", userID);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@creationdate", creationDate);
                    command.Parameters.AddWithValue("@birthdate", birthdate.Date);
                    command.Parameters.AddWithValue("@image", image);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo que obtiene los datos de un usuario en especifico
        public DataTable getUser(string userID)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Usuarios Where UsuarioID = @userId";

                    command.Parameters.AddWithValue("@userId", userID);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    users.Clear();
                    users.Load(reader);
                    return users;
                }
            }
        }

        //Metodo para actualizar los datos de un usuario
        public void updateUser(string userID, string name, string lastname, string email, string phone, string rol, string password, DateTime birthdate, Byte[] image)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE Usuarios SET Nombres = @name, Apellidos = @lastname, Correo = @email, Telefono = @phone, Rol = @rol, Contraseña = @password, FechaNacimiento = @birthDate, Imagen = @image WHERE UsuarioID = @ID";

                    command.Parameters.AddWithValue("@ID", userID);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@birthdate", birthdate.Date);
                    command.Parameters.AddWithValue("@image", image);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo para eliminar los datos de un usuario
        public void deleteUser(string userID)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "DELETE FROM Usuarios WHERE UsuarioID = @ID";
                    command.Parameters.AddWithValue("@ID", userID);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
