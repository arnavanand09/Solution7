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
                    case 2:
                        {
                            Console.WriteLine("enter element to delete");
                            int temp = byte.Parse(Console.ReadLine());
                            Delete(temp); break;
                        }
                    case 4: Display(); break;
                   
                }
                Console.WriteLine("Repeat");
                choice = Console.ReadLine();
            }
        }
        static int GetMenu()
        {
            Console.WriteLine("Enter your choice");
            int ch = byte.Parse(Console.ReadLine());
            Console.WriteLine("1. INSERT ELEMENT");
             
            Console.WriteLine("3. Delete Element");
            Console.WriteLine("4. Display Elements");
            return ch;

        }
        static bool InsertElement(int temp)
        {
            int posOf0 = Get0();
            Console.WriteLine("POS OF 0 " + posOf0);
            if (temp <= num[0])
            {
                for (int i = posOf0-1; i >= 0; i--)
                {
                    num[i+1] = num[i];
                }
                num[0] = temp;
            }
            else if (temp > num[posOf0 - 1])
            {
                num[posOf0] = temp;
            }

            else
            {
                Console.WriteLine("ELEMENT SHALL COME IN BET");
                for (int j = 0; j < posOf0- 1; j++)
                {
                    if (temp > num[j] && temp <= num[j + 1])
                    {
                        Console.WriteLine("J IS " + j);
                        for (int k = Get0() - 1; k > j; k--)
                        {
                            num[k + 1] = num[k];
                        }

                        Console.WriteLine("j IS " + j);
                        num[j + 1] = temp;
                        break;
                    }
                }


            }
                return true;
            }
        static bool Delete(int temp)
        {
            int posOf0 = Get0();
            if (temp == num[posOf0 - 1])

                {
                num[posOf0 - 1] = 0;
            }
            else
            {
                for(int i=0;i<posOf0 - 1;i++)
                {
                    if(temp == num[i])
                    {
                        for(int j = i+1;j< posOf0;j++)
                        {
                            num[j-1] = num[j];
                        }
                    }
                    num[posOf0-1] = 0;
                }
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
