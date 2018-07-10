namespace DemoEx1
{
    public static class MathOperations
    {
        public static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Fibonacci(int n)
        {
            double a = 0;
            double b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (double i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        public static void writeToFile(string line)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Temp\Fibo.txt", true))
            {
                file.WriteLine(line);
            }
        }

    }
}
