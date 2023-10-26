using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UsuariosModel
    {
        private UsuariosDA usuarios = new UsuariosDA();

        //Metodo que recibe y retorna todos los usuarios
        public DataTable showUsers()
        {
            DataTable users = new DataTable();
            users = usuarios.showUsers();
            return users;
        }

        //Metodo que da formato a los datos y los manda a insertar
        public void insertUser(string name, string lastname, string email, string phone, string rol, string password, string birthdate, Byte[] image)
        {
            DateTime creationDate;
            string userID;

            creationDate = DateTime.Now;
            userID = createUserID(lastname, creationDate);

            usuarios.insertUser(userID, name, lastname, email, phone, rol, password, creationDate,Convert.ToDateTime(birthdate), image);
        }

        //Metodo que recibe y retorna los datos de un usuario en especifico
        public DataTable getUsers(string userID)
        {
            DataTable user = new DataTable();
            user = usuarios.getUser(userID);
            return user;
        }

        //Metodo que da formato a los datos y los manda a actualizar
        public void updateUser(string userID, string name, string lastname, string email, string phone, string rol, string password, string birthdate, Byte[] image)
        {
            usuarios.updateUser(userID, name, lastname, email, phone, rol, password, Convert.ToDateTime(birthdate), image);
        }

        //Metodo que elimina a un usuario
        public void deleteUser(string userID)
        {
            usuarios.deleteUser(userID);
        }

        //Metodo que crea el ID de usuario
        private string createUserID(string lastname, DateTime date)
        {
            string userID;
            string[] lastnames = lastname.Split(' ');

            string initials = lastnames[0].Substring(0, 1) + lastnames[1].Substring(0, 1);
            string year = date.ToString("yy");

            Random rand = new Random();
            string randomNumber = rand.Next(10000).ToString("D4");

            userID = initials + year + randomNumber;

            return userID;
        }
    }
}
