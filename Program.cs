using System;

namespace  Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("who farted october 20. 1835");
            String answer1 = Console.ReadLine();

            if (answer1 == "John Henry Moore") {
                Console.WriteLine("Correct");
            }   else {
                Console.WriteLine("Wrong answer! You failed the test!");
                Environment.Exit(1);
            }


            Console.WriteLine("what happened on this day last week on saturday at 7:59 pm");
            String answer2 = Console.ReadLine();

            if (answer2 == "nothing")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("nothing happend, reset");
                Environment.Exit(1);
            }

            Console.WriteLine("If January equals 717, March equals 5315 and June equals 4624, then what does August equal?");
            String answer3 = Console.ReadLine();

            if (answer3 == "im done")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("this is ez u should know this lol");
                Environment.Exit(1);
            }

            Console.ReadKey();
        }
    }
}