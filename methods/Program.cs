using System;

namespace methods
{

    class Program
    {
        static void Main(string[] args)
        {
            var calc=new Calculator();
            int mysum=calc.sum(1,2,3,4,8,22);

            Console.WriteLine("sum is {0}", mysum);
        }
    }
}
