using System;

namespace DemoEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = createmenu();
            Console.Clear();
            Console.Write(menu);
            var option = Console.ReadLine();
            selectMenu(option);
        }

        private static void selectMenu(string option)
        {
            try
            {
                int optionInt = int.Parse(option);
                switch (optionInt)
                {
                    case 1:
                        multiplyMenu();
                        break;
                    case 2:
                        fibonaciiMenu();
                        break;
                    case 3:
                        helloMenu();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Valid options are numbers from 1 to 4");
                        Console.WriteLine("Press any key to continue and try again");
                        Console.ReadLine();
                        Main(null);
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Valid options are numbers from 1 to 4");
                Console.WriteLine("Press any key to continue and try again");
                Console.ReadLine();
                Main(null);
            }

        }

        private static void helloMenu()
        {
            Console.Clear();
            Console.Write("\n\t Username: ");
            var username = Console.ReadLine();
            Console.WriteLine($"Hello {username} it's {DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss")}");
            Console.WriteLine("Press any key to continue ");
            Console.ReadLine();
            Main(null);
        }

        private static void fibonaciiMenu()
        {
            Console.Clear();
            for (int i = 0; i < 50; i++)
            {
                var num = MathOperations.Fibonacci(i);
                Console.WriteLine(num);
                MathOperations.writeToFile(num.ToString());
            }
            Console.WriteLine("Press any key to continue ");
            Console.ReadLine();
            Main(null);
        }

        static string createmenu()
        {
            string menu = $"\n\n    Demo console App    \n\n" +
                $" 1. Multiply \n" +
                $" 2. Fibonacci sequence\n" +
                $" 3. Say hello\n" +
                $" 4. Exit\n" +
                $"\n\n Select an option: ";
            return menu;
        }

        static void multiplyMenu()
        {
            Console.Clear();
            var num1 = getValidNumber("1");
            Console.Clear();
            var num2 = getValidNumber("2");
            Console.Clear();
            var result = $"\n\t {num1.ToString()} times {num2.ToString()} is {(MathOperations.multiply(num1, num2)).ToString()}\n\n";
            Console.Write(result);
            Console.WriteLine("Press any key to continue ");
            var optionErr = Console.ReadLine();
            Main(null);
        }
        static double getValidNumber(string num)
        {
            double num2d = 0.0d;
            var menu2 = $"\n\n Please enter number {num}: \n";
            Console.Write(menu2);
            var num2 = Console.ReadLine();
            try
            {
                num2d = Double.Parse(num2);
            }
            catch (Exception)
            {
                Console.WriteLine("Not a valid number");
                Console.WriteLine("Press any key to continue and try again (m to return to the menu)");
                var optionErr = Console.ReadLine();
                if (optionErr == "m" || optionErr == "M") Main(null);
                getValidNumber(num);
            }
            Console.Clear();
            return num2d;
        }

    }
}
