using System;

namespace classes
{
    class Person{
        public string name;

        public void introduce(){
            Console.WriteLine($"my name is {name}");
        }

        public static Person parse(string str){
            var person=new Person();
            person.name=str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person=Person.parse("John");
            // person.name="MUCHIRA JUNIOR";
            person.introduce();
        }
    }
}
