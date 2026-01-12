using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceProject
{
    internal class Device
    {

        // DATA FIELDS
        const string Company = "TechWorld";
        public static int DeviceCount;
        readonly string serialNumber;
        int price;
        int RAM;
        String brand;
        String model;

        //STATIC CONSTRUCTOR
        static Device()
        {
            DeviceCount = 0;    
        }

        //DEFAULT CONSTRUCTOR
        public Device()
        {
            Console.WriteLine("Default Device Constructor invoked!");
        }

        // PARAMETERIZED CONSTRUCTOR
        public Device(int price, int RAM, string brand, string model, string serialNumber)
        {
            Console.WriteLine("Parameterized Device Constructor invoked!");
            this.price = price;
            this.RAM = RAM;
            this.brand = brand;
            this.model = model;
            this.serialNumber = serialNumber;
            DeviceCount++;
        }

        // COPY CONSTRUCTOR
        public Device(Device obj)
        {
            Console.WriteLine("Copy Constructor invoked!");
            this.price = obj.price;
            this.RAM = obj.RAM;
            this.brand = obj.brand;
            this.model = obj.model;
            this.serialNumber = obj.serialNumber;
            DeviceCount++;
        }

        // MEMBER FUNCTIONS
        public void setDetails(int price, int RAM, String brand, String model)
        {
            this.price = price;
            this.RAM = RAM;
            this.brand = brand;
            this.model = model;
        }

        public void printDetails()
        {
            Console.WriteLine("\nCompany : " + Company);
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("Model : " + model);
            Console.WriteLine("RAM : " + RAM);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Serial Number : " + serialNumber);
            Console.WriteLine("Total Devices : " + DeviceCount);
        }

        public void upgradeRam(int RAM)
        {
            this.RAM = RAM;
        }


    }

}
