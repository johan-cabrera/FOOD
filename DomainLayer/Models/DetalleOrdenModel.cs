using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DomainLayer.Models
{
    public class DetalleOrdenModel
    {
        private DetalleOrdenDA detalleordenDA = new DetalleOrdenDA();
        private MenuDA menuDA = new MenuDA();

        //Metodo que recibe y retorna el detalle de las ordenes
        public DataTable showOrderDetails(string orderID)
        {
            DataTable orderDetails = new DataTable();
            orderDetails = detalleordenDA.showOrderDetails(long.Parse(orderID));
            return orderDetails;
        }

        //Metodo que da formato a los datos y los manda a insertar
        public bool insertOrderDetail(string orderID, string dish, string quantityS, string comment)
        { 
            bool validate;
            int quantity;
            long dishID;
            double unitPrice;

            DataTable dishValues = new DataTable();
            dishValues = menuDA.getMenu(0, dish);
            if(dishValues.Rows.Count != 0)
            {
                DataRow row = dishValues.Rows[0];

                dishID = long.Parse(row["PlatilloID"].ToString());
                unitPrice = double.Parse(row["Precio"].ToString());

                if (string.IsNullOrEmpty(comment)) comment = " - ";


                validate = int.TryParse(quantityS, out quantity);
                if (validate)
                {
                    detalleordenDA.insertOrderDetail(long.Parse(orderID), dishID, quantity, unitPrice, comment);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
            

        }

        //Metodo que elimina un registro de la tabla detalle orden
        public void deleteOrderDetail(string orderDetailID)
        {
            detalleordenDA.deleteOrderDetail(long.Parse(orderDetailID));
        }
    }
}
