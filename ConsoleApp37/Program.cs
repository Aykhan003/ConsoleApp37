namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManager hrm = new HumanResourceManager();

            try
            {
                //Departament Yaratmaq və Əlavə Etmək
                Employee[] initialEmployees = new Employee[0];
                Department dept = new Department("IT_Dept", 5, 20000, initialEmployees);

                hrm.AddDepartment(dept);
                Console.WriteLine("--- Departamentlər ---");
                hrm.GetDepartments();

                //İşçi Yaratmaq və Departamentə Əlavə Etmək
                Employee emp1 = new Employee("Ali Aliyev", "Developer", 1500, "IT_Dept");
                Employee emp2 = new Employee("Vali Valiyev", "Designer", 1200, "IT_Dept");

                hrm.AddEmployee("IT_Dept", emp1);
                hrm.AddEmployee("IT_Dept", emp2);

                hrm.Search("Developer");

                //İşçini Redaktə Etmək
                hrm.EditEmployee(emp1.Id, 2500, "Senior Developer");
                hrm.Search("Ali"); 

                //İşçini Silmək
                Console.WriteLine("\n--- İşçi Silinir (Vali Valiyev) ---");
                hrm.RemoveEmployee("IT_Dept", "Vali Valiyev");

                Console.WriteLine("\n--- Silindikden Sonra Axtarış (Vali) ---");
                hrm.Search("Vali"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.ReadLine();
        }
    }
}