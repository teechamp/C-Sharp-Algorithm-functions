using System;
using System.Linq;

namespace Question1
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers Print1to255 = () => { 
            for (int i=1; i<=255; i++)
           {
              Console.WriteLine(i);
           }
           };
           Print1to255();
           
            
            
           
        }

    
    }
}

