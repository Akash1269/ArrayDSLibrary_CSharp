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
            using (StreamReader myReader = new StreamReader(filePath))
            {
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
            } 
            return l;
        }

        static public bool WriteLibraryDataToFile(string filePath, Library l)
        {
            Book book;
            using (StreamWriter myWriter = new StreamWriter(filePath))
            {
                if (myWriter == null)
                {
                    return false;
                }
                for (int i = 0; i < l.Length; i++)
                {
                    book = l.Books[i];
                    string record = book.ID.ToString() + "\t" + book.Name + '\t' + book.Author + '\t' + book.Price + '\t' + book.Copies;
                    myWriter.WriteLine(record);
                }
            }
            return true;
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
