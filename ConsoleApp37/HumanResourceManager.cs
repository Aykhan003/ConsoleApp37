namespace ConsoleApp37
{
    internal class HumanResourceManager : IHumanResourceManager
    {
        public List<Department> Departments = new List<Department>();
        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
        public void GetDepartments()
        {
            foreach (var department in Departments)
            {
                Console.WriteLine($"Department Name: {department.DepartmentName}, Worker Limit: {department.WorkerLimit}, Salary Limit: {department.SalaryLimit}");
            }
        }
        public void EditDepartment(string departmentName, int workerLimit, double salaryLimit)
        {
            var department = Departments.Find(d => d.DepartmentName == departmentName);
            if (department != null)
            {
                department.WorkerLimit = workerLimit;
                department.SalaryLimit = salaryLimit;
            }
            else
            {
                throw new Exception("Department not found");
            }
        }

        //• AddEmployee() • parametr olaraq employee yaranmasi ucun lazi olan melimatlar ve departament name gonderilir.Method icinde employe yaradilir  ve gonderilmis nomreli departamenti tapib onun employees listine elave eedilir (department classi yuxarda employees listi saxlayir)
        public void AddEmployee(string departmentName, Employee employee)
        {
            var department = Departments.Find(d => d.DepartmentName == departmentName);
            if (department != null)
            {
                if (department.Employees.Length < department.WorkerLimit)
                {
                    var employeesList = department.Employees.ToList();
                    employeesList.Add(employee);
                    department.Employees = employeesList.ToArray();
                }
                else
                {
                    throw new Exception("Worker limit exceeded");
                }
            }
            else
            {
                throw new Exception("Department not found");
            }
        }

    }
}
