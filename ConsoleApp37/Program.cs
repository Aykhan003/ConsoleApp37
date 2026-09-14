namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManager hrm = new HumanResourceManager();

            Employee[] initialEmployees = new Employee[0];

            Department dept = new Department(
                "IT_Dept",
                5,
                20000,
                initialEmployees
            );

            hrm.AddDepartment(dept);

            Console.WriteLine("--- Departamentlər ---");
            hrm.GetDepartments();

            Employee emp1 = new Employee(
                "Ali Aliyev",
                "Developer",
                1500,
                "IT_Dept"
            );

            Employee emp2 = new Employee(
                "Vali Valiyev",
                "Designer",
                1200,
                "IT_Dept"
            );

            hrm.AddEmployee("IT_Dept", emp1);
            hrm.AddEmployee("IT_Dept", emp2);

            hrm.Search("Developer");

            hrm.EditEmployee(
                emp1.Id,
                2500,
                "Senior Developer"
            );

            hrm.Search("Ali");

            Console.WriteLine("\n--- isci silinir (Vali Valiyev) ---");

            hrm.RemoveEmployee(
                "IT_Dept",
                "Vali Valiyev"
            );

            Console.WriteLine("\n--- Silindikden Sonra Axtarıs (Vali) ---");

            hrm.Search("Vali");

            Console.ReadLine();
        }
    }
}