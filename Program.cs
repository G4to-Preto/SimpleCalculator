namespace Calculator
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Select the option: ");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");

            int option = Convert.ToInt16(Console.ReadLine());

            switch(option)
            {
                case 1:
                    System.Console.Write("Input first number: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    System.Console.Write("Input second number: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("The Result is: " + Sum(n1, n2));
                    break;

                case 2:
                    System.Console.Write("Input first number: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    System.Console.Write("Input second number: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("The Result is: " + Subtract(n1, n2));
                    break;

                case 3:
                    System.Console.Write("Input first number: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    System.Console.Write("Input second number: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("The Result is: " + Multiply(n1, n2));
                    break;

                case 4:
                    System.Console.Write("Input first number: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    System.Console.Write("Input second number: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("The Result is: " + Divide(n1, n2));
                    break;
            }

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {}
        }

        static double Sum(double n1, double n2)
        {
            

            double result = n1 + n2;

            return result;
        }

        static double Subtract(double n1, double n2)
        {
            

            double result = n1 - n2;

            return result;
        }

        static double Multiply(double n1, double n2)
        {
            

            double result = n1 * n2;

            return result;
        }

        static double Divide(double n1, double n2)
        {
            

            double result = n1 / n2;

            return result;
        }
    }
}