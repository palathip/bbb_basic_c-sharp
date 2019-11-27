using System;
using System.Collections.Generic;
using System.Text;

namespace Bconsole
{
    class Person
    {
        public string firsName;
        public string lastName;
        public int age;

        public void setAge(int age)
        {
            this.age = age;
        }

        public Person()
        {

        }

        public Person(string firsName, string lastName, int age)
        {
            this.firsName = firsName;
            this.lastName = lastName;
            this.age = age;
        }

        public void showData()
        {
            Console.WriteLine("Firstname is : {0}",firsName);
            Console.WriteLine("Lirstname is : {0}",lastName);
            Console.WriteLine("age is : {0}", age);
        }

        public void walk()
        {
            Console.WriteLine("walk");
        }
        public void eat()
        {
            Console.WriteLine("eat");
        }
    }
}
