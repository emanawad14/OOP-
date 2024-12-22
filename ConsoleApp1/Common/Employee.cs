using System;

using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Common
{





    public class Hire_Data
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Hire_Data(int _year, int _month, int _day)
        {
            Year = _year;
            Month = _month;
            Day = _day;
        }
        public override string ToString()
        {
            return $" Year : {Year} \n Month : {Month} \n Day :{Day}";
        }
    }




    /// <summary>
    /// /////////////////////////////////////////////////
    /// </summary>
    public enum security
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    public class Employee
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public security SecurityLevel { get; set; }
        public int Salary { get; set; }
        public DateTime DateTime { get; set; }
        public string? gender_field { get; set; }
        public Employee(Guid _id, string _name, security _security, int _salary, DateTime _data, string _gender)
        {
            Id = _id;
            Name = _name;
            SecurityLevel = _security;
            Salary = _salary;
            DateTime = _data;
            gender_field = _gender;

        }

        public override string ToString()
        {
            return $" ID :{Id} \n Name :{Name} \n SecurityLevel :{SecurityLevel} \n Datatime :{DateTime} \n gender_field :{gender_field} ";
        }
    }
}
   

    

   





