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

namespace BookList
{
    public partial class Form1 : Form
    {

        private Book _currentBook;

        private List<Book> _books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            
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
                ListBoxBook.Items.Add(_books[i].FullName);
            }
        }
        
        private void UpdateBookInfo()
        {
            var selectedIndex = ListBoxBook.SelectedIndex;
            var book = new Book(_currentBook);
            _books[selectedIndex] = book;
            UpdateBookList(_books);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var book = new Book();
            book.FullName = $"Новая книга {book.Id}";
            book.ReleaseDate = DateTime.Today;
            _books.Add(book);
            UpdateBookList(_books);
        }

        private void ListBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBook.SelectedIndex != -1)
            {
                _currentBook = _books[ListBoxBook.SelectedIndex];
                NameTextBox.Text = _currentBook.FullName;
                
            }
        }
    }
}