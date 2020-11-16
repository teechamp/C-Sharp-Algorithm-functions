using System;

namespace Question5
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
              Numbers squareArray = () =>
            {
                int[] numbers = { 6, 10, 20 };
                for (int i = 0; i < numbers.Length; i++)
                {
                    double num = Math.Pow(numbers[i], 2);
                    Console.Write(+num + " ");
                }
            };
            squareArray();
        }
    }
}

