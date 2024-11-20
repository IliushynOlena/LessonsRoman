namespace _02_CyclesDtaTYpes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CLR - Command Language Runtite
            //Not nullable
            //Simple types = value type - Stack
            int a = 7;//4b
            int b = 5;    
            double pi = 3.14;//8b
            Double d = 1.25;
            float temperature = 36.6f;//4b
            Single s = 2.25f;
            char symbol = 'A';  
            bool flag = false;
            //enum, struct


            int f;
            f = 100;
            float h;
            //Nullable< int> g = null;
            //Nullable< int> g = 5;
            int? g = 5;

            //Nullablle data type - Heap
            String str = "Hello";
            string name;
            string surname = null;
            surname = "Iliushyn";

            DateTime dateTime = DateTime.Now;//Stakc
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToShortTimeString());
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToString("yyyy-MM-dd"));

            bool myBool = true;
            short myShort = 6;
            int myInt = myShort;

            float myFloat = 3.14f;//4b = 3.1400000
            double muDouble = myFloat;//8b = 3.140000000000000

            int myInt2 =(int) muDouble; //3

            //double number = double.Parse(Console.ReadLine());   
            string strnumber =Console.ReadLine();
            try
            {
                double number = double.Parse(strnumber);
                Console.WriteLine($"Number Parse = {number}");
                number = Convert.ToDouble(number);
                Console.WriteLine($"Number Convert = {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //Null conditional operator

            //int num = 6;
            //Nullable<int> num = 6;
            int? num = 6;//allow null 
            int? num2 = null;


            string message1 = null;
            string message2 = message1;

            if (message1 != null)
            {
                message1.ToUpper(); 
            }
            //null conditional operator
            message1?.ToUpper();

            if (message2 == null)
            {
                message2 = "Empty";
            }
            else
            {
                message2 = "Hello";
            }
            //or
            message2 = (message2 == null) ? "Empty" : "Hello";
            //or
            message2 = "Hello" ?? "Empty";
            int start = int.Parse(Console.ReadLine());  
            int end = int.Parse(Console.ReadLine());  
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }


        }
    }
}
