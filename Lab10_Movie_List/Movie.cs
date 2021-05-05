using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_Movie_List
{
    class Movie
    {
               //fields
        private string category;
        private string title;

        //properties
    public string Category { get; set; }
       
    public string Title { get; set; }
        
        //constructors
        public Movie()
        {

        }

    public Movie(string _category, string _title)
        {
            category = _category;
            title = _title;
                        
        }
    
        public void PrintInfo()
        {
            Console.WriteLine("Category: " + category);
           // Console.WriteLine("Title: " + title);
        }
    }
}
