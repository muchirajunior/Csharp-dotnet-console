using System;

namespace loops
{
    class Program
    {
        static void while_loop(){
            int a=0;
            while (a<=10)
            {
              Console.WriteLine($"number is :{a}");
              a++;  
            }
        }

        static void for_loop(){
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine($"The number is :{i}");
            }
        }
        static void Main(string[] args)
        {
            for_loop();
        }
    }
}
