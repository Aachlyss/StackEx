using System;
using System.Collections.Generic;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else
                {
                    stack.Push(int.Parse(input));
                }
            }
            int n = int.Parse(Console.ReadLine());
            if (stack.Contains(n))
            {
                Console.WriteLine("True");
            }
            else
            {
                stack.Pop();
                Console.WriteLine(string.Join("; ",stack));
            }
        }
    }
}
