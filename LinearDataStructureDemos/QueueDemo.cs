using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructureDemos
{
    internal class QueueDemo
    {
        static int[] num = new int[10];
        static int front = -1, rear =-1;
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
                            Insert(temp); 
                            break;
                        }
                    case 2:
                        {
                            Delete(); break;
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

            static int Insert(int temp)
            {
                if(rear >= num.Length-1)
                {
                    Console.WriteLine("OVERFLOW");
                }
                else if(front==rear && front ==-1)
                {
                    num[++front] = temp;
                    ++rear;
                }
                else
                {
                    num[++rear] = temp;
                    Console.WriteLine("VALUE OF rear IS " + rear);
                }
                return rear;

            }

            static int Delete()
            {
                if (front == -1)
                {
                    Console.WriteLine("UNDERFLOW");

                }
                else
                {
                    ++front;
                    Console.WriteLine("FRONT IS " + front);
                }
                return front;

            }
            static void Display()
            {
                if (front == -1)
                {
                    Console.WriteLine("NO element");
                }
                else
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.WriteLine(num[i]);
                    }
                }
            }
        }
    }
}
