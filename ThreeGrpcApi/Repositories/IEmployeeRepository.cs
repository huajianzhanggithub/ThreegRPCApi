using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreegRPCApi;
using ThreeGrpcApi.Models;

namespace ThreeGrpcApi.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> Add(Employee employee);
        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
        Task<Employee> Fire(int id);
        Task<Employee> GetById(int id);
    }
}
