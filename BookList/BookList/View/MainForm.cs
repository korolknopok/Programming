using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookList.Model;
using BookList.Properties;

namespace BookList.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению главного окна.
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// Выбранная книга.
        /// </summary>
        private Book _currentBook;

        /// <summary>
        /// Коллекция книг.
        /// </summary>
        private List<Book> _books;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _books = Serializer.Deserialize();

            var genre = Enum.GetValues(typeof(Genre));

            foreach (var value in genre)
            {
                GenreComboBox.Items.Add(value);
            }

            UpdateListBox(-1);

        }

        /// <summary>
        /// Очищает поля для вывода информации.
        /// </summary>
        private void ClearBookInfo()
        {
            FullNameTextBox.Clear();
            ReleaseDateTextBox.Clear();
            AuthorTextBox.Clear();
            CountOfPagesTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
        }
        /// <summary>
        /// Обновляет данные в списке ListBox.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateListBox(int selectedIndex)
        {
            BookListBox.Items.Clear();
            _books = Sorting.SortedBooks(_books);
            foreach (Book book in _books)
            {
                BookListBox.Items.Add($"{book.FullName} / {book.Author} / {book.Genre}");
            }

            BookListBox.SelectedIndex = selectedIndex;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = BookListBox.SelectedIndex;
            
            if(index == -1) return;
            
            _books.RemoveAt(index);

            UpdateListBox(-1);
            ClearBookInfo();
            Serializer.Serialize(_books);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentBook = new Book();
            _currentBook.FullName = $"New book {_currentBook.Id}";
            _currentBook.Author = "Author";
            _currentBook.CountOfPages = 10;
            _currentBook.Genre = Genre.Fantasy;
            _currentBook.ReleaseDate = DateTime.Today.Year;
            _books.Add(_currentBook);
            int index = _books.IndexOf(_currentBook);
            Sorting.SortedBooks(_books);
            UpdateListBox(index);
        }

        private void ReleaseDateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedIndex == -1) return;
            try
            {
                ReleaseDateTextBox.BackColor = AppColors._correctColor;
                int releaseDateValue = int.Parse(ReleaseDateTextBox.Text);
                _currentBook.ReleaseDate = releaseDateValue;

                UpdateListBox(BookListBox.SelectedIndex);

                Serializer.Serialize(_books);
            }

            catch
            {
                ReleaseDateTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void NumberOfPagesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedIndex == -1) return;
            try
            {
                CountOfPagesTextBox.BackColor = AppColors._correctColor;
                int countOfPagesValue = int.Parse(CountOfPagesTextBox.Text);
                _currentBook.CountOfPages = countOfPagesValue;

                UpdateListBox(BookListBox.SelectedIndex);

                Serializer.Serialize(_books);
            }

            catch
            {
                CountOfPagesTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedIndex == -1) return;

            try
            {
                FullNameTextBox.BackColor = AppColors._correctColor;
                _currentBook.FullName = FullNameTextBox.Text;
                int index = _books.IndexOf(_currentBook);
                UpdateListBox(index);

                Serializer.Serialize(_books);
            }

            catch
            {
                FullNameTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedIndex == -1) return;

            try
            {
                AuthorTextBox.BackColor = AppColors._correctColor;
                _currentBook.Author = AuthorTextBox.Text;

                UpdateListBox(BookListBox.SelectedIndex);

                Serializer.Serialize(_books);
            }
            catch
            {
                AuthorTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedIndex == -1) return;

            var genre = Enum.GetValues(typeof(Genre));
            _currentBook.Genre = (Genre)GenreComboBox.SelectedItem;
            int index = _books.IndexOf(_currentBook);
            UpdateListBox(index);

            Serializer.Serialize(_books);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = Resources.add_24x24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Resources.add_24x24_uncolor;
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = Resources.remove_24x24;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = Resources.remove_24x24_uncolor;
        }

        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = BookListBox.SelectedIndex;

            if (index == -1) return;

            _currentBook = _books[index];
            FullNameTextBox.Text = _currentBook.FullName;
            AuthorTextBox.Text = _currentBook.Author;
            ReleaseDateTextBox.Text = _currentBook.ReleaseDate.ToString();
            CountOfPagesTextBox.Text = _currentBook.CountOfPages.ToString();
            GenreComboBox.Text = _currentBook.Genre.ToString();
        }
    }
}