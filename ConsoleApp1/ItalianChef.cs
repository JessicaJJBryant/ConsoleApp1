using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ItalianChef : Chef        //letting the ItalianChef inherit all the functionality from the Chef
    {
        public override void MakeSpecialDish()  //the overwrite
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}
