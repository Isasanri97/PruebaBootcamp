using System;

namespace ccharp3
{
    class Program
    {
         static int spiralDiaSum(int n)
    {
        if (n == 1)
            return 1;
     
        // as order should be only odd
        // we should pass only odd-integers
        return (4 * n * n - 6 * n + 6 +
                spiralDiaSum(n - 2));
    }
        public static void Main (String[] args)
        {
            Console.WriteLine("Introduzca numero natural");
            int n=int.Parse(Console.ReadLine());
            Console.Write(spiralDiaSum(n));
            }
    }
}
