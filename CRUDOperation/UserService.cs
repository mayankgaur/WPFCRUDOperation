using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool Login(string username, string password)
        {
            // Check if user is authorized to login
            bool isAuthorized = userRepository.IsUserAuthorized(username, password);

            // Return true if authorized, otherwise false
            return isAuthorized;
        }
    }
}
