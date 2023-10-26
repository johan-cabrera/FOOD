using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Connection;
using System.Data;
using CommonUtility.Cache;

namespace DataAccess.Entities
{
    public class LoginUser : ConnectionSql 
    {
        public bool Login(string user, string pass)
        {
            //Se crea la conexion
            using(SqlConnection conn = getConnection())
            {
                conn.Open();

                //Se crea el comando para verificar usuario y contraseña
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Usuarios WHERE UsuarioID=@user AND Contraseña=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //Se añaden los datos de inicio de sesion al cache
                        while (reader.Read())
                        {
                            AttributesUser.UserID = reader["UsuarioID"].ToString();
                            AttributesUser.Name = reader["Nombres"].ToString();
                            AttributesUser.LastName = reader["Apellidos"].ToString();
                            AttributesUser.Email = reader["Correo"].ToString();
                            AttributesUser.Rol = reader["Rol"].ToString();
                            AttributesUser.Image = (byte[])reader["Imagen"];
                        }
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        return false;
                    }
                }
            }
        }
    }
}
