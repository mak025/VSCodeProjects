namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a BM ICalculator. To Get started please enter your weight in kg");
            string weight = Console.ReadLine();
            float w = float.Parse(weight);

            Console.WriteLine("Please enter your height in cm");
            //byte is used rather than int as it has less of an impact on the codes performance and can hold the information in question.
            //byte can hold 0-255 <- as no person is more than 255cm in height then a byte is sufficient in this 
            byte height = byte.Parse(Console.ReadLine());
            Console.WriteLine($"{weight} + {height}");

            //Information gathered. Below will calculate the users BMI
            double bmi = w / ((height / 100.0) + (height / 100.0));
            Console.WriteLine($"{bmi}");

            if ((bmi > 16) && (bmi < 18.5))
            {
                Console.WriteLine("you are underweight");
            }
            else if ((bmi >= 18.5) && (bmi < 24))
            {
                Console.WriteLine("You are overweight");
            }
            else if ((bmi >= 24) &&  (bmi < 30))
            {
                Console.WriteLine("Drop some weight my guy");
            }
            else
            {
                Console.WriteLine("You need to eat more... like a lot more");
            }


        }
    }
}
