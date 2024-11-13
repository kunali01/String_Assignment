using System;
using System.Text;

namespace StringPrograms
{
    internal class StringBuilderMethods
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb);
            Console.WriteLine("Hash Code: " + sb.GetHashCode());
            Console.WriteLine("Capacity: " + sb.Capacity);

            // Modifying the string using Append, Replace, Remove, and Clear methods
            sb.Append(" Good Morning");
            sb.Replace("Hello", "Hi");
            sb.Remove(2, 4); // Removes 4 characters starting at index 2
            sb.Clear();
            Console.WriteLine("Capacity after Clear: " + sb.Capacity);
            Console.WriteLine("Length after Clear: " + sb.Length);

            // Demonstrating CopyTo
            sb.Append("Hello World");
            char[] chs = new char[5];
            sb.CopyTo(3, chs, 0, 5); // Copies 5 characters starting from index 3
            string str1 = new string(chs); // Converts char array to string

            Console.WriteLine("Copied string from sb: " + str1);
        }
    }
}
