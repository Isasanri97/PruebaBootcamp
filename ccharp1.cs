using System;

namespace LeanTechTest
{
    class ccharp1
    {
        static int calculate_sum(int numero, int N)
    {
        // Number of multiples
        int m = N / numero;
        
        // sum of first m natural numbers
        int sum = m * (m + 1) / 2;
        // sum of multiples
        int ans = numero * sum;

        return ans;
    }
    public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca numero natural");
            int numero=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca valor de N");
            int N=int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of multiples of " + numero + " up to " + N + " = " + calculate_sum(numero, N));
        }
    }
}

