﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;
using Contacts.Model.Services;

namespace Contacts.ViewModel
{
    /// <summary>
    ///  ViewModel для окна MainWindow.
    /// </summary>
    public class MainVM : ObservableObject
    {
        /// <summary>
        ///  Хранит булевое значение доступности кнопки добавления.
        /// </summary>
        private bool _isEnabledAddButton;

        /// <summary>
        ///  Хранит булевое значение доступности кнопки редактирования.
        /// </summary>
        private bool _isEnabledEditButton;

        /// <summary>
        ///  Хранит булевое значение доступности кнопки удаления.
        /// </summary>
        private bool _isEnabledRemoveButton;

        /// <summary>
        ///  Хранит булевое значение доступности редактирования текстовых полей.
        /// </summary>
        private bool _isReadOnlyTextBoxes;

        /// <summary>
        ///  Хранит булевое значение видимости кнопки принятия изменений.
        /// </summary>
        private bool _isVisibilityApplyButton;

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
            IsVisibilityApplyButton = false;
            SetEnabled(true, false, false);
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
        public ContactVM Buffer { get; set; }

        /// <summary>
        ///  Возвращает и задает текущий контакт.
        /// </summary>
        public ContactVM SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (Buffer != null && Contacts.IndexOf(SelectedContact) != -1)
                {
                    Contacts[Contacts.IndexOf(SelectedContact)] = Buffer;
                    Buffer = null;
                }

                _selectedContact = value;
                IsVisibilityApplyButton = false;
                IsReadOnlyTextBoxes = true;
                if (SelectedContact == null)
                    SetEnabled(true, false, false);
                else
                    SetEnabled(true, true, true);
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
            get => _isReadOnlyTextBoxes;
            set => SetProperty(ref _isReadOnlyTextBoxes, value);
        }

        /// <summary>
        ///  Возвращает и задаёт значение доступности кнопки добавления.
        /// </summary>
        public bool IsEnabledAddButton
        {
            get => _isEnabledAddButton;
            set => SetProperty(ref _isEnabledAddButton, value);
        }

        /// <summary>
        ///  Возвращает и задаёт значение доступности кнопки удаления.
        /// </summary>
        public bool IsEnabledRemoveButton
        {
            get => _isEnabledRemoveButton;
            set => SetProperty(ref _isEnabledRemoveButton, value);
        }

        /// <summary>
        ///  Возвращает и задаёт значение доступности кнопки редактирования.
        /// </summary>
        public bool IsEnabledEditButton
        {
            get => _isEnabledEditButton;
            set => SetProperty(ref _isEnabledEditButton, value);
        }

        /// <summary>
        ///  Возвращает и задаёт значение видимости кнопки принятия изменений.
        /// </summary>
        public bool IsVisibilityApplyButton
        {
            get => _isVisibilityApplyButton;
            set => SetProperty(ref _isVisibilityApplyButton, value);
        }

        /// <summary>
        ///  Вызывает редактирование нового экземпляра класса <see cref="ContactVM"/>.
        /// </summary>
        private void AddContact()
        {
            SelectedContact = null;
            SelectedContact = new ContactVM(new Contact());
            IsVisibilityApplyButton = true;
            IsReadOnlyTextBoxes = false;
            SetEnabled(false, false, false);
        }

        /// <summary>
        ///  Вызывает редактирования текущего контакта.
        /// </summary>
        private void EditContact()
        {
            Buffer = (ContactVM)SelectedContact.Clone();
            IsReadOnlyTextBoxes = false;
            IsVisibilityApplyButton = true;
            SetEnabled(false, false, false);
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
            IsVisibilityApplyButton = false;
            IsReadOnlyTextBoxes = true;
            Buffer = null;
            SetEnabled(true, true, true);
            ContactSerializer.Serialize(Contacts, Path);
        }

        /// <summary>
        ///  Устанавливает значения доступности кнопок.
        /// </summary>
        /// <param name="addButton">Кнопка добавления контакта.</param>
        /// <param name="removeButton">Кнопка удаления контакта.</param>
        /// <param name="editButton">Кнопка редактирования контакта.</param>
        private void SetEnabled(bool addButton, bool editButton, bool removeButton)
        {
            IsEnabledAddButton = addButton;
            IsEnabledRemoveButton = removeButton;
            IsEnabledEditButton = editButton;
        }
    }
}