using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfString1 = { "1", "2", "1" };
            string[] arrayOfString2 = { "3", "2", "5", "7" };

            Stack<string> stackOfString = new Stack<string>();

            ExcludeRepetitions (arrayOfString1, stackOfString);
            ExcludeRepetitions (arrayOfString2, stackOfString);

            while (stackOfString.Count > 0)
            {
                Console.WriteLine(stackOfString.Pop());
            }
            Console.ReadLine();
        }

        static void ExcludeRepetitions (string[] array, Stack<string> stack)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (stack.Contains(array[i]))
                {
                    continue;
                }

                stack.Push(array[i]);
            }
        }
    }
}
