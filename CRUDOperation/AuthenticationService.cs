using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool IsValidUser(string username, string password)
        {
            // Retrieve user from database by username
            User user = userRepository.GetUserByUsername(username);

            // Check if user exists and password is correct
            if (user != null && user.PasswordHash == HashPassword(password))
            {
                return true;
            }

            return false;
        }

        private string HashPassword(string password)
        {
            // Hash password using a secure hashing algorithm (e.g. BCrypt)
            // Return hashed password
            return string.Empty;
        }
    }
}
