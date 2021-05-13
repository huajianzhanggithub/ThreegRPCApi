using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreeBlazor.Services;
using ThreegRPCApi;

namespace ThreeBlazor.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly Departments.DepartmentsClient _client;

        public DepartmentService(Departments.DepartmentsClient client)
        {
            _client = client;
        }
        public async Task Add(Department department)
        {
            await _client.AddAsync(new AddDepartmentRequest
            {
                Department = department
            });
    }

        public async Task<IEnumerable<Department>> GetAll()
        {
            var response = await _client.GetAllAsync(new GetAllDepartmentsRequest());
            return response.Departments;
        }
    }
}
