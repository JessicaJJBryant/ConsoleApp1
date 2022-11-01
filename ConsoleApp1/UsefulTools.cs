using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class UsefulTools    //if we don't want an object/instance assigned to this, we would make it a static class (like Math) and then we would not be able to create an object in the main class (Program.cs)---this will depend on the circumstances
    {
        public static void SayHi(string name)   //creating a static method for the entire class---the return type is void--
        {
            Console.WriteLine("Hello, " + name);
        }
    }
}
