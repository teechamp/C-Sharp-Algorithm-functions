
using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            
            Func< int[], int> largestNumber = (num) => { 
                for (int i = 0; i < num.Length; i++)
                {
                    if(num[i] > max)
                    {
                        max = num[i];
                    }
                }
                return max;
            };
            int[] arr = {19, 30, 12};
            Console.WriteLine(largestNumber(arr));
        }
    }
}
