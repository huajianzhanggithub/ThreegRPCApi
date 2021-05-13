using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreeGrpcApi.Repositories;
using ThreeGrpcApi.Models;
using ThreegRPCApi;

namespace ThreeGrpcApi.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly List<Department> _departments = new();
        public DepartmentRepository()
        {
            _departments.AddRange(
               new Department[]
               {
                   new Department
                    {
                        Id = 1,
                        Name = "HR",
                        EmployeeCount = 16,
                        Location = "Beijing"
                    },
                    new Department
                    {
                        Id = 2,
                        Name = "R&D",
                        EmployeeCount = 52,
                        Location = "Shanghai"
                    },
                    new Department
                    {
                        Id = 3,
                        Name = "Sales",
                        EmployeeCount = 200,
                        Location = "China"
                    }
               });
        }
        public Task<Department> Add(Department department)
        {
            department.Id = _departments.Max(x => x.Id) + 1;
            _departments.Add(department);
            return Task.Run(() => department);
        }

        public Task<IEnumerable<Department>> GetAll()
        {
            return Task.Run(() => _departments.AsEnumerable());
        }

        public Task<Department> GetById(int id)
        {
            return Task.Run(() => _departments.FirstOrDefault(x => x.Id == id));
        }
    }
}
