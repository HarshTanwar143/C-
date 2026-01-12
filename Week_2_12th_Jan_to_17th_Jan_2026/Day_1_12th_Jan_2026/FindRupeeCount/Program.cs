namespace FindRupeeCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rupees :: ");
            int input = int.Parse(Console.ReadLine());

            int output = 0;
            int[] rupees = new int[] {500, 100, 50, 10, 1};
            if(input < 0)
            {
                output = -1;
            }
            else
            {
                for(int i = 0;i < rupees.Length; i++)
                {
                    while(input >= rupees[i])
                    {
                        // 1400 -> 900 -->400 --> 300->200->100->0
                        output += 1;
                        input -= rupees[i];
                    }
                }
            }
            Console.WriteLine("final count :: " + output);
        }
    }
}



