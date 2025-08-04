using System;
using OOPYEAH;

namespace OOPYEAH
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("AHAAAAAAAAAA");
            // Program2 name1 = new Program2();
            // Program2 name2 = new Program2();
            // name1.Hello("TUKMOL");
            // name2.Hello("TULOK");

            Vehicle kotse1 = new Vehicle();
            Car kotse2 = new Car();
            Car kotse3 = new Car();
            kotse1.StartEngine();
            kotse2.StartEngine();
            kotse2.UmaandarSa();
            kotse3.InputData("Red", 2000000, 4);
            kotse3.Introduce();
        }
    }
    public class Vehicle
    {
        protected string color;
        protected double price;
        public void StartEngine()
        {
            Console.WriteLine("EEEEEENNNNNGGGGGGG");
        }
    }
    public class Car : Vehicle
    {
        private int wheels = 4;
        public void UmaandarSa()
        {
            Console.WriteLine("Sa soil");
        }
        public void InputData(string color, double price, int wheels)
        {
            this.color = color;
            this.price = price;
            this.wheels = wheels;
        }
        public void Introduce()
        {
            Console.WriteLine($"This car is {color}, costs {price} and has {wheels} wheels.");
        }
    }
}

