using System;
namespace LegacyApp
{
    public class DepartmentMaster
    {
        public string DepartmentName { get; }

        public DepartmentMaster(string deptName)   // constructor with parameter
        {
            DepartmentName = deptName;
        }

        public void ShowDepartment()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }
    }
}
