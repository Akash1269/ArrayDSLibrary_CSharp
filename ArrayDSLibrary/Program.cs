using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayDSLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tWelcome to Library Management System\n\n");
            //Console.WriteLine("Enter Number of Records To Be inserted");
            //Console.WriteLine("Enter Book Name");
            //string bookName = Console.ReadLine();
            //Console.ReadLine();



            string line;

            Library library = new Library();

            StreamReader myReader = new StreamReader(@"c:\users\hp\documents\visual studio 2015\Projects\ArrayDSLibrary\ArrayDSLibrary\Data\library.txt");
            while ((line = myReader.ReadLine()) != null)
            {
                string[] record = line.Split('\t');
                Book book = new Book();
                book.ID = int.Parse(record[0]);
                book.Name = record[1];
                book.Author = record[2];
                book.Price = int.Parse(record[3]);
                book.Copies = int.Parse(record[4]);
                library.Insert(book);
            }
            library.PrintAllRecords();

            Console.Read();

        }
        
    }
}
