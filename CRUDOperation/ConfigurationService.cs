using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation
{
    public class ConfigurationService : IConfigurationService
    {
        public string GetConnectionString()
        {
            // Retrieve connection string from configuration
            return "connection_string_here";
        }
    }
}
