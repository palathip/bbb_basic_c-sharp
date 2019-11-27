using System;
using System.Collections.Generic;
using Bconsole;

namespace _3_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firsName = "Palathip";
            person.lastName = "Wuttiprayoon";
            person.setAge(28);
            person.eat();
            person.walk();
            person.showData();

            Person person1 = new Person("Rudjaya", "Intaprom", 28);
            person1.showData();

            Children children = new Children();
            children.firsName = "Chanakarn";
            children.lastName = "Wuttiprayoon";
            children.setAge(23);
            children.eyeColor = "Blue";
            children.ShowDataChildren();

        }
    }
}
