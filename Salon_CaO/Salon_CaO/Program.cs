using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_CaO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            personal person1 = new personal();

            person1.name = "Salon Khert";
            person1.age = 18;
            person1.gender = "male";

            person1.Greet();

            Console.ReadKey();
        }
    }
}
