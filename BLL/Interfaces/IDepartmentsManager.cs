using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDepartmentsManager
    {
        Task CreateDepartmentAsync(DepartmentsDto departmentDto);

        Task DeleteDepartmentAsync(int id);

        IEnumerable<DepartmentsDto> GetAllDepartments();

        Task UpdateDepartmentInfo(Departments departmentDto);

        Task<DepartmentsDto> GetDepartmentDtoByIdAsync(int id);
        Task<Departments> GetDepartmentByIdAsync(int id);

        List<EmployeesDto> GetDepartmnetEmployees(string departmentName);

        IEnumerable<EmployeesDto> GetAllDepartmentEmployees(string departmentName);
    }
}
