using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Shmoe", ID = 1 };
            Employee employee2 = new Employee() { FirstName = "James", LastName = "Taylor", ID = 2 };
            Employee employee3 = new Employee() { FirstName = "Joe", LastName = "Connor", ID = 3 };
            Employee employee4 = new Employee() { FirstName = "Frank", LastName = "Sanderson", ID = 4 };
            Employee employee5 = new Employee() { FirstName = "Michael", LastName = "Taglione", ID = 5 };
            Employee employee6 = new Employee() { FirstName = "Lucas", LastName = "Brutus", ID = 6 };
            Employee employee7 = new Employee() { FirstName = "Jane", LastName = "Anderson", ID = 7 };
            Employee employee8 = new Employee() { FirstName = "Bobby", LastName = "Skywalker", ID = 8 };
            Employee employee9 = new Employee() { FirstName = "Laura", LastName = "McTuttle", ID = 9 };
            Employee employee10 = new Employee() { FirstName = "Michelle", LastName = "Kilgore", ID = 10 };

            List<Employee> employees = new List<Employee>() { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };

            List<Employee> tempList = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    tempList.Add(employee);
                    Console.WriteLine(employee.FirstName);
                }
            }
            
            Console.ReadLine();

            List<Employee> lambdaList = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in lambdaList)
            {
                Console.WriteLine(employee.FirstName + " " +  employee.LastName + " " + employee.ID);
            }

            Console.ReadLine();
            List<Employee> employeeNum = employees.Where(x => x.ID > 5).ToList();

            foreach (Employee employee in employeeNum)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
            }


            Console.ReadLine();



        }
    }
}
