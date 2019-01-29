using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Button
    {
        public char CheckButton()
        {
             char button = Console.ReadKey().KeyChar;
            return button ;
        }
    }
}
