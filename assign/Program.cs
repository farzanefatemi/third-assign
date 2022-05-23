using System;

namespace session1
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum=0;
           Console.WriteLine("inter your favorite number:");
           int number=Convert.ToInt32(Console.ReadLine());
           

           for (int i = 1; i <= number ; i++)
           {
            if(i%2==1)
             {
               sum=sum+i; 
                 
             } 
               
             
           }
           Console.WriteLine($"sum is:{sum}");

        }
    
     }
 }
