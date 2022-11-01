using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Movie
    {
        public string title;    //public means it's open to everyone
        public string director;   
        private string rating; //only code within this movie class will be able to access the rating inside this movie class      
        //the constructor:
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;   //setting the Rating through the GETTER and SETTER below (note the capital letter)
        }
        public string Rating 
        { 
            get { return rating; }  //allows us to get the rating
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value; 
                }
                else
                {
                    rating = "NR";
                }
            
            } //allows us to set the rating based on the rules assigned within the setter
        }
    }
}
