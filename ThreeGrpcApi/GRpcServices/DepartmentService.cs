using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreegRPCApi;
using ThreeGrpcApi.Repositories;
using static ThreegRPCApi.Departments;

namespace ThreeGrpcApi.GRpcServices
{
    public class DepartmentService : DepartmentsBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async override Task<GetAllDepartmentsResponse>
            GetAll(GetAllDepartmentsRequest request, ServerCallContext context)
        {
            var result = new GetAllDepartmentsResponse();

            result.Departments.AddRange(await _departmentRepository.GetAll());

            return result;
        }

        public override async Task<AddDepartmentResponse>
            Add(AddDepartmentRequest request, ServerCallContext context)
        {
            return new AddDepartmentResponse
            {
                Department = await _departmentRepository.Add(request.Department)
            };
    }
    }
}
