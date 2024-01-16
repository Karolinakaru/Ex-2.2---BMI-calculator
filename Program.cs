internal class Program
{
    public static void Main(string[] args)
    {
        double weight, height, result;
        Console.WriteLine(" Please enter your body weight in kg and press Enter");
        weight = double.Parse(Console.ReadLine());

        Console.WriteLine(" Please enter your body height in m and press Enter (example 1,74)");
        height = Convert.ToDouble(Console.ReadLine());

        result = Convert.ToDouble(weight/Math.Pow(height, 2));
     
        Console.WriteLine("Your BMI is: {0:F2}", result);// the result is rounded to 2 decimal places
        Console.WriteLine();
        Console.WriteLine("Press any key to exit");
        //Console.WriteLine("Your BMI is: " + result + "Pres any key to exit");
        Console.ReadKey();


    }
}