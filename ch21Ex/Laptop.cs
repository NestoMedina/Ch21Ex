
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch21Ex
{
    public class Laptop : AbstractEntity
    {
        public bool touchscreen { get; set; }
        public int ID { get; set; }

        public Laptop(string name, string brand, bool tscreen)
            : base (name, brand)
        {
            this.touchscreen = tscreen;
        }

        public void ToggleTouchScreen(string input)
        {
            if (input.ToLower() == "off")
            {
                this.touchscreen = false;
            }
            else if (input.ToLower() == "on")
            {
                this.touchscreen = true;
            }
            else if (input.ToLower() != "on" || input.ToLower() != "off")
            {
                Console.WriteLine("Please enter 'on' or 'off'.");
            }
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
