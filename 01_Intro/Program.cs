using System.Collections.Specialized;

namespace _01_Intro
{
    class User: Object
    {
        public static string Name { get; set; }
        static public void Print()
        {
            Console.WriteLine(Name);
        }
    }
    //enum = const int
    enum Couries { USA=10, Canada, Ukraine , Poland , France = 33, Oregon }
    class Program
    {
        static void Main(string[] args)
        {
            const int USA = 1;
            const int Canada =2;
            const int Ukraine = 3;
            const int Poland = 4;
            const int France = 5;

            object obj = new object();
            

            User user = new User();
            int a = 5;
            int b = 6;    

            float c = 7.3f;//7.14785698 26454549548
            float d = 3.3f;

            //int o = 3.336;
            //cout<< 3 <<endl;
            double e = 1.25;//1.258965874521458
            Double r = 7.12;

            short g = 32;
            Int16 j = 4;

            Console.WriteLine("Enter number : ");
            //string str = Console.ReadLine();
            //int number = int.Parse(str);
            //int number = int.Parse(Console.ReadLine());
           
            //Console.WriteLine("Number : " + number.ToString());
            //Console.WriteLine("Number : " + number.ToString() + 100.ToString());
            //Console.WriteLine($"Number : {number + 10}");

            int num = 341256;
            Console.WriteLine(num/100000);
            Console.WriteLine(num/10000%10);
            //User user = new User();
            //User.Name = "Test 2";
            //User.Print();
            // user.Name = "Test";
            //Console.WriteLine(user.Name);
        }
    }
  
    
}
