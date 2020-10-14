using System;
using System.Linq;
namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] age = { 12, 23, 21, 22, 45, 33, 20, 26, 55, 66 };
            //var a = from i in age
            //        where i > 20
            //        orderby i descending
            //        select i;

            string[] names = { "Devesh", "red", "Batman", "Tim" };
            var a = from name in names
                    where name.Contains("e")
                    select name;
            //Case senstive hai
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
