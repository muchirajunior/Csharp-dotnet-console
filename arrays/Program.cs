using System;
using System.Collections.Generic;
using System.Linq;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter number {i} :");
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n \narray is : ");
            for (int i = 0; i < array.Length; i++)
            {
               Console.WriteLine(array[i]); 
            }

            List<int> numbers=new List<int>(){2,3,4,5,6,7,8,3,4};
            var nums=from item in numbers where item<6 select item;
            var n=numbers.Where((item)=>item<6);
            var numbs=numbers.Select((item)=>item );
            foreach (var item in numbs ) Console.WriteLine(item);

           
         }
    }
}
