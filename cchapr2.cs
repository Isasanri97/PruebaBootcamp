using System;
using System.Collections.Generic;

namespace ccharp2
{
    class Program
    {
    public static void Main(){

      var listOfNumbers = new List<Number>();
      {
    
        for (int n = 0; n < 5; n++)
        {
            Console.WriteLine("Introduzca numero natural");
            n=int.Parse(Console.ReadLine());
            new Number();
        }
        
        Console.WriteLine(listOfNumbers);
      }
    }
    }
    class Number
    {
        public int num {get; set;}
    }
  }




