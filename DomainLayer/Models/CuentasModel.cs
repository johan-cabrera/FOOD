using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class CuentasModel
    {
        CuentasDA cuentasDA = new CuentasDA();
        OrdenesDA ordenesDA = new OrdenesDA();

        //Metodo que recibe y retorna el subtotal
        public double getSubTotal(string id)
        {
            return cuentasDA.getSubTotal(long.Parse(id));
        }

        //Metodo que recibe y retorna las cuentas
        public DataTable showBill()
        {
            DataTable bill = new DataTable();
            bill = cuentasDA.showBill();
            return bill;
        }

        //Metodo que da formato a los datos y los manda a insertar
        public void insertBill(string orderID, DateTime date, string subtotal, string tip, string discount, string total)
        {
            cuentasDA.insertBill(long.Parse(orderID), date, double.Parse(subtotal), double.Parse(tip), double.Parse(discount), double.Parse(total));
        }

        //Metodo que obtiene el valor de un registro de las ordenes por mesaID que no este cancelado o cerrado
        public DataTable getTablesInOrders()
        {
            DataTable tables = new DataTable();
            tables = cuentasDA.getTablesInOrders();
            return tables;
        }

        public DataTable getOrderByTableID(string tableID)
        {
            DataTable orders = new DataTable();
            orders = cuentasDA.getOrderByTableID(tableID);
            return orders;
        }

        public DataTable getBill(string billID)
        {
            DataTable bill = new DataTable();
            bill = cuentasDA.getBill(long.Parse(billID));
            return bill;
        }

        public void updateBill(string billID, string orderID, string state)
        {
            DataTable order = ordenesDA.getOrder(long.Parse(orderID));
            DataRow row = order.Rows[0];
            cuentasDA.updateBill(long.Parse(billID), state);
            if(state == "Cancelado") ordenesDA.updateOrder(long.Parse(orderID), row["MesaID"].ToString(), "Cerrada", int.Parse(row["CantidadClientes"].ToString()));
        }

        public DataTable receiptBill(string orderID)
        {
            DataTable receipt = new DataTable();
            receipt = cuentasDA.receiptBill(long.Parse(orderID));
            return receipt;
        }
    }
}
