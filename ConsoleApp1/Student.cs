using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string name;    //a class attribute of our Student class
        public string major;   //another attribute
        public double gpa;       //another attribute
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()     //simple method to let us tell if a student is on the honor role--we must go into our Main solution and method to call this information and see which HasHonors--only has to be written one time to be used with each specific object--good because we can also change the method in this one place and it will automatically update the information everywhere
        { 
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
