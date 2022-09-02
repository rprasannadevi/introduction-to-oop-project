using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introduction_to_oop_project
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name,color)
        {

        }

        public override void Speak()
        {
            Console.WriteLine($"Hi! I'm {Name} and I'm a {Color} Parrot and I could tell whatever you teach me!");
        }
    }
}