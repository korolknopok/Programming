using System;
using System.Xml.Serialization.Configuration;

namespace BookList.Model
{
    public class Book
    {
        private string _fullName;

        private int _releaseDate;

        public string _author;

        public  int _countOfPages;

        public static int _allBooks;
        
        private readonly int _id;

        private Genre _genre;

        public Book()
        {
            _allBooks++;
            _id = _allBooks;
        }

        public Book(string fullName,
                    int releaseDate,
                    int countOfPages,
                    string author)
        {
            FullName = fullName;
            ReleaseDate = releaseDate;
            Author = author;
            CountOfPages = countOfPages;
            _allBooks++;
            _id = _allBooks;
        }

        public Book(Book other)
        {
            Genre = other.Genre;
            _id = other._id;
            FullName = other._fullName;
            ReleaseDate = other._releaseDate;
            Author = other._author;
            CountOfPages = other._countOfPages;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public int CountOfPages
        {
            get
            {
                return _countOfPages;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(CountOfPages));
                _countOfPages = value;
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

        public int ReleaseDate
        {
            get
            {
                return _releaseDate;
            }

            set
            {
                Validator.AssertReleaseYear(value, 1700, DateTime.Today.Year, nameof(ReleaseDate));
                _releaseDate = value;
            }
        }
        
        public Genre Genre { get; set; }
    }
}