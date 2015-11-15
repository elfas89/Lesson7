using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Library
    {
        Book[] books;
        public Library(int length)
        {
            books = new Book[length];
        }
        public int Length
        {
            get { return books.Length; }
        }
        public Book this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
    }

    class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }
    }


}
