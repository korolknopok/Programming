using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookList.Model;

namespace BookList.View
{
    public partial class MainForm : Form
    {

        private Book _currentBook;

        private List<Book> _books = new List<Book>();
        public MainForm()
        {
            InitializeComponent();

            var genre = Enum.GetValues(typeof(Genre));

            foreach (var value in genre)
            {
                GenreComboBox.Items.Add(value);
            }

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex != -1)
            {
                try
                {
                    NameTextBox.BackColor = AppColors._correctColor;
                    _currentBook.FullName = NameTextBox.Text;

                    if (NameTextBox.Focused) UpdateBookInfo();
                }

                catch
                {
                    NameTextBox.BackColor = AppColors._errorColor;
                }
            }
        }

        private void UpdateBookList(List<Book> books)
        {
            ListBoxBook.Items.Clear();
            var orderedListBooks = from book in _books
                orderby book.FullName
                select book;
            _books = orderedListBooks.ToList();
            for (int i = 0; i < _books.Count; i++)
            {
                ListBoxBook.Items.Add($"{_books[i].FullName}/{_books[i].Author}/{_books[i].Genre}");
            }
        }
        
        private void UpdateBookInfo()
        {
            var selectedIndex = ListBoxBook.SelectedIndex;
            var book = new Book(_currentBook);
            _books[selectedIndex] = book;
            UpdateBookList(_books);

            var indexOf = _books.IndexOf(book);

            ListBoxBook.SelectedIndex = indexOf;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var book = new Book();
            book.FullName = $"New book {book.Id}";
            book.Author = "Author";
            book.CountOfPages = 10;
            book.Genre = Genre.Fantasy;
            book.ReleaseDate = DateTime.Today.Year;
            _books.Add(book);
            UpdateBookList(_books);
            
        }

        private void ListBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex != -1)
            {
                _currentBook = _books[ListBoxBook.SelectedIndex];
                NameTextBox.Text = _currentBook.FullName;
                AuthorTextBox.Text = _currentBook.Author;
                ReleaseDateTextBox.Text = _currentBook.ReleaseDate.ToString();
                NumberOfPagesTextBox.Text = _currentBook.CountOfPages.ToString();
                GenreComboBox.Text = _currentBook.Genre.ToString();
            }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex != -1)
            {
                try
                {
                    AuthorTextBox.BackColor = AppColors._correctColor;
                    _currentBook.Author = AuthorTextBox.Text;

                    if (AuthorTextBox.Focused) UpdateBookInfo();
                }

                catch
                {
                    AuthorTextBox.BackColor = AppColors._errorColor;
                }
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex != -1)
            {
                var genre = Enum.GetValues(typeof(Genre));
                _currentBook.Genre = (Genre)GenreComboBox.SelectedItem;

                UpdateBookInfo();
            }
        }
    }
}