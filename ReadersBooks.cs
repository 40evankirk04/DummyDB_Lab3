using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DummyDB
{
    struct ReadersBooksData
    {
        public ReadersBooksData()
        {

        }

        static StreamReader data = new StreamReader(@"ReadersBooks.csv");

        public static string[] header = data.ReadLine().Split(';');

        public static string[] readerBook1 = data.ReadLine().Split(';');

        public static string[] readerBook2 = data.ReadLine().Split(';');

        public static void CheckTheСorrectness()
        {
            if (readerBook1.Length > header.Length || readerBook2.Length > header.Length)
            {
                Console.WriteLine("Данных больше, чем столбцов в таблице ReadersBooks!");

                Environment.Exit(0);
            }

            for (int i = 0; i <= 1; i++)
            {
                if (Int32.TryParse(readerBook1[i], out int elem) == false)
                {
                    Console.WriteLine($"Тип данных {readerBook1[i]} не совпал с типом {i + 1}-го столбца таблицы ReadersBooks!");

                    Environment.Exit(0);
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                if (Int32.TryParse(readerBook2[i], out int elem) == false)
                {
                    Console.WriteLine($"Тип данных {readerBook2[i]} не совпал с типом {i + 1}-го столбца таблицы ReadersBooks!");

                    Environment.Exit(0);
                }
            }

            for (int i = 2; i < readerBook1.Length; i++)
            {
                if (DateTime.TryParse(readerBook1[i], out DateTime date) == false)
                {
                    Console.WriteLine($"Тип данных {readerBook1[i]} не совпал с типом {i + 1}-го столбца таблицы ReadersBooks!");

                    Environment.Exit(0);
                }
            }

            for (int i = 2; i < readerBook2.Length; i++)
            {
                if (DateTime.TryParse(readerBook2[i], out DateTime date) == false)
                {
                    Console.WriteLine($"Тип данных {readerBook2[i]} не совпал с типом {i + 1}-го столбца таблицы ReadersBooks!");

                    Environment.Exit(0);
                }
            }
        }
    }
}
