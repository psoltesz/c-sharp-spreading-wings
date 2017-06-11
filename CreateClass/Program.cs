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
            Person person1 = new Person();
            person1.Setup("Jani", "1992.04.02.");
            Console.WriteLine(person1.ToString());
            Console.ReadKey();
        }
    }

    class Person
    {
        public String name;
        public String birthdate;
        Gender gender;

        enum Gender {male, female};

        public override string ToString()
        {
            return "Person details: " + name + " (gender: " + gender + "), born at " + birthdate;
        }

        public void Setup(string name, string birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
            this.gender = Gender.male;
        }
    }
}
