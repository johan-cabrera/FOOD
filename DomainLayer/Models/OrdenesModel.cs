using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class OrdenesModel
    {
        private OrdenesDA ordenesDA = new OrdenesDA();

        //Metodo que recibe y retorna las ordenes
        public DataTable showOrders()
        {
            DataTable orders = new DataTable();
            orders = ordenesDA.showOrders();
            return orders;
        }

        //Metodo que manda a insertar un registro y devuelve el id generado
        public int inserOrder()
        {
            return ordenesDA.insertOrder();
        }

        //Metodo que obtiene el valor de un registro de las ordenes en especifico
        public DataTable getOrder(string orderID)
        {
            DataTable order = new DataTable();
            order = ordenesDA.getOrder(Convert.ToInt32(orderID));
            return order;
        }

        //Metodo que da formato a los datos y los manda a actualizar
        public bool updateOrders(string orderID, string tableID, string state, string quantityS)
        {
            bool validate;
            int quantity;

            validate = int.TryParse(quantityS, out quantity);

            if (validate)
            {
                ordenesDA.updateOrder(int.Parse(orderID), tableID, state, quantity);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
