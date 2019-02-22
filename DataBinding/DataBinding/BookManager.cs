using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Book
    {
        public string  NameofAuther { get; set; }
        public string CoverImage { get; set; }
        public string Title { get; set; }

    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            List<Book> books=new List<Book>();
            books.Add(new Book(){NameofAuther = "Humphry",
                Title = "The River and The Source",CoverImage = "Assets/IMG_20180916_100647.jpg" });
            books.Add(new Book()
            {
                NameofAuther = "Celestine",
                Title = "Betrayal in the City",
                CoverImage = "Assets/IMG_20181214_203417.jpg"
            });
            books.Add(new Book() { NameofAuther = "Cleophas",
                Title = "When The Sun Goes Down",CoverImage = "Assets/IMG_20180926_153910.jpg" });
            books.Add(new Book() { NameofAuther = "Frankline",
                Title = "Caucasian Chalk Circle",CoverImage = "Assets/IMG_20180926_153928.jpg" });
           
            return books;
        }
    }
}
