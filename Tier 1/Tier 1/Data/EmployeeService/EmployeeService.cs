using System.Threading.Tasks;
using Tier_1.Models.Burial;
using Tier_1.Models.Employee;

namespace Tier_1.Data.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        public Task<Employee> GetEmployee(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> GetEmployeeByUsername(string username)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int employeeId)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBurial(int burialId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Burial> GetBurial(int burialId)
        {
            throw new System.NotImplementedException();
        }
    }
}