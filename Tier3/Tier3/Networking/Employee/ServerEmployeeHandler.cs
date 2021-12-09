using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Tier3.Repositories.Employee;

namespace Tier3.Networking.Employee
{
    public class ServerEmployeeHandler
    {
        private Models.Employee.Employee employee;
        private IEmployeeRepo employeeRepo;

        public ServerEmployeeHandler()
        {
            employee = new Models.Employee.Employee();
            employeeRepo = new EmployeeRepo();
        }

        public async void GetClient(NetworkStream stream, string content)
        {
            Models.Employee.Employee test = JsonSerializer.Deserialize<Models.Employee.Employee>(content);
            string username = test.Username;
            string password = test.Password;
            employee = await employeeRepo.GetEmployee(username, password);
            string reply = JsonSerializer.Serialize(employee);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite, 0, bytesWrite.Length);
        }

        public async void Delete(string content)
        {
            await employeeRepo.DeleteEmployee(Int32.Parse(content));
        }
        
        public async void GetAccountByUsername(NetworkStream stream, string content)
        {
            Models.Employee.Employee employee1 = JsonSerializer.Deserialize<Models.Employee.Employee>(content);
            string username = employee1.Username;
            employee = await employeeRepo.GetEmployeeByUsername(username);
            string reply = JsonSerializer.Serialize(employee);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite, 0, bytesWrite.Length);
        }
        
        public async void GetUserById(NetworkStream stream, string content)
        {
            Models.Employee.Employee employee1 = await employeeRepo.GetEmployeeById(Int32.Parse(content));
            string reply = JsonSerializer.Serialize(employee1);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite, 0, bytesWrite.Length);
        }
    }
}