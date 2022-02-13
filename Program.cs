using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1
{

    
    public class Car
    {
        public Car()
        {
            Console.WriteLine("Class: Car");
        }

        public void vehicleType()
        {
            
            Console.WriteLine("Vehicle Type: Car");
        }
    }
    public class Honda : Car
    {
        public Honda()
        {
            Console.WriteLine("Class: Honda");
        }
        public void brand()
        {
            Console.WriteLine("Brand: Honda");
        }
        public void speed()
        {
            Console.WriteLine("Max: 120Kmph");
        }
        

    }

    public class Civic : Honda
    {
        public Civic()
        {
            Console.WriteLine("Model: Civic");
        }

        public void speed()
        {
            Console.WriteLine("Max: 150Kmph");
        }

        /*
        public void working(string z)
        {
            
            Console.WriteLine("Is the car in working condition?");
            z = Console.ReadLine();
            Console.WriteLine(z);
        }
        */
    }



    internal class Program
    {

        static void Main(string[] args)
        {

            Civic obj = new Civic();
            obj.vehicleType();
            obj.brand();
            obj.speed();
            
            
            //obj.working();   
            Console.ReadLine();

        }
    }
}