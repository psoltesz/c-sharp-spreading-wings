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
            Person person1 = new Person("Jani", "1992.04.02.");
            Employee employee1 = new Employee("Dénes", "1990.04.05.", "programmer", 300000);
            Console.WriteLine(person1.ToString());
            Console.WriteLine(employee1.ToString());
            Console.ReadKey();
        }
    }

    class Person
    {
        public String name, birthdate;
        public Gender gender;

        public Person(string name, string birthdate)
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

    class Employee : Person
    {
        
        String profession;
        int salary;
        int roomNumber;

        public Employee(string name, string birthdate, string profession, int salary) : base(name, birthdate)
        {
            this.profession = profession;
            this.salary = salary;
            this.roomNumber = Room.roomNumber;
        }

        public override string ToString()
        {
            return "Person details: " + name + " (gender: " + gender + "), born at " + birthdate + " - profession: " + profession + ", salary: " + salary + " - room number: " + roomNumber;
        }
    }

    class Room
    {
        public static int roomNumber = 42;
    }
}
