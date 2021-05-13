using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreeBlazor.Services;


namespace ThreeBlazor.Pages
{
    public class DepartmentViewModel : ComponentBase
    {

        [Inject]
        protected IDepartmentService DepartmentService { get; set; }

        protected IEnumerable<ThreegRPCApi.Department> departments;
        protected override async Task OnInitializedAsync()
        {
            departments = await DepartmentService.GetAll();
        }
    }
}
