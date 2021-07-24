using System;

namespace condstatements
{
    class Program
    {
        static void switch_statement(){
            Console.Write("enter a name:");
            var x=Console.ReadLine();
            
            switch (x)
            {
                case "junior": Console.WriteLine("correct");
                        break;
                case "james": Console.WriteLine("incorrect");
                        break;             
                default: Console.WriteLine("invalid");
                       break;
            }
            
        }

        //if conditional statement
        static void if_statement(){
            Console.Write("Guess my name :");
           string name=Console.ReadLine();
           Console.Write("Guess  name again:");
           string secondname=Console.ReadLine();

           if (name=="junior"){
               Console.WriteLine("you are corect !!!!!!!");
           }
           else if (secondname=="junior")
           {

                Console.WriteLine("second guess corect ");
           }
           else
           {
               Console.WriteLine("you are wrong");
           }

        }

        //main function
        static void Main(string[] args)
        {
            switch_statement();
           
        }
    }
}
