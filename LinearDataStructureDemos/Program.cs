namespace LinearDataStructureDemos
{
    internal class Program
    {
        static int[] num = [12, 19, 20, 22, 0, 0, 0, 0, 0, 0, 0];

        static void Main(string[] args)
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
                        InsertElement(temp); break; 
                        }
                    case 4: Display(); break;
                   
                }
            }
        }
        static int GetMenu()
        {
            Console.WriteLine("Enter your choice");
            int ch = byte.Parse(Console.ReadLine());
            Console.WriteLine("1. INSERT ELEMENT");
            Console.WriteLine("2. Add Element");
            Console.WriteLine("3. Delete Element");
            Console.WriteLine("4. Display Elements");
            return ch;

        }
        static bool InsertElement(int temp)
        {
            int posOf0 = Get0();
            if (temp <= num[0])
            {
                for (int i = posOf0; i > 0; i--)
                {
                    num[i] = num[i - 1];
                }
                num[0] = temp;
            }
            else if (temp > num[Get0()]-1)
            {
                num[Get0()] = temp;
            }

            return true;

        }
        static int Get0()
        {
            int pos = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == 0)

                {
                    pos = i;
                    break;
                }
            }
              return pos;
        }
        static void Display()
        {
            Console.WriteLine("Array Elements are");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
