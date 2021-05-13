using System.Collections.Generic;
using System.Threading.Tasks;
using ThreegRPCApi;

namespace ThreeBlazor.Services
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);
        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
        Task<Employee> Fire(int id);
    }
}
