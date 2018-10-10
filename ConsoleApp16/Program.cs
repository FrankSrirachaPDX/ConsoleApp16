using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            double dub;
            string temp;

            Console.WriteLine("Enter a number to be halved");
            temp = Console.ReadLine();
            num = Convert.ToInt16(temp);


            Class1.Math(num, out num);
            Console.WriteLine(num);

            Class1.Math(out dub);

            Console.WriteLine(dub);

            Console.ReadLine();

        }
    }
}
