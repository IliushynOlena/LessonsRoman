namespace _03_Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("### ");
                }
                Console.WriteLine();
            }

            int N = 4;
            // N — розмірність
            // таблиці
            for (int i = 0; i < N; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    // головна діагональ
                    if (i == j)
                        Console.Write(" + ");
                    else
                        Console.Write(" = ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // головна діагональ
                    if (i + j  == N - 1)
                        Console.Write(" + ");
                    else
                        Console.Write(" = ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // головна діагональ
                    if (i >= j)
                        Console.Write(" + ");
                    else
                        Console.Write(" = ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // головна діагональ
                    if (i <= j)
                        Console.Write(" + ");
                    else
                        Console.Write(" = ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            /*
            Console.Title = "Hello world";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
            Console.Clear();
            //Console.SetWindowSize(40, 80);
            for (int i = 10; i <= 5; i++)
            {
                Console.WriteLine($" i = {i}");
            }

            int a = 10;
            while (a <= 5)
            {
                Console.WriteLine($" a = {a}");
                a++;
            }

            int b = 10;  
            do
            {
                Console.WriteLine($" b = {b}");
                b++;
            } while (b <= 5);
            */
            //int key;
            //Console.WriteLine("1 - add; 2 - minus; 3 - multy; 4 - div; 0 - exit");
            //key = int.Parse(Console.ReadLine());//1
            //while (key != 0) 
            //{                
            //    switch (key)
            //    {
            //        case 1:
            //            Console.WriteLine("a + b");
            //            break;
            //        case 2:
            //            Console.WriteLine("a + b");
            //            break;
            //        case 3:
            //            Console.WriteLine("a + b");
            //            break;
            //        case 4:
            //            Console.WriteLine("a + b");
            //            break;
            //        case 0:
            //            Console.WriteLine("Good bye");
            //            break;
            //        default:
            //            Console.WriteLine("error");
            //            break;
            //    }
            //    Console.WriteLine("1 - add; 2 - minus; 3 - multy; 4 - div; 0 - exit");
            //    key = int.Parse(Console.ReadLine());//1
            //}
            /*
            int key;
            do
            {
                Console.WriteLine("1 - add; 2 - minus; 3 - multy; 4 - div; 0 - exit");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("a + b");
                        break;
                    case 2:
                        Console.WriteLine("a + b");
                        break;
                    case 3:
                        Console.WriteLine("a + b");
                        break;
                    case 4:
                        Console.WriteLine("a + b");
                        break;
                    case 0:
                        Console.WriteLine("Good bye");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            } while (key != 0);



            Console.WriteLine(  );
            int[] arr = new int[5] { 11,12,13,14,15};
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = 0;
            //}

            for (int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

          
            foreach (int elem in arr)
            {
                //elem = 0;//readonly
                Console.WriteLine(elem);
            }
          
            */


        }
    }
}
