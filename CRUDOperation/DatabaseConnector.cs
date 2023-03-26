using System.Collections.Generic;
using System.Linq;

namespace CRUDOperation
{
    class DatabaseConnector: IDatabaseConnector
    {
        private readonly IConfigurationService configurationService;

        public DatabaseConnector(IConfigurationService configurationService)
        {
            this.configurationService = configurationService;
        }

        public IEnumerable<Employee> GetData()
        {
            // Retrieve data from database using connection string from configuration
            return Enumerable.Empty<Employee>();
        }

        public void CreateData()
        {
            // Perform create operation on database using connection string from configuration
        }

        public void ReadData()
        {
            // Perform read operation on database using connection string from configuration
        }

        public void UpdateData()
        {
            // Perform update operation on database using connection string from configuration
        }

        public void DeleteData()
        {
            // Perform delete operation on database using connection string from configuration
        }
    }
}
