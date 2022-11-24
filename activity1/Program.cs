using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "1,2,1,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0";

            string[] new_sequence = sequence.Split(',');

            int running_total = 0;
            int saved_total = 0;
            int final_total = 0;
            List<int> new_list = new List<int>() { };


            foreach (var number in new_sequence)
            {
                System.Console.WriteLine($"<{number}>");
                if (number == "0")
                {
                    running_total = running_total + 1;
                }
                else
                {
                    saved_total = running_total;
                    running_total = 0;
                    new_list.Add(saved_total);


                }
            }

            final_total = new_list.Max();
            Console.WriteLine(final_total);




            }
        }
    }

