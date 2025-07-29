using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructureDemos
{
    internal class StackDemo
    {
        static int[] num = new int[10];
        static int top = -1;
        static void Main()
        {

            string choice = "y";
            while (choice == "y")
            {
                int ch = GetMenu();
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("enter element to insert");
                            int temp = byte.Parse(Console.ReadLine());
                            Push(temp); 
                            break;
                        }
                    case 2:
                        {
                            Pop(); break;
                        }
                    case 3: Display(); break;

                }
                Console.WriteLine("Repeat");
                choice = Console.ReadLine();
            }
            static int GetMenu()
            {
                Console.WriteLine("Enter your choice");
                int ch = byte.Parse(Console.ReadLine());
                Console.WriteLine("1. INSERT ELEMENT");

                Console.WriteLine("2. Delete Element");
                Console.WriteLine("3. Display Elements");
                return ch;

            }

            static int Push(int temp)
            {
                if(top >= num.Length-1)
                {
                    Console.WriteLine("OVERFLOW");
                }
                else
                {
                    num[++top] = temp;
                    Console.WriteLine("VALUE OF TOP IS "+ top);
                }
                return top;

            }

            static int Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("UNDERFLOW");

                }
                else
                {
                    --top;
                    Console.WriteLine("TOP IS " + top);
                }
                return top;

            }
            static void Display()
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
