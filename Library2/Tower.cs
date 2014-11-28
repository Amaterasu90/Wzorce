using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Tower : IUsable
    {
        public void Draw()
        {
            Console.WriteLine("Draw " + this.GetType().ToString());
        }

        public void Update()
        {
            Console.WriteLine("Update " + this.GetType().ToString());
        }
    }
}
