namespace DeviceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PortableDevices laptop = new PortableDevices();

            laptop.setDetails();
            laptop.SetSpecificDetails();
            laptop.UpgradeRam();
            laptop.PrintDetails();

            Console.WriteLine("\nTotal number of devices :: " + Device.DeviceCount);
            Console.ReadLine();
        }
    }
}
