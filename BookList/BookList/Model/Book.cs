using System;
using System.Xml.Serialization.Configuration;

namespace BookList.Model
{
    public class Book
    {
        private string _fullName;

        private DateTime _releaseDate;

        public string _author;

        public static int _allNumberOfPages;
        
        private readonly int _id;

        public Book()
        {
            _allNumberOfPages++;
            _id = _allNumberOfPages;
        }

        public Book(string fullName,
                    DateTime releaseDate,
                    string number,
                    string author)
        {
            FullName = fullName;
            ReleaseDate = releaseDate;
            Author = author;
            Number = number;
            _allNumberOfPages++;
            _id = _allNumberOfPages;
        }

        public Book(Book other)
        {
            _id = other._id;
            FullName = other._fullName;
            ReleaseDate = other._releaseDate;
            Author = other._author;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public static int AllNumberOfPages
        {
            get
            {
                return _allNumberOfPages;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public string FullName
        {
            get
            {
                return _fullName;
            }

            set
            {
                Validator.AssertCountSymbolsInRange(value, 0, 100, nameof(FullName));
                _fullName = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return _releaseDate;
            }

            set
            {
                _releaseDate = value;
            }
        }
        
        public string Number { get; set; }
    }
}