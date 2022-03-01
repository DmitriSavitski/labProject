using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEmployeesManages
    {
        Task CreateEmployeeAsync(EmployeesDto employeeDto);

        Task DeleteEmployeeAsync(int employeeId);

        IEnumerable<EmployeesDto> GetAllEmployees();

        IEnumerable<EmployeesDto> GetAllDepartmentEmployees(string departmentName);

        Task UpdateEmployeeInfo(EmployeesDto employeeDto);

        Task<EmployeesDto> GetEmployeeByIdAsync(int id);

        IEnumerable<EmployeesDto> GetAllDepartmentByIdEmployees(int id);
    }
}
