using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introduction_to_oop_project
{
    public abstract class Bird : IDance
    {
        protected string Name { get; private set; }
        protected string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void Speak();

        /*public void Speak()
        {
            Console.WriteLine($"My name is {Name} and I am a {Color} bird.");
        }*/

        public virtual void Fly()
        {
            Console.WriteLine("Hi there! I can fly.");
        }

        public void Spin()
        {
            Console.WriteLine($"{Name} spin!");
;       }

        public void DoTheCaterpillar()
        {
            Console.WriteLine($"{Name} do the wriggly woo!");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jump in the air!");
        }
    }
}