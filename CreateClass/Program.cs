using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, "léhűtő", 1000);
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }

    class Person
    {
        public String name;
        public DateTime birthdate;
        public Gender gender;

        public Person(string name, DateTime birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
            gender = Gender.male;
        }
        public enum Gender {male, female};

        public override string ToString()
        {
            return "Person details: " + name + " (gender: " + gender + "), born at " + birthdate;
        }

    }

    class Employee : Person, ICloneable
    {
        String profession;
        int salary;
        internal Room Room;

        public Employee(string name, DateTime birthdate, string profession, int salary) : base(name, birthdate)
        {
            this.profession = profession;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "Person details: " + name + " (gender: " + gender + "), born at " + birthdate + " - profession: " + profession + ", salary: " + salary + " - room number: " + Room.Number;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }

    class Room
    {
        public int Number;

        public Room(int Number)
        {
            this.Number = Number;
        }
    }
}
