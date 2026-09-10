namespace ConsoleApp37
{
    internal class Employee
    {
        public static int EmployeeID = 1000;

        public Employee(string fullName, string position, double salary, string departmentName)
        {
            var departmentCode = departmentName.Substring(0, 2);
            Id = (departmentCode + EmployeeID.ToString());
            EmployeeID++;
            FullName = fullName;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;
        }

        public string Id { get; set; }
        public string FullName { get; set; }
        private string _position;
        public string Position
        {
            get { return _position; }
            set
            {
                if (value.Length > 2)
                    {
                    _position = value;
                }
                else
                {
                    throw new Exception("Position must be greater than 2 characters");
                }
            }
        }
        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 250)
                {
                    _salary = value;
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
