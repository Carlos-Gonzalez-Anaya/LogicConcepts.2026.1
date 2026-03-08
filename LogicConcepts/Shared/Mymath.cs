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



        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;

        }

        public static List<int> listPrimes(int n)
        {
            var primes = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;

        }
    }
}
