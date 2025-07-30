using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructureDemo
{
    class Node
    {
        public int Data;
        public Node NextNode;
    }
    internal class SingleLinkedList
    {
        Node start = null, last = null, New = null, ptr, prev;
        public SingleLinkedList(int data)
        {
            New = new Node();
            New.Data = data;
            New.NextNode = null;
            if(start == null)
            {
                start = New;
                last = New;
                Console.WriteLine("First Node has been added to the list");
            }
        }
        public void AddNode(int data)
        {
            New = new Node();
            New.Data = data;
            New.NextNode = null;
            if (New.Data <= start.Data)
            {
                New.NextNode = start;
                start = New;
                Console.WriteLine("Node added in beg");
            }
            else if (New.Data > last.Data)
            {
                last.NextNode = New;
                last = New;
                Console.WriteLine("Node added at end");
            }
            else
            {
                for (ptr = start; ptr.NextNode != null; ptr = ptr.NextNode)
                {
                    if (New.Data >= ptr.Data && New.Data < (ptr.NextNode).Data)
                    {
                        New.NextNode = ptr.NextNode;
                        ptr.NextNode = New;
                      
                        Console.WriteLine("Node added in between");
                        break;
                    }

                }
            }
        }
        public void RemoveNode(int data) {

            if (data == start.Data)
            {

                start = start.NextNode;
                Console.WriteLine("Start Node deleted");
            }
            else if (data == last.Data)
            {
                for (prev = ptr = start; ptr.NextNode != null; prev = ptr, ptr = ptr.NextNode) ;
                prev.NextNode = null;
                last = prev;
                Console.WriteLine("Node deleted from end");
            }
            else
            {
                for (prev = ptr = start; ptr.NextNode != null; prev = ptr, ptr = ptr.NextNode)
                {
                    if (data == ptr.Data)
                    {
                        prev.NextNode = ptr.NextNode;
                        break;
                    }
                }
            }
            }
        public void DisplayList()
        {
            for (ptr = start; ptr != null; ptr = ptr.NextNode)
            {
                Console.WriteLine(ptr.Data);

            }
        }
    }
    public class Program
    {

    
        static void Main()
        {
            SingleLinkedList list = new SingleLinkedList(10);
           

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("enter data");
                int num = byte.Parse(Console.ReadLine());
                list.AddNode(num);
                Console.WriteLine("Want to add more data");
                choice = Console.ReadLine();

            }
            list.DisplayList();
            choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("enter data to delete");
                int num = byte.Parse(Console.ReadLine());
                list.RemoveNode(num);
                Console.WriteLine("Want to delete more data");
                choice = Console.ReadLine();

            }
            list.DisplayList();
        }
    }
}
