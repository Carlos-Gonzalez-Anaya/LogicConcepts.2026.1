namespace Shared
{
    public class Mymath
    {
        public static double factorial(int n)
        {
            double factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
