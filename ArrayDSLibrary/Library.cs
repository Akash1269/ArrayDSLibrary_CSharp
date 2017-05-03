using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDSLibrary
{
    class Library
    {
        const int MAX_SIZE = 100;

        public Book[] Books { get; set; }
        public int Length { get; set; }

        public Library()
        {
            Books = new Book[MAX_SIZE];
            Length = 0;
        }

        public bool IsFull()
        {
            return Length == 100;
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }
        public bool Insert(Book book)
        {
            if (IsFull())
                return false;

            Books[Length] = book;
            Length ++;
            return true;
        }

        public int Find(int ID)
        {
            for (int i = 0; i < Length; i++)
            {
                if (Books[i].ID == ID)
                    return i;
            }
            return -1;
        }

        public bool Delete(int ID) {

            int found = Find(ID);
            if (IsEmpty() || found == -1)
                return false;

            for (int i = found; i < Length; i++)
            {
                Books[i] = Books[i + 1];
            }
            Length--;
            return true;
        }

        public bool Update(Book book)
        {
            int index = Find(book.ID);
            if (IsEmpty() || index == -1)
                return false;
            Books[index] = book;
            return true;
        }

        public void PrintAllRecords()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("\t\t\t" + Books[i].Name + " - " + Books[i].Author + " - " + Books[i].Price + " - " + Books[i].Copies);
            }
        }
    }
}
