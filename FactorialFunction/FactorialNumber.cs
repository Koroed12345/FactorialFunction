namespace FactorialFunction;

public class FactorialNumber
{
    public static int Calculate(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Cannot calculate numbers less zero");
            return 0;
        }

        if (number == 0)
            return 1;

        return number * Calculate(number - 1);
    }
}