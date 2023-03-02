using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB
{
    public class Book
    {
        public uint Id;

        public string Author;

        public string Title;

        public uint PublicationYear;

        public ushort CabinetNumber;

        public byte ShelfNumber;
    }

    struct BookData
    {
        public BookData()
        {

        }

        static StreamReader data = new StreamReader(@"Books.csv");

        public static string[] header = data.ReadLine().Split(';');

        public static string[] book1 = data.ReadLine().Split(';');

        public static string[] book2 = data.ReadLine().Split(';');

        public static string[] book3 = data.ReadLine().Split(';');

        public static void CheckTheСorrectness()
        {
            if (book1.Length > header.Length || book2.Length > header.Length || book3.Length > header.Length)
            {
                Console.WriteLine("Данных больше, чем столбцов в таблице Books!");

                Environment.Exit(0);
            }

            if (Int32.TryParse(book1[0], out int v1) == false)
            {
                Console.WriteLine($"Тип данных {book1[0]} не совпал с типом 1 столбца таблицы Books!");

                Environment.Exit(0);
            }

            for (int i = 3; i < book1.Length; i++)
            {
                if (Int32.TryParse(book1[i], out int elem) == false)
                {
                    Console.WriteLine($"Тип данных {book1[i]} не совпал с типом {i+1}-го столбца таблицы Books!");

                    Environment.Exit(0);
                }
            }

            if (Int32.TryParse(book2[0], out int v2) == false)
            {
                Console.WriteLine($"Тип данных {book2[0]} не совпал с типом 1-го столбца таблицы Books!");

                Environment.Exit(0);
            }

            for (int i = 3; i < book2.Length; i++)
            {
                if (Int32.TryParse(book2[i], out int elem) == false)
                {
                    Console.WriteLine($"Тип данных {book2[i]} не совпал с типом {i+1}-го столбца таблицы Books!");

                    Environment.Exit(0);
                }
            }

            if (Int32.TryParse(book3[0], out int v3) == false)
            {
                Console.WriteLine($"Тип данных {book3[0]} не совпал с типом 1-го столбца таблицы Books!");

                Environment.Exit(0);
            }

            for (int i = 3; i < book3.Length; i++)
            {
                if (Int32.TryParse(book3[i], out int elem) == false)
                {
                    Console.WriteLine($"Тип данных {book3[i]} не совпал с типом {i+1}-го столбца таблицы Books!");

                    Environment.Exit(0);
                }
            }
        }
    }
}
