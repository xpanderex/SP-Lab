﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Table : Element
    {
        public string Title { get; set; }
        public Table(string title)
        {
            Title = title;
        }

        public void Add(Element element)
        {

        }

        public void Remove(Element element)
        {

        }
        public int Get(Element element)
        {
            return 0;
        }
        public void Print() => Console.WriteLine($"Table with Title: {Title}");
    }
}