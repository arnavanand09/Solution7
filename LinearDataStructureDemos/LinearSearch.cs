using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructureDemos
{
    enum Search {Linear=1, Binary=2 };
    internal class SearchDemos
    {
        static int[] num = [2, 3, 13, 14, 45, 6, 56, 76, 3];
        static void Main()
        {
            DisplayElements();
            Console.WriteLine("enter number to search");
            int data = byte.Parse(Console.ReadLine());
            Console.WriteLine("Which Search algo ");
            int ch = byte.Parse(Console.ReadLine());
            bool found = false;
            switch (ch)
            {
                case (int)Search.Linear:
                    {
                          found = LinearSearch(data); break;
                    }
                case (int)Search.Binary:

                    {  Array.Sort(num);
                      found = BinarySearch(data); break; }
            }
            Console.WriteLine(found == true ? "Element found" : "Element not found");

        }
        static bool LinearSearch(int data)
        {
            bool flag = false;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == data)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        static bool BinarySearch(int data)
        {
            bool flag = false;
            int low = 0 , high = num.Length - 1, mid = (low+high)/2; 
            while(low <= high) {

                if(data == num[mid])
                { 
                     flag = true;
                    break;
                }
                else if(data < num[mid])
                {
                    high = mid+1;
                }
                else if(data > num[mid])
                {
                    low = mid + 1;
                }
                mid = (low+high)/2;
            }
            return flag;
        }

        static void DisplayElements()
        {
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}