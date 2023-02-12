/*
 * Author: Madina Giyasova
 * Date: 02/09/2023
 * Description: Deliverable 4  - Arrays
 * 
 * 
 */

using System;
namespace Deliverable__4____Arrays;
class Program
{
    static void Main(string[] args)
    {
        int n = 25;
        int[] numbers = new int[n];
        numbers[0] = 0;
        numbers[1] = 1;

        for( int i = 2; i < n; i++)
        {
            numbers[i] = numbers[i - 2] + numbers[i - 1];

        }
        for( int i=0; i < n; i++)
        {
            Console.WriteLine("Fibonacci number (" + i + ") = " + numbers[i]);
        }

    }
}

