using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14062020
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer aComputer = new Computer()
            {
                _numberOfProcessors = 0,
                _isTurnOn = false,
                _model = "i7",
                _price = 1000,
                _screenSize = 16
            };

            Computer bComputer = new Computer()
            {
                _numberOfProcessors = 0,
                _isTurnOn = false,
                _model = "i5",
                _price = 2000,
                _screenSize = 17
            };

            Computer cComputer = new Computer()
            {
                _numberOfProcessors = 0,
                _isTurnOn = false,
                _model = "i9",
                _price = 3000,
                _screenSize = 18
            };

            Console.WriteLine($"you have {aComputer._numberOfProcessors}  how many processor to add");
            aComputer.addProcessor();
            Console.WriteLine($"Now you have {aComputer._numberOfProcessors} ");

            Console.WriteLine($"Pc status:  {bComputer._isTurnOn} ");
            bComputer.turnOn();
            Console.WriteLine($"Pc status:  {bComputer._isTurnOn} ");

            Console.WriteLine($"screen size:  {cComputer.tellMeTheScreenSize()} ");


            Console.WriteLine(aComputer.ToString());
            Console.WriteLine(bComputer.ToString());
            Console.WriteLine(cComputer.ToString());



        }
    }

}
