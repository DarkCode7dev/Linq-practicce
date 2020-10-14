using System;
using System.Linq;
namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
//Case senstive hai
            string[] names = { "Devesh", "red", "Batman", "Tim" };
            var a = from name in names
                    where name.Contains("e")
                    select name;
            
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
