using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using USQLCSLibrary;

namespace USQLCSLibrary
{
    public class Book
    {
        public string Articul { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Quantity { get; set; }
    }

    public class Reader
    {
        public string FullName { get; set; }
        public string GroupNumber { get; set; }
        public List<Book> Books { get; set; }

        public Reader()
        {
            Books = new List<Book>();
        }
    }
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Reader> Readers { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Readers = new List<Reader>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void AddReader()
        {

        }
    }
}








