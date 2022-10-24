using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "step on no pets";
            List<string> original_input = new List<string>() { };
            List<string> new_input = new List<string>() { };

            foreach (var letter in input)

            {
                string new_letter = Convert.ToString(letter);
                original_input.Add(new_letter);

             

            }
            //string original_message = string.Join("", original_input);

            //Console.WriteLine(original_message);

            for (int running_index = input.Length - 1; running_index >= 0; running_index--)
            {
                new_input.Add(original_input[running_index]);

            }

            string original_message = string.Join("", original_input);
            string new_message = string.Join("", new_input);

            Console.WriteLine(original_message);
            Console.WriteLine(new_message);


            if (original_message == new_message)
            {
                Console.WriteLine("Palendrome");

            }
            else
                    {
                Console.WriteLine("Not palendrome");
            }
            

        }
    }
}
