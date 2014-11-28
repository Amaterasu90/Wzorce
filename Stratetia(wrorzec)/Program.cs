using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stratetia_wrorzec_
{
    class Program
    {
        static void Main(string[] args)
        {
            Workplace w = new Workplace(Mode.Towers);
            w.Draw();
            w.Update();
        }
    }
}
