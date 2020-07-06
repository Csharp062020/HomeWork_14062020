using System;
using System.Diagnostics;

namespace _14062020
{
    //[DebuggerDisplay("Model {_model}")]
    [DebuggerDisplay ("Price in INS {_price*3.67}")]
    class Computer
    {
        public string _model;
        public int _price;
        public int _numberOfProcessors;
        public float _screenSize;
        public bool _isTurnOn;

        public void tellMeThePrice()
        {
            Console.WriteLine($"price: {_price}");
        }

        public string tellMeTheScreenSize()
        {
            return _screenSize.ToString();
        }


        public void turnOn()
        {
            _isTurnOn = true;
        }

        public void turnOff()
        {
            _isTurnOn = false;
        }

        public void addProcessor()
        {
            _numberOfProcessors+= Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_model} {_price} {_numberOfProcessors} {_screenSize} {_isTurnOn}";
        }
    }
}