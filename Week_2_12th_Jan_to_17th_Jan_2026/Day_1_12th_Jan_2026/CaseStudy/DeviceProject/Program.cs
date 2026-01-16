namespace DeviceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INTERFACES, INHERITANCE (DEVICE DETAILS AND SPECIFICATIONS)
            PortableDevices device = new PortableDevices();

            device.setDetails();
            device.SetSpecificDetails();
            device.CheckStock();
            device.UpgradeRam();
            device.AddStock(5);
            device.RemoveStock(2);

            Console.WriteLine("\n\nIs device in stock :: " + device.IsInStock());
            Console.WriteLine("Available ports :: " + device.GetAvailablePorts());
            Console.WriteLine("Current RAM :: " + device.GetRam());
            Console.WriteLine("Category :: " + device.GetCategory());
            Console.WriteLine("Device Type :: " + device.GetDeviceType());
            Console.WriteLine("Final Selling Price :: " + device.GetFinalPrice());
            device.PrintDetails();
            Console.WriteLine("\nTotal number of devices :: " + Device.DeviceCount);


            // ABSTRACT CLASS (WARRANTY FUNCTIONALITY)
            DeviceWarranty warranty = new DeviceWarranty();
            Console.Write("\nEnter warranty years :: ");
            warranty.SetWarranty(int.Parse(Console.ReadLine()));
            Console.Write("Extend warranty (yes/no) :: ");
            string choice = Console.ReadLine();

            if (choice == "yes")
            {
                warranty.ExtendWarranty();
            }

            warranty.PrintWarrantyDetails();
            Console.ReadLine();
        }
    }
}
