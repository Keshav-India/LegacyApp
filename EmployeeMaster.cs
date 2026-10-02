using System;
namespace LegacyApp
{
    public class EmployeeMaster
    {
        public int EmployeeId { get; }
        public string Name { get; }

        public EmployeeMaster(int id, string name)   // constructor with parameters
        {
            EmployeeId = id;
            Name = name;
        }

        public void ShowEmployee()
        {
            Console.WriteLine($"Employee: {EmployeeId} - {Name}");
        }
    }
}
