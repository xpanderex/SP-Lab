﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Paragraph : Element
    {
        public string Text { get; set; }
        public Paragraph(string text)
        {
            Text = text;
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
        public void Print() => Console.WriteLine($"Paragraph: {Text}");
    }
}