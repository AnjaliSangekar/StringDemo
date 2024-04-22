using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringDemmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                var name = "john smith";
                Console.WriteLine("Trime: '{0}'", name.Trim());
                Console.WriteLine("ToUpper: '{0}'", name.Trim().ToUpper());

                var index = name.IndexOf(' ');
                var first = name.Substring(0, index);
                var last = name.Substring(index + 1);

                Console.WriteLine("First: " + first);
                Console.WriteLine("Last: " + last);

                var names = name.Split(' ');
                Console.WriteLine("first: " + names[0]);
                Console.WriteLine("Last: " + names[1]);


                Console.WriteLine(name.Replace('s', 'S'));
                Console.WriteLine(name.Replace('j', 'J'));

                if (String.IsNullOrWhiteSpace(" "))
                {
                    Console.WriteLine("Invalid");
                }

                var str = "27";
                var age = Convert.ToByte(str);
                Console.WriteLine(age);

                float price = 29.84f;
                Console.WriteLine(price.ToString("C"));

            
        }
    }
}
