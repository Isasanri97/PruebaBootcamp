using System;

namespace ccharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "description", "status"};  
            ProductTable<string> query = from product_table in words  
                            where word.Length == 3  
                            select word;  
                            foreach (string str in query)  
                            Console.WriteLine(str); 
        }
    }
}
