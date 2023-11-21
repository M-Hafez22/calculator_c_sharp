namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string? oper;
            int result = 0;
            // Message
            Console.WriteLine("Calculator");
            // Get Numbers
            Console.WriteLine("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            // Get oper
            Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication, or d for division.");
            oper = Console.ReadLine();
            Console.WriteLine(oper);

            if (oper == "a")
            {
                result = num1 + num2;
            }
            else if (oper == "s")
            {
                result = num1 - num2;
            }
            else if (oper == "m")
            {
                result = num1 * num2;
            }
            else if (oper == "d")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication, or d for division.");
            }
            Console.WriteLine("The Result: " + result);

        }
    }
}