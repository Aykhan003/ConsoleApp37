namespace ConsoleApp37
{
    internal class HumanResourceManager : IHumanResourceManager
    {
        public List<Department> Departments = new List<Department>();

        List<Department> IHumanResourceManager.Departments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
        public void RemoveEmployee(string departmentName, string employeeFullName)
        {
            var department = Departments.Find(d => d.DepartmentName == departmentName);
            if (department != null)
            {
                var employeesList = department.Employees.ToList();
                var employeeToRemove = employeesList.Find(e => e.FullName == employeeFullName);
                if (employeeToRemove != null)
                {
                    employeesList.Remove(employeeToRemove);
                    department.Employees = employeesList.ToArray();
                }
                else
                {
                    throw new Exception("Employee not found");
                }
            }
            else
            {
                throw new Exception("Department not found");
            }
        }
        public void EditEmployee(string employeeId, double salary, string position)
        {
            foreach (var department in Departments)
            {
                var employee = department.Employees.ToList().Find(e => e.Id == employeeId);
                if (employee != null)
                {
                    employee.Salary = salary;
                    employee.Position = position;
                    return;
                }
            }
            throw new Exception("Employee not found");
        }
        public void Search(string query)
        {
            foreach (var department in Departments)
            {
                var employees = department.Employees.ToList().Where(e => e.FullName.Contains(query) || e.Position.Contains(query));
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Employee ID: {employee.Id}, Full Name: {employee.FullName}, Position: {employee.Position}, Salary: {employee.Salary}, Department: {employee.DepartmentName}");
                }
            }
        }
    }
}
