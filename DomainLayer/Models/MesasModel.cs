using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DomainLayer.Models
{
    public class MesasModel
    {
        private MesasDA mesas = new MesasDA();

        //Metodo que recibe y retorna todas las mesas
        public DataTable showTables()
        {
            DataTable tables = new DataTable();
            tables = mesas.showTables();
            return tables;
        }

        //Metodo que da formato a los datos y los manda a insertar
        public bool insertTable(int number, string capacity, string state)
        {
            string tableID;

            tableID = createTableID(number);

            if(getTables(tableID).Rows.Count == 0)
            {
                mesas.insertTable(tableID, capacity, state);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo que recibe y retorna los datos de una mesa en especifico
        public DataTable getTables(string tableID) 
        {
            DataTable table = new DataTable();
            table = mesas.GetTable(tableID);
            return table;
        }

        //Metodo que da formato a los datos y los manda a actualizar
        public bool updateTable(string currentId, int number, string capacity, string state)
        {
            string newId;

            newId = createTableID(number);

            if (getTables(newId).Rows.Count == 0 || newId == currentId)
            {
                mesas.updateTable(currentId, newId, capacity, state);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo que elimina el usuario
        public void deleteTable(string tableId)
        {
            mesas.deleteTable(tableId);
        }

        //Metodo que crea el ID de la tabla
        public string createTableID(int number)
        {
            string tableID = string.Format("M{0:D5}", number);
            return tableID;
        }

    }
}
