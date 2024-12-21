using System.Text;

namespace _06_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            foreach (char letter in str)
            {
                if (Char.IsUpper(letter))
                    countletter++;
            }
        
            str += "bla";
            str += "bla";
            str += "bla";
            str += "bla";
            str += "bla";
            str += "bla";
            str += "bla";
            str += "bla";
            Console.WriteLine(str);

            StringBuilder builder = new StringBuilder();
            Console.WriteLine($"String lenght : {builder.Length}");
            Console.WriteLine($"String capacity : {builder.Capacity}");
            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"String lenght : {builder.Length}");
            Console.WriteLine($"String capacity : {builder.Capacity}");
            builder.AppendLine("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"String lenght : {builder.Length}");
            Console.WriteLine($"String capacity : {builder.Capacity}");
            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"String lenght : {builder.Length}");
            Console.WriteLine($"String capacity : {builder.Capacity}");
            Console.WriteLine(builder);

        }
    }
}
