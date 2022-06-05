using System.Collections.Generic;
using System.Linq;


namespace BookList.Model
{
    /// <summary>
    /// Класс реализует сортировку данных.
    /// </summary>
    public static class Sorting
    {
        /// <summary>
        /// Проводит сортировку коллекции рабочих по полному имени.
        /// </summary>
        /// <param name="books">Коллекция класса <see cref="Book"/></param>
        /// <returns>Возвращает отсортированную коллекцию рабочих.</returns>
        public static List<Book> SortedBooks(List<Book> books)
        {
            var orderedListBooks = from book in books
                orderby book.FullName
                select book;

            return orderedListBooks.ToList();
        }
    }
}