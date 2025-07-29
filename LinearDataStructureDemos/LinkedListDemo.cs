using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructureDemos
{
    class Node
    {
        public int data;
        public Node nextNode;
    }
    internal class LinkedListDemo
    {
        Node first=null, last = null;
        Node New = null;
        Node ptr;
        public LinkedListDemo() { }
        public LinkedListDemo(int data)
        {
            New = new Node();
            New.data = data;
            New.nextNode = null;
            if(first == null)
            {
                last = first = New;
                Console.WriteLine("First node has been added");

            }
        }
        public void AddNode(int data)
        {
            New = new Node();
            New.data = data;
            last.nextNode = New;
            last = New;
            last.nextNode = null;

                Console.WriteLine("Node added at last");
            
        }
        public    void Display()
        {
            for (ptr = first; ptr != null; ptr = ptr.nextNode)
            {
                Console.WriteLine(ptr.data);
            }
        }

        static void Main()
        {
            LinkedListDemo list = new LinkedListDemo(10);

            string choice = "y";
            while (choice=="y")
            {
                Console.WriteLine("enter data to insert");
                int num = byte.Parse(Console.ReadLine());
               
                list.AddNode(num);
                choice = Console.ReadLine();

            }
            list.Display();
        }
    }
}
