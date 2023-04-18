using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для окна MainWindow.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Контакт.
        /// </summary>
        public Contact Contact { get; set; } = new Contact();

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name  
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public long PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// При вызове зажигает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="prop">Имя свойства, вызвавшего метод.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Сохраняет данные.
        /// </summary>
        public void Save()
        {
            ContactSerializer.Serialize(Contact);
        }

        /// <summary>
        /// Загружает данные.
        /// </summary>
        public void Load()
        {
            Contact contact = ContactSerializer.Deserialize();
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
        }

        /// <summary>
        /// Команда сериализации контакта.
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                return new SaveCommand(this);
            }
        }

        /// <summary>
        /// Команда десериализации контакта.
        /// </summary>
        public ICommand LoadCommand
        {
            get
            {
                return new LoadCommand(this);
            }
        }
    }
}