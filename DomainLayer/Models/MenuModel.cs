using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DomainLayer.Models
{
    public class MenuModel
    {
        private MenuDA menuDA = new MenuDA();

        //Metodo que recibe y retorna el menu
        public DataTable showMenu()
        {
            DataTable menu = new DataTable();
            menu = menuDA.showMenu();
            return menu;
        }

        //Metodo que da formato a los datos y los manda a insetar
        public bool insertMenu(string name, string description, string state, string priceS)
        {
            bool validate;
            double price;

            validate = double.TryParse(priceS, out price);

            if (validate)
            {
                menuDA.insertMenu(name, description, state, price);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo que recibe y retorna los datos de un registro del menu en especifico
        public DataTable getMenu(string dishID, string dishName)
        {
            DataTable menu = new DataTable();
            menu = menuDA.getMenu(long.Parse(dishID), dishName);
            return menu;
        }

        //Metodo que da formato a los datos y los manda a actualizar
        public bool updateMenu(string id, string name, string description, string state, string priceS)
        {
            bool validate;
            double price;

            validate = double.TryParse(priceS, out price);
            if (validate)
            {
                menuDA.updateMenu(long.Parse(id), name, description, state, price);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
