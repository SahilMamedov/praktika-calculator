using System;

namespace Praktika_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesablamag istediyin reqemi yazin");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("+ , - , * , / bunlardan birini yazin ");
            string b = Console.ReadLine();
            Console.WriteLine("Novbeti reqemi yazin");
            double c = Convert.ToInt32(Console.ReadLine());
            

            switch (b)
            {
                case"+": Console.WriteLine(a+c);
                    break;
                case "-": Console.WriteLine(a-c);
                    break;
                case "*": Console.WriteLine(a * c);
                    break;
                case "/": Console.WriteLine(a / c);
                    break;
            



        }


        }
    }
}

      