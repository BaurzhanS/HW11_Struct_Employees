using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Struct_Enum
{
    public enum Sex { male,female}
    public enum Position { director, manager, worker }
    public interface IEmployee
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        Sex Sex { get; set; }
        Position Position { get; set; }
        DateTime HiredDate { get; set; }
        double Salary { get; set; }
    }
}
