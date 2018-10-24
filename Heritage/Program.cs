using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.FirstName = "John";
            s.LastName = "Doe";
            s.SayHello();
            s.Listening();

            Teacher t = new Teacher("Last","Doe","C#);
            t.sayHello();

            Student s1 = new Student("David", "Jones");
            Student s2 = new Student("John", "Jones");
            Student s3 = new Student("James", "Jones");

            Teacher t2 = new Teacher("Mike", "Doe", "C++");

            // abstract permet d'empecher de faire un new sur une classe
            List<Person> persons = new List<Person>();
            persons.Add(s1);
            persons.Add(s2);
            persons.Add(s3);
            persons.Add(t2);
            persons.Add(t2);

            List<Person> persons = new List<Person>() {
                s1,
                s2,
                s3,
                t,
                t2
            };

            foreach(Person p in persons)
            {

            }
            Console.ReadLine();
        }
    }
}
