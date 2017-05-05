using System;
using System.IO;

namespace ArrayDSLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\tWelcome to Library Management System");

            const string FILE_PATH = @"c:\users\hp\documents\visual studio 2015\Projects\ArrayDSLibrary\ArrayDSLibrary\Data\library.txt";
            Library l = LibraryIO.ReadLibraryDataFromFile(FILE_PATH);
            bool flag;
            int choice = -1, index;
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        flag = l.Insert(LibraryIO.ReadBookRecordFromConsole());
                        if (flag)
                            Console.WriteLine("Succefully inserted the record in the library");
                        else
                            Console.WriteLine("Error: Library is Already Full or record is already present for the given ID");
                        break;
                    case 2:
                        flag = l.Update(LibraryIO.ReadBookRecordFromConsole());
                        if (flag)
                            Console.WriteLine("Succefully Updated the record in the library");
                        else
                            Console.WriteLine("Error: Record Not Found");
                        break;
                    case 3:
                        Console.WriteLine("Please enter the ID of the record to be deleted");
                        flag = l.Delete(int.Parse(Console.ReadLine()));
                        if (flag)
                            Console.WriteLine("Succefully deleted the record in the library");
                        else
                            Console.WriteLine("Error: Record not found");
                        break;
                    case 4:
                        Console.WriteLine("Please enter the ID of the record to be deleted");
                        index = l.Find(int.Parse(Console.ReadLine()));
                        if (index != -1)
                            Console.WriteLine("Succefully inserted the record in the library");
                        else
                            Console.WriteLine("Error: Item not found");
                        break;
                    case 5:
                        l.PrintAllRecords();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n\n*******MENU*******\n\n");

                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Search");
                Console.WriteLine("5.Print All Records");
                Console.WriteLine("6.Size");

                Console.Write("\nPlease Enter The choice from the Menu : ");
                choice = int.Parse(Console.ReadLine());
            }
        }
    }
}
