using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation
{
    public interface IAuthenticationService
    {
        bool IsValidUser(string username, string password);
    }
}
