namespace WineSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] sales = { 175134, 175388, 172818, 142709, 141437, 152620, 150979, 152210, 149450, 154398, 150160};
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                const int max = 175388;
                const byte maxStar = 100;
                int star = maxStar * sales[i] / max;
                Console.WriteLine("");
                for(int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
