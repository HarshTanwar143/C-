namespace DeviceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Device laptop = new Device();

            //laptop.setDetails(65000, 8, "HP", "Pavilion");

            //Console.WriteLine("Before RAM Upgrade:");
            //laptop.printDetails();

            //laptop.upgradeRam(16);

            //Console.WriteLine("\nAfter RAM Upgrade:");
            //laptop.printDetails();


            // CONSTURCTORS AND DATA FIELDS
            Device d1 = new Device(65000, 8, "HP", "Pavilion", "SN001");
            Device d2 = new Device(72000, 16, "Dell", "Inspiron", "SN002");
            Device d3 = new Device(d1);


            d1.printDetails();
            Console.WriteLine();
            d2.printDetails();
            Console.WriteLine();
            d3.printDetails();
            Console.WriteLine("\nTotal number of devices:: " + Device.DeviceCount);
            Console.ReadLine();
        }
    }
}



