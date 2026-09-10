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
        private string _departmentName;
        public string DepartmentName
        {
            get { return _departmentName; }
            set
            {
                if (value.Length > 2)
                {
                    _departmentName = value;
                }
                else
                {
                    throw new Exception("Department name must be greater than 2 characters");
                }
            }
        }
        private int _workerLimit;
        public int WorkerLimit
        {
            get { return _workerLimit; }
            set
            {
                if (value > 0)
                {
                    _workerLimit = value;
                }
                else
                {
                    throw new Exception("Worker limit must be greater than 0");
                }
            }
        }
        private double _salaryLimit;
        public double SalaryLimit
        {
            get { return _salaryLimit; }
            set
            {
                if (value > 250)
                {
                    _salaryLimit = value;
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
