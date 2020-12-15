using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        { 
         Console.WriteLine("Enter Math results:");
         var Matke = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Physics results:");
         var Fizika = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Chemistry results:");
         var Chemija = int.Parse(Console.ReadLine());

         if (Matke + Fizika + Chemija >=180 || Matke + Fizika >= 140)
            Console.WriteLine("The candidate is eligible for admission");

         else
         {
             Console.WriteLine("The candidate is not eligible for admission");
         }   
        }
      
      
          
          

        
    }
}
