using System;
using System.Collections.Generic;
using System.Text;

namespace Bconsole
{
    class Children : Person
    {
        public string eyeColor;

        public void ShowDataChildren()
        {
            showData();
            Console.WriteLine("Eye is : {0}",eyeColor);
        }
    }
}
