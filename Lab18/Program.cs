using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (Check(str))
            {
                Console.WriteLine("Строка корректна");
            }
            else
            {
                Console.WriteLine("Строка не корректна");
            }

            Console.ReadKey();
        }

        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                {'(', ')' },
                {'[', ']' },
                {'{', '}' },
            };
            foreach (char c in str)
            { 
                if (c == '(' ||  c =='[' ||  c == '{'  ) stack.Push(sk[c]);
                if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0 || stack.Pop()!=c)
                    {
                        return false;
                    }                
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
