using System.Threading.Tasks;

namespace Tier_1.Data.EmployeeService
{
    public interface IEmployeeService
    {
        Task<Models.Employee.Employee> GetEmployee(string username, string password);
        Task DeleteEmployee(int employeeId);
        Task<Models.Employee.Employee> GetEmployeeByUsername(string username);
        Task<Models.Employee.Employee> GetEmployeeById(int employeeId);
        Task DeleteBurial(int burialId);
        Task<Models.Burial.Burial> GetBurial(int burialId);
    }
}