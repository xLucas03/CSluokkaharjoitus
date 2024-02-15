﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiterekisteri
{
    // Base class for devices

    class Device
    {
        // Fields
        string identity = "Uusi laite";
        string dateBought = "1.1.2000";
        double price = 0.00d;
        int warranty;

        // Properties

        public string Identity
        { 
            get { return identity; } 
            set { identity = value; }
        }

        public string DateBought
        {
            get { return dateBought; }
            set { dateBought = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Warranty
        {
            get { return warranty; }
            set { warranty = value; }
        }

        // Constructors

        // A contructor with one argument
        public Device(string identity)
        {
            this.identity = identity;
        }
        public Device(string identity, string dateBought, double price, int warranty)
        {
            this.identity = identity;
            this.dateBought = dateBought;
            this.price = price;
            this.warranty = warranty;
        }

        // Other methods 
    }

    // Class for computers, inherits Device class
    class Computer : Device
    {
        // Properties

        // Constructors
        public Computer(string identity)
        {
            this.identity = identity;
        }
        // Another constructor with all arguments
        public Computer(string identity, string dateBought, double price, int warranty)
        {
            this.identity=identity;
            this.dateBought = dateBought; 
            this.price = price;
            this.warranty = warranty;
        }

        // Other methods 
    }

    // Class for computers, inherits Device class
    class SmartPhone : Device
    {

        // Fields

        // Properties

        // Constructors

        // Other methods 
    }

    // Class for computers, inherits Device class
    class Tablet : Device
    {

        // Fields

        // Properties

        // Constructors

        // Other methods 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Let's create an test object from the Device class with default constructor (0parameters)
            Device.device1 = new Device();
            Console.WriteLine(device1.Identity);

            Device.device2 = new Device();
            Console.WriteLine(device2.Identity);


            Console.ReadLine();
        }
    }

}
    }
}
