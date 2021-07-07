using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch21Ex
{
    public class Computer : AbstractEntity
    {
        public string RAM { get; set; }
        public int ID { get; set; }


        public Computer(string name, string brand, string ram)
            : base(name, brand)
        {
            this.RAM = ram;
        }

        public void PrintRamDetails()
        {
            Console.WriteLine($"Your RAM power is {RAM}.");
        }

        public override void IDTag()
        {
            int i = 0001;
            while (IDList.Contains(i) == true)
            {
                i++;
            }
                IDList.Add(i);
                this.ID = i;
        }
        
    }
}
