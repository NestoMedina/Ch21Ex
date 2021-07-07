using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch21Ex
{
    public abstract class AbstractEntity
    {
        public string OSName { get; set; }
        public string Brand { get; set; }
        public static DateTime UpcomingUpdate = new (2021,09,07);
        public static DateTime FutureUpdate = new (2022, 03, 08);
        public static List<int> IDList = new List<int>();


        public AbstractEntity(string name, string brand)
        {
            this.OSName = name;
            this.Brand = brand;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"The Operating System for this machine is {OSName}, the brand is {Brand}, and the next update required is on {UpcomingUpdate}.");
        }

        public void UpdateOS()
        {
            UpcomingUpdate = FutureUpdate;
            Console.WriteLine($"{OSName} is now updated. Your next update is on {UpcomingUpdate}.");
        }

        public abstract void IDTag();

    }
}
