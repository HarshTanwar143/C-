namespace DeviceProject
{
    internal class PortableDevices : Device, DeviceOperationsInterface
    {
        string category;
        string deviceType;
        bool stock;
        int ram;
        int portNumber;
        int discount;

        public void SetSpecificDetails()
        {
            Console.Write("Enter device category :: ");
            category = Console.ReadLine();

            Console.Write("Enter device type :: ");
            deviceType = Console.ReadLine();

            Console.Write("Stock available (yes/no) :: ");
            string input = Console.ReadLine();

            if (input == "yes")
            {
                stock = true;

                Console.Write("Enter port number :: ");
                portNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter RAM :: ");
                ram = int.Parse(Console.ReadLine());

                Console.Write("Enter discount :: ");
                discount = int.Parse(Console.ReadLine());
            }
            else
            {
                stock = false;
            }
        }

        public void UpgradeRam()
        {
            if (!stock) return;

            Console.Write("Upgrade RAM (yes/no) :: ");
            string choice = Console.ReadLine();

            if (choice == "yes")
            {
                Console.Write("Enter new RAM :: ");
                ram = int.Parse(Console.ReadLine());
            }
        }

        int SellingPrice()
        {
            return price - ((price * discount) / 100);
        }

        public void PrintDetails()
        {
            Console.WriteLine("\nCompany : " + Company);
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Price : " + price);

            if (stock)
            {
                Console.WriteLine("Category : " + category);
                Console.WriteLine("Device Type : " + deviceType);
                Console.WriteLine("Ports : " + portNumber);
                Console.WriteLine("RAM : " + ram);
                Console.WriteLine("Final Price : " + SellingPrice());
            }
            else
            {
                Console.WriteLine("No stock available");
            }
        }
    }
}
