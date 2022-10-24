using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessinggame2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Guessing game function
            Random rand = new Random();
            int magic_number = rand.Next(1, 99);
            int user_guess = 0;
            int guess_counter = 0;


            Console.WriteLine("I am thinking of a number between 1 and 99, try to guess it ");
            Console.WriteLine(magic_number);

            while (magic_number != user_guess)
            {
                while (guess_counter < 5)
                 {
                    {
                        user_guess = Convert.ToInt32(Console.ReadLine());


                            if (magic_number < user_guess)
                            {
                                Console.WriteLine("Lower than that!!");
                            }
                            else if (user_guess < magic_number)
                            {
                                Console.WriteLine("Higher than that!");
                            }

                            else if (user_guess == magic_number)
                            {
                            break;
        
                            }

                        guess_counter = guess_counter + 1;
                    }

                }
                break;

                
           
            }
            

        if (magic_number == user_guess)
        {
            Console.WriteLine("Well done!");
        }

        else
        {
            Console.WriteLine("Ran out of guesses!");
                }

            
            
        }
    }
}
