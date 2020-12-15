using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        { 
          Console.WriteLine("Enter first letter: ");    
          var pirma = Console.ReadLine();
          Console.WriteLine("Enter second letter: ");
          var antra = Console.ReadLine();
          Console.WriteLine("Enter third letter: ");
          var trecia = Console.ReadLine();
          var allLetters = trecia + antra + pirma;  
          Console.WriteLine(allLetters);
        }
      
      
          
          

        
    }
}
