using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] user = {"Paul", "Chris", "John", "Robert", "Joyce", "Ashley"};

            Random rand = new Random();
            int index = rand.Next(user.Length); 

            Random rnd = new Random();
            int randomNummer = rand.Next(0, 2);

            Console.ReadKey();
            Console.WriteLine($"{user[index]}");
            Console.ReadKey();

            if(randomNummer == 0)
            {
                Console.WriteLine("ist raus.");
            } else if(randomNummer == 1)
            {
                Console.WriteLine("ist weiter.");
            }

            Console.ReadKey();


        }
    }
}
