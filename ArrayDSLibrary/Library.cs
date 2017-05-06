using System;

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

        bool IsFull()
        {
            return Length == 100;
        }

        bool IsEmpty()
        {
            return Length == 0;
        }
        public bool Insert(Book book)
        {
            if (IsFull() && Find(book.ID) != -1)
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

        void swap(ref Book a,ref Book b)
        {
            Book temp = a;
            a = b;
            b = temp;
        }

        int compareBooks(Book a, Book b)
        {
            return string.Compare(a.Name, b.Name);
        }

        public void sort()
        {
            int compare;
            bool sorted = false;
            for (int i = 0; i < Length && sorted == false; i++)
            {
                sorted = true;
                for (int j = 0; j < Length - 1; j++)
                {
                    compare = compareBooks(Books[j], Books[j + 1]);
                    if(compare > 0)
                    {
                        sorted = false;
                        swap(ref Books[j],ref Books[j + 1]);
                    }
                }
            }
        }

        public void PrintAllRecords()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(Books[i].ID + " - " + Books[i].Name + " - " + Books[i].Author + " - " + Books[i].Price + " - " + Books[i].Copies);
            }
        }
    }
}
