namespace AvgTemp_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dayTemp = { 7, 4, 5, 5, 5, 4, 4, 4 };
            double sum = 0;
            double maxTemp = 0;
            double minTemp = 0;
            for (int i = 0; i < dayTemp.Length; i++)
            {
                sum += dayTemp[i];
                if (dayTemp[i] > maxTemp )
                {
                    maxTemp = dayTemp[i]; 
                }
                if (dayTemp[i] < minTemp)
                {
                    minTemp = dayTemp[i];
                }
            }
            double avgtemp = sum / dayTemp.Length;
            Console.WriteLine($"The avarage temperature this week is {avgtemp}");
            Console.WriteLine($"The max temperature this week is {maxTemp} and the min temperature is {minTemp}");
        }
    }
}
