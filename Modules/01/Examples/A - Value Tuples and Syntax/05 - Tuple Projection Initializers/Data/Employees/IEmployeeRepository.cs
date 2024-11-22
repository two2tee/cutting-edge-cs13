using System.Collections.Generic;

namespace Wincubate.CS10.Part1.Data.Employees
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        void Add( Employee employee );
    }
}
