using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp058
{
    class Car
    {
        string color = "red";
        int model = 345737;

        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public static void Brake()
        {
            Console.WriteLine("brake");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.model);
            myObj.Drive();
            Brake();
            Console.Read();
        }
    }
}
