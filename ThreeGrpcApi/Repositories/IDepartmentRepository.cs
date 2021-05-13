using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreegRPCApi;
using ThreeGrpcApi.Models;

namespace ThreeGrpcApi.Repositories
{
    public interface IDepartmentRepository
    {
        Task<Department> Add(Department model);
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int departmentId);
    }
}
