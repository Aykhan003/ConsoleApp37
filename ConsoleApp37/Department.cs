namespace ConsoleApp37
{
    internal class Department
    {
        public Department(string departmentName, int workerLimit, double salaryLimit, Employee[] employees)
        {
            DepartmentName = departmentName;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
            Employees = employees;
        }

        public string DepartmentName
        {
            get { return field; }
            set
            {
                if (value.Length > 2)
                {
                    DepartmentName = value;
                }
                else
                {
                    throw new Exception("Department name must be greater than 2 characters");
                }
            }
        }
        public int WorkerLimit
        {
            get { return field; }
            set
            {
                if (value > 0)
                {
                    WorkerLimit = value;
                }
                else
                {
                    throw new Exception("Worker limit must be greater than 0");
                }
            }
        }
        public double SalaryLimit
        {
            get { return field; }
            set
            {
                if (value > 250)
                {
                    SalaryLimit = value;
                }
                else
                {
                    throw new Exception("Salary limit must be greater than 250");
                }
            }
        }
        public Employee[] Employees { get; set; }
        public double CalcSalaryAverage()
        {
           double sum = 0;
            foreach (Employee e in Employees)
            {
                sum += e.Salary;
            }
            return sum / Employees.Length;
        }
    }
}
