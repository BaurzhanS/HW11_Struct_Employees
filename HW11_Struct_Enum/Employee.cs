using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW11_Struct_Enum;

namespace HW11_Struct_Enum
{
    public struct Employee: IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Position Position { get; set; }
        public DateTime HiredDate { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string surname, Sex sex, int age, Position pos, DateTime hiredDate, double salary)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Age = age;
            Position = pos;
            HiredDate = hiredDate;
            Salary = salary;
        }
        
        public override string ToString()
        {
            string info= string.Format("Имя: {0}\nФамилия: {1}\nДолжность: {2}\nВозраст: {3}\nПол: {4}\nДата принятия на работу:" +
                " {5: dd.MM.yyyy}\nЗарплата: {6}\n",
                Name, Surname, Position,Age, Sex, HiredDate, Salary);
            return info;
        }
    }

    public class ServiceEmployee
    {
        public List<Employee> employees = new List<Employee>();
        public void getInfoByPosition(Position position)
        {
            foreach (var employee in employees)
            {
                if (employee.Position == position)
                {
                    Console.WriteLine(employee.ToString());
                   
                }
            }
        }
        private double getEmployeesAvgSalary()
        {
            double sum = 0;
            foreach (var employee in employees)
            {
                if (employee.Position != Position.director)
                {
                    sum += employee.Salary;
                }
            }
            double avgSalary = sum / employees.Count;
            return avgSalary;
        }
        public void getManagersInfoWithMoreThanAvgSalary()
        {
            double avgSalary = getEmployeesAvgSalary();
            var emp = employees.OrderBy(e => e.Surname);
            foreach (var employee in emp)
            {
                if (employee.Salary > avgSalary && employee.Position == Position.manager)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }
        public void getEmpHiredLater(DateTime date)
        {
            var emp = employees.OrderBy(e => e.Surname);
            foreach (var employee in emp)
            {
                if (employee.HiredDate > date)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }
        public void getEmpBySex(Sex sex)
        {
            foreach (var employee in employees)
            {
                if (employee.Sex == Sex.female)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }
        public void getEmpBySex()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
   

}
