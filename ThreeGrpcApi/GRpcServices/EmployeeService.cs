using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreegRPCApi;
using ThreeGrpcApi.Repositories;
using static ThreegRPCApi.Employees;

namespace ThreeGrpcApi.GRpcServices
{
    public class EmployeeService : EmployeesBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public override async Task<GetByDepartmentIdResponse>
            GetByDepartmentId(GetByDepartmentIdRequest request, ServerCallContext context)
        {
            var result = new GetByDepartmentIdResponse();
            var employees = await _employeeRepository.GetByDepartmentId(request.DepartmentId);
            result.Employees.AddRange(employees);
            return result;
        }

        public override async Task<AddEmployeeResponse>
            AddEmployee(AddEmployeeRequest request, ServerCallContext context)
        {
            return new AddEmployeeResponse
            {
                Employee = await _employeeRepository.Add(request.Employee)
            };
        }

        public override async Task<FireEmployeeResponse>
            FireEmployee(FireEmployeeRequest request, ServerCallContext context)
        {
            return new FireEmployeeResponse
            {
                Employee = await _employeeRepository.Fire(request.Id)
            };
        }
    }
}
