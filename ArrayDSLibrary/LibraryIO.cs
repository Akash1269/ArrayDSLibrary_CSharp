using System;
using System.IO;

namespace ArrayDSLibrary
{
    class LibraryIO
    {
        static public Library ReadLibraryDataFromFile(string filePath)
        {
            string line;
            Library l = new Library();
            StreamReader myReader = new StreamReader(filePath);
            while ((line = myReader.ReadLine()) != null)
            {
                string[] record = line.Split('\t');
                Book book = new Book();
                book.ID = int.Parse(record[0]);
                book.Name = record[1];
                book.Author = record[2];
                book.Price = int.Parse(record[3]);
                book.Copies = int.Parse(record[4]);
                l.Insert(book);
            }
            return l;
        }
        static public Book ReadBookRecordFromConsole()
        {
            Book book = new Book();
            Console.WriteLine("Enter The Details Below in tab Seperated Format");

            string[] record = Console.ReadLine().Split('\t');

            book.ID = int.Parse(record[0]);
            book.Name = record[1];
            book.Author = record[2];
            book.Price = int.Parse(record[3]);
            book.Copies = int.Parse(record[4]);

            return book;
        }
    }
}
