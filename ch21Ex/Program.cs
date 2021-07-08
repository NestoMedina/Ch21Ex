using System;

namespace ch21Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer test1 = new Computer("Windows", "HP", "16 GB");
            test1.IDTag();
            Console.WriteLine(test1.ID);
            test1.PrintDetails();

            Computer test2 = new Computer("iOS", "Mac", "16 GB");
            test2.IDTag();
            Console.WriteLine(test2.ID);
            test2.PrintDetails();

            Laptop test3 = new Laptop("Windows", "HP", true);
            test3.IDTag();
            Console.WriteLine(test3.ID);
            test3.PrintDetails();

            Laptop test4 = new Laptop("Windows", "HP", true);
            test4.IDTag();
            test4.UpdateOS();
            Console.WriteLine(test4.ID);
            test4.PrintDetails();

            SmartPhone test5 = new SmartPhone("Android", "Samsung Galaxy", 5.6);
            test5.PrintScreenSize();
            test5.IDTag();
            test5.PrintDetails();

        }
    }
}
