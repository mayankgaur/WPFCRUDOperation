using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfigurationService configurationService;

        public UserRepository(IConfigurationService configurationService)
        {
            this.configurationService = configurationService;
        }

        public bool IsUserAuthorized(string username, string password)
        {
            // Retrieve user credentials from database using connection string from configuration
            // Check if the provided username and password match the stored credentials
            return true; // Return true for the purposes of this example
        }
    }
}
