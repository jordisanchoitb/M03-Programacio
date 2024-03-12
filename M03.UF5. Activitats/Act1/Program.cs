/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 

 */
using System;
using System.Collections.Generic;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book(1, "The Hobbit", 300));
            books.Add(new Book(2, "The Lord of the Rings", 1000));
            books.Add(new Book(3, "The Silmarillion", 500));
            books.Add(new Book(4, "The Children of Húrin", 400));
            books.Add(new Book(5, "The Fall of Gondolin", 350));
            Console.WriteLine("Before sorting:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("*************************************************************");
            books.Sort();
            Console.WriteLine("After sorting Asc:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("*************************************************************");
            books.Sort(new BookComparer());
            Console.WriteLine("After sorting Desc:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

        }
    }
}
