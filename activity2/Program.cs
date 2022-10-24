using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2
{
    class Program
    {
        static void Main(string[] args)
        {
            var starting_dict = new Dictionary<string, string>
            {
                {"key1", "parts" },
                {"key2", "traps" },
                {"key3", "arts" },
                {"key4", "rats" },
                {"key5", "starts" },
                {"key6", "tarts" },
                {"key7", "rat" },
                {"key8", "art" },
                {"key9", "tar" },
                {"key10", "tars" },
                {"key11", "stars" },
                {"key12", "stray" }
            };

            List<string> special_list = new List<string> { };
            int total = 0;
            int special_total = 442;

            foreach(var value in starting_dict.Values)
            {
                //Console.WriteLine(value);
                if (value.Length == 4)
                {
                    foreach (var letter in value)
                    {
                        //Console.WriteLine(letter);
                        var ascii_letter = (int)letter;
                        //Console.WriteLine(ascii_letter);
                        total = total + ascii_letter;

                        Console.WriteLine(total);
                        if(total == special_total)
                        {
                            special_list.Add(value);
                        }


                    }
                    total = 0;

                }
                
                    }

            Console.WriteLine(special_list);

            foreach (var value2 in special_list)
            {
                Console.WriteLine(value2);
            }

           





        }
    }
}
