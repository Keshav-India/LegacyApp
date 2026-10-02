using System;
namespace LegacyApp
{
    public class EmployeeFacade
    {
        private readonly EmployeeMaster _employee;
        private readonly AddressMaster _address;
        private readonly DepartmentMaster _department;

        public EmployeeFacade(int id, string name, string city, string street, string dept)
        {
            _employee = new EmployeeMaster(id, name);
            _address = new AddressMaster(city, street);
            _department = new DepartmentMaster(dept);
        }

        public void ShowFullDetails()
        {
            Console.WriteLine("====== Employee Record =====");
            Console.WriteLine("    **** Employee Info ****");
            _employee.ShowEmployee();
            Console.WriteLine("    ****Address Info");
            _address.ShowAddress();
            Console.WriteLine("    ****Department Info");
            _department.ShowDepartment();
        }
    }
}
