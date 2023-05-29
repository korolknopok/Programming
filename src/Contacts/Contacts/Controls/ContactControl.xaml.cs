using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Contacts.ViewModel;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Регистрирует свойство зависимости для SelectedContact.
        /// </summary>
        public static readonly DependencyProperty SelectedContactProperty =
            DependencyProperty.Register("SelectedContact", typeof(ContactVM),
                typeof(ContactControl), new UIPropertyMetadata(null));

        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задаёт выбранный контакт.
        /// </summary>
        public ContactVM SelectedContact
        {
            get => (ContactVM)GetValue(SelectedContactProperty);
            set => SetValue(SelectedContactProperty, value);
        }

    }
}
