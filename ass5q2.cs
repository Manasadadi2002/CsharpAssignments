

namespace ConsoleApp3
{
    internal class EmployeeManagementSystem
    {
        public static void Main()
        {

            ArrayList Employee = new ArrayList();
            Employee.Add(101);
            Employee.Add("Alekhya");
            Employee.Add("Trainee");
            Employee.Add(20000);
            Employee.Add("Banglore");



            foreach (object i in Employee)
            {
                Console.WriteLine(i + " ");

            }
            Console.ReadLine();



        }
    }
}
