namespace ConsoleApp37
{
    internal class Employee
    {
        public static int EmployeeID = 1000;

        public Employee(string fullName, string position, double salary, string departmentName)
        {
            var departmentCode = DepartmentName.Substring(0, 2);
            Id = (departmentCode + EmployeeID.ToString());
            EmployeeID++;
            FullName = fullName;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;
        }

        public string Id { get; set; }
        public string FullName { get; set; }
        public string Position
        {
            get { return Position; }
            set
            {
                if (value.Length > 2)
                    {
                    Position = value;
                }
                else
                {
                    throw new Exception("Position must be greater than 2 characters");
                }
            }
        }
        public double Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                if (value > 250)
                {
                    Salary = value;
                }
                else
                {
                    throw new Exception("Salary must be greater than 250");
                }
            }
        }
        public string DepartmentName { get; set; }
    }
}
