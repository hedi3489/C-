﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsReserved { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsReserved = false;
        }
    }
}