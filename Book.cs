using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LMS_Task
{
    class Book
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string AuthorName { set; get; }
        public bool IsAvailable { set; get; }
        public Book(int id, string title, string authorName)
        {
            ID = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = true;
        }

        public void DisplayInfo()
        {
            string keyword = IsAvailable ? "Available" : "Not Available";
            Console.WriteLine($"ID: {ID}, Title: {Title}, Author: {AuthorName}.  {keyword}!");
        }
    }
}
