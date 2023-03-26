using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation
{
    public class DataService : IDataService
    {
        private readonly IDatabaseConnector database;

        public DataService(IDatabaseConnector database)
        {
            this.database = database;
        }

        public IEnumerable<Employee> GetData()
        {
            return database.GetData();
        }

        public void CreateData()
        {
            // Perform create operation on database
            database.CreateData();
        }

        public void ReadData()
        {
            // Perform read operation on database
            database.ReadData();
        }

        public void UpdateData()
        {
            // Perform update operation on database
            database.UpdateData();
        }

        public void DeleteData()
        {
            // Perform delete operation on database
            database.DeleteData();
        }
    }
}
