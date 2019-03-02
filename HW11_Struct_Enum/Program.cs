using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Struct_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Stalin", "Lenin", Sex.male, 34, Position.director, new DateTime(2017, 8, 27), 120000);
            Employee e2 = new Employee("Beslan", "Yeslan", Sex.male, 25, Position.manager, new DateTime(2018, 6, 18), 300000);
            Employee e3 = new Employee("Vladimir", "Putin", Sex.male, 64, Position.manager, new DateTime(2018, 5, 22), 250000);
            Employee e4 = new Employee("Petr", "Gandi", Sex.female, 32, Position.worker, new DateTime(2018, 2, 20), 50000);
            Employee e5 = new Employee("Timoti", "Nazarbaeva", Sex.female, 22, Position.worker, new DateTime(2018, 4, 12), 120000);
            Employee e6 = new Employee("Leva", "Tolstoyeva", Sex.female, 26, Position.manager, new DateTime(2018, 5, 9), 200000);

            ServiceEmployee emp = new ServiceEmployee();
            emp.employees.Add(e1);
            emp.employees.Add(e2);
            emp.employees.Add(e3);
            emp.employees.Add(e4);
            emp.employees.Add(e5);
            emp.employees.Add(e6);
            foreach (var employee in emp.employees)
            {
                //Console.WriteLine(employee.ToString());
            }
            //emp.getManagersInfoWithMoreThanAvgSalary();
            //emp.getInfoByPosition(Position.worker);

            //int day=int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());
            //DateTime date = new DateTime(year,month,day);
            //emp.getEmpHiredLater(date);
            //emp.getEmpBySex(Sex.female);
            //emp.getEmpBySex();
        }
    }
}
