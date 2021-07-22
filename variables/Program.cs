using System;

namespace variables
{
    class Program
    {
        static void myvars(string n){
            int x=10; //intenger variable
            var y=20; //dynamic variable
            double number=66.80; //floating variable 
            string myname=" JUNIOR ";
            Console.WriteLine($"number 1: {x} \n number 2:{y} \n decimal number :{number} ");
            Console.WriteLine($"name 1: {n} \n name 2: {myname} ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter your name :");
            string name=Console.ReadLine();   
            Console.WriteLine(" name :"+name);          
            myvars(name);
        }
    }
}
