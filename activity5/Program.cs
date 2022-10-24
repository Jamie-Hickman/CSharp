using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world";
            List<string> new_message = new List<string>() { };


            for (int running_index = input.Length -1 ; running_index >= 0; running_index--)
                {
                Console.WriteLine(input[running_index]);
                var new_letter = input[running_index];
                string new_letter_2 = Convert.ToString(new_letter);
                new_message.Add(new_letter_2);
    
            }
            //Console.WriteLine(new_message);

            string final_message = string.Join("", new_message);

            Console.WriteLine(final_message);

     


        }
    }
}
