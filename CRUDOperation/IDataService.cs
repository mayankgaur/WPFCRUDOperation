using System.Collections.Generic;
using System.Data;

namespace CRUDOperation
{
    public interface IDataService
    {
        IEnumerable<Employee> GetData();
        void CreateData();
        void ReadData();
        void UpdateData();
        void DeleteData();
    }
}
