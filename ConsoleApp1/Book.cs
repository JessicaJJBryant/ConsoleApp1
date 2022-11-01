using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        public string title;    //a class attribute of our book class
        public string author;   //another attribute
        public int pages;       //another attribute
        //by listing the different attributes of our class book, we create a blueprint for the book datatype
        public Book(string aTitle, string aAuthor, int aPages) //the a stands for argument to show that this is the argument that is passed in
        {
           title = aTitle;      //setting the variable title equal to aTitle
            author = aAuthor;   
            pages = aPages; 
        }
    }
}
