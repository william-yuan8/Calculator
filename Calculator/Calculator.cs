using System.Diagnostics.Tracing;

class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;

        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                while (num2 == 0)
                {
                    Console.WriteLine("Divisor cannot be 0.");
                    Console.Write("Choose another divisor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                result = num1 / num2;
                break;
            default:
                break;
        }
        return result;
    }
}