using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreeBlazor.Services;

namespace ThreeBlazor.Pages
{
    public class EmployeeViewModel : ComponentBase
    {
        [Parameter]
        public string DepartmentId { get; set; }

        public IEnumerable<ThreegRPCApi.Employee> employees;

        [Inject]
        IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            employees = await EmployeeService.GetByDepartmentId(int.Parse(DepartmentId));
        }
    }
}
