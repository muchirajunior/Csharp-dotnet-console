using System;
using System.Collections.Generic;

namespace advanceoperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //teranry operators
            int x=10, y=20;

            int z= x!=y ? 20: 10;
            Console.WriteLine($"number is :{z}");

            List<int> numbers=new List<int>();
            numbers.add(10);
            numbers.add(40);
            numbers.add(20);
            Console.WriteLine($"number 2 : {numbers[2]}");
        }
    }
}
