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

        private string AppdataPath = Application.UserAppDataPath;
        
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

        private void ListBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex == -1) return;
            _currentBook = _books[ListBoxBook.SelectedIndex];
            FullNameTextBox.Text = _currentBook.FullName;
            AuthorTextBox.Text = _currentBook.Author;
            ReleaseDateTextBox.Text = _currentBook.ReleaseDate.ToString();
            CountOfPagesTextBox.Text = _currentBook.CountOfPages.ToString();
            GenreComboBox.Text = _currentBook.Genre.ToString();
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex != -1) return;
            try
            {
                AuthorTextBox.BackColor = AppColors._correctColor;
                _currentBook.Author = AuthorTextBox.Text;

                if (AuthorTextBox.Focused) UpdateBookInfo();
                Serializer.Serialize(AppdataPath,_books);
            }

            catch
            {
                AuthorTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex == -1) return;
            var genre = Enum.GetValues(typeof(Genre));
            _currentBook.Genre = (Genre)GenreComboBox.SelectedItem;
                

            UpdateBookInfo();
            Serializer.Serialize(AppdataPath,_books);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxBook.SelectedIndex;
            
            if(index == -1) return;
            
            _books.RemoveAt(index);

            UpdateBookList(_books);
            Serializer.Serialize(AppdataPath, _books);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var book = new Book();
            book.FullName = $"New book {book.Id}";
            book.Author = "Author";
            book.CountOfPages = 10;
            book.Genre = Genre.Fantasy;
            book.ReleaseDate = DateTime.Today.Year;
            _books.Add(book);
            Serializer.Serialize(AppdataPath, _books);
            UpdateBookList(_books);
        }

        private void ReleaseDateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex == -1) return;
            try
            {
                ReleaseDateTextBox.BackColor = AppColors._correctColor;
                int releaseDateValue = int.Parse(ReleaseDateTextBox.Text);
                _currentBook.ReleaseDate = releaseDateValue;
                    
                Serializer.Serialize(AppdataPath,_books);
            }

            catch
            {
                ReleaseDateTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void NumberOfPagesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex == -1) return;
            try
            {
                CountOfPagesTextBox.BackColor = AppColors._correctColor;
                int countOfPagesValue = int.Parse(CountOfPagesTextBox.Text);
                _currentBook.CountOfPages = countOfPagesValue;
                    
                Serializer.Serialize(AppdataPath,_books);
            }

            catch
            {
                CountOfPagesTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex == -1) return;
            try
            {
                FullNameTextBox.BackColor = AppColors._correctColor;
                _currentBook.FullName = FullNameTextBox.Text;

                UpdateBookInfo();
                Serializer.Serialize(AppdataPath,_books);
            }

            catch
            {
                FullNameTextBox.BackColor = AppColors._errorColor;
            }
        }
    }
}