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

            Computer test2 = new Computer("iOS", "Mac", "16 GB");
            test2.IDTag();
            Console.WriteLine(test2.ID);

            Laptop test3 = new Laptop("Windows", "HP", true);
            test3.IDTag();
            Console.WriteLine(test3.ID);

            Laptop test4 = new Laptop("Windows", "HP", true);
            test4.IDTag();
            test4.UpdateOS();
            Console.WriteLine(test4.ID);

            Console.WriteLine(AbstractEntity.UpcomingUpdate);


        }
    }
}
