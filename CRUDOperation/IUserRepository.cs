using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation
{
    public interface IUserRepository
    {
        bool IsUserAuthorized(string username, string password);
    }
}
