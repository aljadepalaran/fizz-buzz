using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int user_input;

            Console.Write("Please enter a number: ");

            user_input = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= user_input; i++)
            {
                
                if (((i % 3) == 0) && ((i % 5) == 0))
                {

                    Console.WriteLine(i + ": FizzBuzz!");

                }
                else if ((i % 3) == 0){

                    Console.WriteLine(i + ": Fizz!");

                }
                else if ((i % 5) == 0)
                {

                    Console.WriteLine(i + ": Buzz!");

                }
                else
                {

                    Console.WriteLine(i);

                }

            }

            Console.ReadLine();

        }
    }
}
