using System;
using System.Collections.Generic;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();

            foreach(string name in input)
            {
                if (name[0]=='a'||name[1]=='b'|| name[2]=='c')
                {
                    stack.Push(name);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }

    }
}
