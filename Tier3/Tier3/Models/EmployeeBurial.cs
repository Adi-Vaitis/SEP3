namespace Tier3.Models
{
    public class EmployeeBurial
    {
        public int EmployeeId { get; set; }
        public Employee.Employee Employee { get; set; }
        public int BurialId { get; set; }
        public Burial.Burial Burial { get; set; }
    }
}