using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_Assignment_On_Word
{
    internal class RemoveExtraSpace
    {
        static void Main(string[] args)
        {
            string input = "Hello    world   from  C#";
            string result = Regex.Replace(input, @"\s+", " ");
            Console.WriteLine(result);
        }
    }
}
