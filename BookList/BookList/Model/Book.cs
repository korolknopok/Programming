using System;


namespace BookList.Model
{
    
    /// <summary>
    /// Хранятся данные о книге.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Название книги.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Дата выпуска.
        /// </summary>
        private int _releaseDate;

        /// <summary>
        /// Автор.
        /// </summary>
        private string _author;

        /// <summary>
        /// Количество страниц.
        /// </summary>
        private int _countOfPages;

        /// <summary>
        /// Количество книг.
        /// </summary>
        private static int _allBooks;
        
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Book"/>.
        /// </summary>
        public Book()
        {
            _allBooks++;
            _id = _allBooks;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Book"/>.
        /// </summary>
        /// <param name="fullName">Полное название. Должно состоять из не менее чем 100 символов.</param>
        /// <param name="releaseDate">Дата выпуска. Не может быть раньше 1700.1.1 и не позже текущего дня.</param>
        /// <param name="countOfPages">Количество страниц. Количество страниц должно быть положительным</param>
        /// <param name="author">Автор.</param>
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

        /// <summary>
        /// Создает копию экземпляра класса <see cref="Book"/>.
        /// </summary>
        public Book(Book other)
        {
            Genre = other.Genre;
            FullName = other.FullName;
            ReleaseDate = other.ReleaseDate;
            Author = other.Author;
            CountOfPages = other.CountOfPages;
        }

        /// <summary>
        /// Возвращает идентификатор .
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает количество страниц, количество строго положительное.
        /// </summary>
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
        /// <summary>
        /// Возвращает имя автора.
        /// </summary>
        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                Validator.AssertOnPositiveValue(value.Length, nameof(Author));
                _author = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название книги. Должно состоять из менее чем 100 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }

            set
            {
                Validator.AssertCountSymbolsInRange(value, 1, 100, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает дату выпуска.
        /// </summary>
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
        
        /// <summary>
        /// Возвращает жанры.
        /// </summary>
        public Genre Genre { get; set; }
    }
}