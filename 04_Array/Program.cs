using System.Text;

namespace _04_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Початок роботи з масивами


            /*
            //int arr[10] = {1,2,3,4,5,6,8,7,9,9};
            //int *arr = new int[5]{1,2,3,4,5}; 
            //C# = dynamic memory
            int[] arr = new int[5] { 0,2,7,9,4};
            string[]str = new string[3] { "Hello", "friend", "good" };
            float[] arrey = { 3.33f, 4.12f, 1.29f, 7.3f };

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //1
            //numbers = 0;
            int[]arr2 = new int[5];
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();
            //2
            int[] arr3 = new int[5] { 11, 12, 13, 14,15 };
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();
            //3
          
            //int[] == Array
            int[] arr4 = new int[] { 5, 7, 9 } ;
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine();

            //4
            int[] arr5 = new int[4];

            for (int i = 0;i < arr5.Length; i++)
            {
                arr[i] = 77;
                Console.Write(arr5[i] + " ");
            }
            Console.WriteLine();
            arr5.SetValue(77, 0);
            arr5.SetValue(99, 3);

            foreach (int elem in arr5)
            {
                //elem = 100;//readonly
                Console.Write(elem + " ");
            }
            */
            #endregion
            /*
            //row = 4, col = 4;
            int[,] arr = new int[4,4] { 
                { 2, 3, 4, 1 },
                { 2, 2, 3, 3 },
                { 7, 7, 7, 7 },
                { 10, 10, 10, 10 } 
            };

            for (int i = 0; i < arr.GetLength(0); i++)//4
            {
                for (int j = 0; j < arr.GetLength(1); j++)//4
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= arr.GetUpperBound(0); i++)//3
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)//3
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            ///3
            int[,] arr3 =
            {
                { 1,2,3},
                {4,5,6 },
                {7,8,9 }
            };
            Console.WriteLine(arr3.Length);
            Console.WriteLine(arr3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr3[i, j]} ");
                }
                Console.WriteLine();
            }
            */
            #region _3D_Arrays
            /*
              //1
            int[,,] array = new int[3, 3, 3];

            array[0, 0, 0] = 1;
            array[0, 0, 1] = 2;
            array[0, 0, 2] = 3;
            array[0, 1, 0] = 4;
            array[0, 1, 1] = 5;
            array[0, 1, 2] = 6;
            array[0, 2, 0] = 7;
            array[0, 2, 1] = 8;
            array[0, 2, 2] = 9;

            array[1, 0, 0] = 1;
            array[1, 0, 1] = 2;
            array[1, 0, 2] = 3;
            array[1, 1, 0] = 4;
            array[1, 1, 1] = 5;
            array[1, 1, 2] = 6;
            array[1, 2, 0] = 7;
            array[1, 2, 1] = 8;
            array[1, 2, 2] = 9;

            array[2, 0, 0] = 1;
            array[2, 0, 1] = 2;
            array[2, 0, 2] = 3;
            array[2, 1, 0] = 4;
            array[2, 1, 1] = 5;
            array[2, 1, 2] = 6;
            array[2, 2, 0] = 7;
            array[2, 2, 1] = 8;
            array[2, 2, 2] = 9;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }


            //2
            int[,,] array2 =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }
            };


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0} ", array2[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
             */
            #endregion
            #region ArrayMethods
            /*
            Console.OutputEncoding = Encoding.UTF8;
            int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArr("Масив myArr1", myArr1);
           
            int[] tempArr = (int[])myArr1.Clone(); // shallow copy
            PrintArr("Clone", tempArr);                                // cw        
            Array.Reverse(myArr1, 5, 3);
            PrintArr("Масив myArr1 після реверсу", myArr1);
            myArr1 = tempArr;
            PrintArr("Масив myArr1 після відновлення", myArr1);
            int[] myArr2 = new int[20];
            PrintArr("Масив myArr2 до копіювання", myArr2);
            myArr1.CopyTo(myArr2, 10);
            PrintArr("Масив myArr2 після копіювання", myArr2);
            Console.WriteLine(myArr2.Length);
            Console.WriteLine(myArr2.GetLength(0));
            Array.Clear(myArr2, 8, 3);
            PrintArr("Масив myArr2 після очистки: ", myArr2);
            Array.Resize(ref myArr2, 5);
            PrintArr("Масив myArr2 після зміни розміру:", myArr2);
            myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            PrintArr("Невідсортований масив myArr2: ", myArr2);
            Array.Sort(myArr2);
            PrintArr("Масив myArr2 після сортування: ", myArr2);
            Console.WriteLine(Array.IndexOf(myArr1, 5));
            Console.WriteLine("Число 5 знаходиться в масиві на " +
                Array.BinarySearch(myArr2, 5) + " позиції");

            Console.WriteLine("Максимальный елемент в масиві myArr2: " + myArr2.Max());
            Console.WriteLine("Мінімальний елемент в масиві myArr2: " + myArr2.Min());
            Console.WriteLine("Середнє арифметичне елементів myArr2: " +
                myArr2.Average());

            Console.WriteLine("Кількість вимірів масиву myArr3: " + myArr2.Rank);
            int[,] myArr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Кількість вимірів масиву myArr3: " + myArr3.Rank);
            */
            #endregion



            #region Jagged_array

            // зубчастий масив
            int[]  []jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };

            Console.WriteLine(jagged.Length);

            // перебор с помощью цикла for
            for (int i = 0; i < jagged.Length; ++i)//3
            {
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                   // Console.Write($"{i};{j}={     jagged[i][j]     }  ");
                    Console.Write($" {jagged[i][j]}  ");
                }
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.ReadKey(); 

            foreach (int[] item in jagged)
            {
                foreach (int i in item)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }

            #endregion

            int[] arr = new int[] { 3, 3, 3, 7, 7, 7 };
            double[] arr2 = new double[] { 3, 3, 3, 7, 7, 7 };
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = int.Parse(Console.ReadLine()!);
               arr2[i] = Math.Round(rnd.Next(100) + rnd.NextDouble(), 2);
                //arr2[i] = rnd.Next(100) + rnd.NextDouble();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine(arr[i]);
                Console.WriteLine(arr2[i]);
            }

        }
        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
