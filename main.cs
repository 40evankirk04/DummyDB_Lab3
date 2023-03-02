using System.Data;
using System.Globalization;

namespace DummyDB
{
    class Program
    {
        void Initialize()
        {
            BookData.CheckTheСorrectness();

            ReaderData.CheckTheСorrectness();

            ReadersBooksData.CheckTheСorrectness();

            List<Reader> readers = new List<Reader>
            {
                new Reader
                {
                    Id = Convert.ToUInt32(ReaderData.reader1[0]),

                    FIO = ReaderData.reader1[1],

                    TicketNumber = Convert.ToUInt32(ReaderData.reader1[2]),

                    CaptureDate = new Dictionary<uint, DateTime>
                    {
                        { Convert.ToUInt32(ReadersBooksData.readerBook1[1]), Convert.ToDateTime(ReadersBooksData.readerBook1[2])}
                    },

                    ReturnDate = new Dictionary<uint, DateTime>
                    {
                        { Convert.ToUInt32(ReadersBooksData.readerBook1[1]), Convert.ToDateTime(ReadersBooksData.readerBook1[3])}
                    }
                },

                new Reader
                {
                    Id = Convert.ToUInt32(ReaderData.reader2[0]),

                    FIO = ReaderData.reader2[1],

                    TicketNumber = Convert.ToUInt32(ReaderData.reader2[2]),

                    CaptureDate = new Dictionary<uint, DateTime>
                    {
                        { Convert.ToUInt32(ReadersBooksData.readerBook2[1]), Convert.ToDateTime(ReadersBooksData.readerBook2[2])}
                    },

                    ReturnDate = new Dictionary<uint, DateTime>
                    {
                    
                    }
                }
            };

            List<Book> books = new List<Book>
            {
                new Book 
                {
                    Id = Convert.ToUInt32(BookData.book1[0]),

                    Author = BookData.book1[1],

                    Title = BookData.book1[2],

                    PublicationYear = Convert.ToUInt32(BookData.book1[3]),

                    CabinetNumber = Convert.ToUInt16(BookData.book1[4]),

                    ShelfNumber = Convert.ToByte((BookData.book1[5]))
                },

                new Book
                {
                    Id = Convert.ToUInt32(BookData.book2[0]),

                    Author = BookData.book2[1],

                    Title = BookData.book2[2],

                    PublicationYear = Convert.ToUInt32(BookData.book2[3]),

                    CabinetNumber = Convert.ToUInt16(BookData.book2[4]),

                    ShelfNumber = Convert.ToByte((BookData.book2[5]))
                },

                new Book
                {
                    Id = Convert.ToUInt32(BookData.book3[0]),

                    Author = BookData.book3[1],

                    Title = BookData.book3[2],

                    PublicationYear = Convert.ToUInt32(BookData.book3[3]),

                    CabinetNumber = Convert.ToUInt16(BookData.book3[4]),

                    ShelfNumber = Convert.ToByte((BookData.book3[5]))
                },

            };

            bool check = false;

            foreach (var book in books)
            {
                foreach (var reader in readers)
                { 
                    if (reader.CaptureDate.ContainsKey(book.Id) && reader.ReturnDate.ContainsKey(book.Id) == false)
                    {
                        Console.WriteLine($"{book.Title}: {reader.FIO}, {reader.CaptureDate[book.Id].ToString("d")}");

                        check = true;
                    }
                }

                if (check == true) check = false;

                else Console.WriteLine(book.Title); 
            }
        }

        public static void Main(string[] args)
        {
            Program dataBase = new Program();

            dataBase.Initialize();
        }
    }
}
