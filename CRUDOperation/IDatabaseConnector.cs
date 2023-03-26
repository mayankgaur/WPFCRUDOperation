using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation
{
    public interface IDatabaseConnector
    {
        IEnumerable<Employee> GetData();
        void CreateData();
        void ReadData();
        void UpdateData();
        void DeleteData();
    }
}
