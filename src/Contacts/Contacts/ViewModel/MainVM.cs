using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;
using Contacts.Model.Services;
using Contacts.ViewModel;

namespace View.ViewModel
{
    /// <summary>
    ///  ViewModel для окна MainWindow.
    /// </summary>
    public class MainVM : ObservableObject
    {
        

        /// <summary>
        ///  Хранит булевое значение доступности кнопки редактирования.
        /// </summary>
        private bool _isEnabledEdit;

        /// <summary>
        ///  Хранит булевое значение доступности редактирования текстовых полей.
        /// </summary>
        private bool _isReadOnly;

        /// <summary>
        ///  Текущий контакт.
        /// </summary>
        private ContactVM _selectedContact;

        /// <summary>
        ///  Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.Deserialize(Path);
            EditCommand = new RelayCommand(EditContact);
            AddCommand = new RelayCommand(AddContact);
            RemoveCommand = new RelayCommand(RemoveContact);
            ApplyCommand = new RelayCommand(ApplyChangesContact);
            IsReadOnlyTextBoxes = true;
            IsEnabledEditButton = false;
        }

        /// <summary>
        ///  Возвращает и задаёт путь сериализации. По умолчанию - папка "Мои документы".
        /// </summary>
        public string Path { get; set; } =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        ///  Возвращает и задаёт коллекцию контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        ///  Возвращает и задает исходную версию редактируемого контакта.
        /// </summary>
        public ContactVM ContactClone { get; set; }

        /// <summary>
        ///  Возвращает и задает текущий контакт.
        /// </summary>
        public ContactVM SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (ContactClone != null && Contacts.IndexOf(SelectedContact) != -1)
                {
                    Contacts[Contacts.IndexOf(SelectedContact)] = ContactClone;
                    ContactClone = null;
                }

                _selectedContact = value;
                IsReadOnlyTextBoxes = true;
                if (SelectedContact == null)
                    IsReadOnlyTextBoxes = true;
                else
                    IsEnabledEditButton = true;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///  Возвращает команду добавления контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        ///  Возвращает команду принятия изменений.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        ///  Возвращает команду редактирования контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        ///  Возвращает команду удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        ///  Возвращает и задаёт значение доступности редактирования текстовых полей.
        /// </summary>
        public bool IsReadOnlyTextBoxes
        {
            get => _isReadOnly;
            set => SetProperty(ref _isReadOnly, value);
        }

        /// <summary>
        ///  Возвращает и задаёт значение доступности кнопки редактирования.
        /// </summary>
        public bool IsEnabledEditButton
        {
            get => _isEnabledEdit;
            set => SetProperty(ref _isEnabledEdit, value);
        }

        /// <summary>
        ///  Вызывает редактирование нового экземпляра класса <see cref="ContactVM"/>.
        /// </summary>
        private void AddContact()
        {
            SelectedContact = null;
            SelectedContact = new ContactVM(new Contact());
            IsReadOnlyTextBoxes = false;
            IsEnabledEditButton = false;

        }

        /// <summary>
        ///  Вызывает редактирования текущего контакта.
        /// </summary>
        private void EditContact()
        {
            ContactClone = (ContactVM)SelectedContact.Clone();
            IsReadOnlyTextBoxes = false;
            IsEnabledEditButton = false;
        }

        /// <summary>
        ///  Удаляет текущий контакт.
        /// </summary>
        private void RemoveContact()
        {
            if (SelectedContact == null) return;
            var index = Contacts.IndexOf(SelectedContact);
            Contacts.RemoveAt(index);
            if (Contacts.Count == 0)
                SelectedContact = null;
            else if (index == Contacts.Count)
                SelectedContact = Contacts[index - 1];
            else
                SelectedContact = Contacts[index];
            ContactSerializer.Serialize(Contacts, Path);
        }

        /// <summary>
        ///  Принимает изменения редактирования контакта.
        /// </summary>
        private void ApplyChangesContact()
        {
            if (!Contacts.Contains(SelectedContact)) Contacts.Add(SelectedContact);
            IsReadOnlyTextBoxes = true;
            ContactClone = null;
            IsEnabledEditButton = true;
            IsReadOnlyTextBoxes = true;
            ContactSerializer.Serialize(Contacts, Path);
        }
    }
}