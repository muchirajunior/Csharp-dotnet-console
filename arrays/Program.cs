using System;

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
         }
    }
}
