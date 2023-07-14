class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("-----------------------\n");

        while (!endApp)
        {
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            Console.Write("Enter a number and press ENTER ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.WriteLine("This is not a valid input. Please enter an integer. ");
                numInput1 = Console.ReadLine();
            }

            Console.Write("Enter another number and press ENTER ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.WriteLine("This is not a valid input. Please enter an integer. ");
                numInput2 = Console.ReadLine();
            }

            Console.WriteLine("Choose one of the following operations:\n");
            Console.WriteLine("\ta - Addition");
            Console.WriteLine("\ts - Subtraction");
            Console.WriteLine("\tm - Multiplication");
            Console.WriteLine("\td - Division");
            Console.WriteLine("Operation: ");

            string op = Console.ReadLine();
            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                } else
                {
                    Console.WriteLine("Your result is: " + result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred. Details: {e.message}");
            }
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Press 'q' to quit, or any other key to continue.");

            if (Console.ReadLine() == "q") endApp = true;

            Console.WriteLine();
        }
    }
}