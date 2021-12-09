using System.Threading.Tasks;

namespace Tier3.Repositories.Employee
{
    public interface IEmployeeRepo
    {
        Task<Models.Employee.Employee> GetEmployee(string username, string password);
        Task DeleteEmployee(int employeeId);
        Task<Models.Employee.Employee> GetEmployeeByUsername(string username);
        Task<Models.Employee.Employee> GetEmployeeById(int employeeId);
        Task EditBurial(Models.Burial.Burial burial);
        Task DeleteBurial(int burialId);
        Task<Models.Burial.Burial> GetBurial(int burialId);
        Task AddPreferenceToBurial(int burialId, int preferenceId);
        Task DeletePreferenceFromBurial(int burialId, int preferenceId);
    }
}