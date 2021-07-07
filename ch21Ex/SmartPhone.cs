using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch21Ex
{
    public class SmartPhone : AbstractEntity
    {
        public double Screensize { get; set; }
        public int ID { get; set; }


        public SmartPhone(string name, string brand, double screensize)
            : base(name, brand)
        {
            this.Screensize = screensize;
        }

        public void PrintScreenSize()
        {
            Console.WriteLine($"The screensize for this phone is {this.Screensize} inches.");
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
