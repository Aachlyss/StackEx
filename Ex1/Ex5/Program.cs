using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            { 
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (command[0])
                {
                    case 1:
                        stack.Push(command[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(stack.Max());
                        break;
                    case 4:
                        Console.WriteLine(stack.Min());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
