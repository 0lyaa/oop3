using System;

namespace Laba6._1
{
    public class Program
    {
        public static void Main()
        {
            MyDictionary<string, string> a = new MyDictionary<string, string>();
            a.Add("Apple", "Яблуко");
            a.Add("Orange","Апельсин");
            a.Add("Coffee", "Кава");
            a.Add("Book", "Книга");
            a.PrintList();

            Console.WriteLine("Загальна кiлькiсть слiв: " + a.GetLengthK());
        }



    }
}