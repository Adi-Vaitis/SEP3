using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tier3.DataAccess;

namespace Tier3.Repositories.Employee
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private DataBaseContext dbCtx;

        public async Task<Models.Employee.Employee> GetEmployee(string username, string password)
        {
            try
            {
                await using (dbCtx = new DataBaseContext())
                {
                    return dbCtx.Employees
                        .First(c => c.Username.Equals(username) && c.Password.Equals(password));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Employee doesn't exist");
            }

            return null;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Employee.Employee employee = await dbCtx.Employees
                    .Include(e => e.Username)
                    .Include(e => e.Password)
                    .FirstAsync(em => em.Id == employeeId);

                dbCtx.Employees.Remove(employee);
                await dbCtx.SaveChangesAsync();
            }
        }

        public async Task<Models.Employee.Employee> GetEmployeeByUsername(string username)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Employee.Employee employee = await dbCtx.Employees
                    .FirstAsync(c => c.Username.Equals(username));

                return employee;
            }
            
        }

        public async Task<Models.Employee.Employee> GetEmployeeById(int employeeId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Employee.Employee employee = await dbCtx.Employees
                    .FirstAsync(em => em.Id == employeeId);

                return employee;
            }
            
        }
        public async Task DeleteBurial(int burialId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Burial.Burial burial = await dbCtx.Burial
                    .Include(b => b.Client)
                    .Include(b => b.Comments)
                    .Include(b => b.Date)
                    .Include(b => b.Location)
                    .Include(b => b.NumberOfParticipants)
                    .Include(b => b.FullNameOfTheDeadMan)
                    .Include(b => b.BurialPreferences)
                    .Include(b => b.ClientBurials)
                    .Include(b => b.PreferenceForBurial)
                    .FirstAsync(bur => bur.Id == burialId);
                
                dbCtx.Remove(burial);
                Console.WriteLine("burial deleted");
                await dbCtx.SaveChangesAsync();
            }
        }

        public async Task<Models.Burial.Burial> GetBurial(int burialId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Burial.Burial burial = await dbCtx.Burial
                    .Include(b => b.Client)
                    .Include(b => b.Comments)
                    .Include(b => b.Date)
                    .Include(b => b.Location)
                    .Include(b => b.NumberOfParticipants)
                    .Include(b => b.FullNameOfTheDeadMan)
                    .Include(b => b.BurialPreferences)
                    .Include(b => b.ClientBurials)
                    .Include(b => b.PreferenceForBurial)
                    .FirstAsync(bur => bur.Id == burialId);

                return burial;
            }
            
        }
        
    }
}