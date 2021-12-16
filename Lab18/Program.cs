using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку со скобками");
            string str = Console.ReadLine();
            char temp;
            Stack<char> stackForCheck = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    Console.WriteLine("Запись в стек " + ')');
                    stackForCheck.Push(')');
                }
                else if (str[i] == '[')
                {
                    Console.WriteLine("Запись в стек " + ']');
                    stackForCheck.Push(']');
                }
                else if (str[i] == '{')
                {
                    Console.WriteLine("Запись в стек " + '}');
                    stackForCheck.Push('}');
                }
                else if (str[i] == ')')
                {
                    temp = stackForCheck.Pop();
                    if (temp != str[i])
                    {
                        Console.WriteLine("Лишняя скобка!");
                        break;
                    }
                }
                else if (str[i] == ']')
                {
                    temp = stackForCheck.Pop();
                    if (temp != str[i])
                    {
                        Console.WriteLine("Лишняя скобка!");
                        break;
                    }
                }
                else if (str[i] == '}')
                {
                    temp = stackForCheck.Pop();
                    if (temp != str[i])
                    {
                        Console.WriteLine("Лишняя скобка!");
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(stackForCheck.Count);
            if (stackForCheck.Count > 0)
            {
                Console.Write("В стеке остались символы.");
            }
            else
            {
                Console.Write("В стеке нет символов.");
            }
            Console.ReadKey();
        }
    }
}
