using System.Collections.Generic;
using System.Threading.Tasks;
using ThreegRPCApi;

namespace ThreeBlazor.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAll();
        Task Add(Department department);
    }
}
