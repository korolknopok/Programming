using System;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using Contacts.Model;

namespace ViewModel
{
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        ///  Создаёт экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        ///  Возвращает и задаёт контакт.
        /// </summary>
        public Contact Contact { get; }

        /// <summary>
        ///  Возвращает и задаёт имя контакта.
        /// </summary>
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string Name
        {
            get => Contact.Name;
            set => SetProperty(
                Contact.Name,
                value,
                Contact,
                (contact, name) => contact.Name = name, true);
        }

        /// <summary>
        ///  Возвращает и задаёт электронную почту контакта.
        /// </summary>
        [EmailAddress]
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string Email
        {
            get => Contact.Email;
            set => SetProperty(
                Contact.Email,
                value,
                Contact,
                (contact, email) => contact.Email = email, true);
        }

        /// <summary>
        ///  Возвращает и задаёт номер телефона контакта.
        /// </summary>
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        [Phone(ErrorMessage = "Phone Number can contains only digits and symbols '+()- '. Example: +7 (999) 111-22-33")]
        public string Phone
        {
            get => Contact.Phone;
            set => SetProperty(
                Contact.Phone,
                value,
                Contact,
                (contact, number) => contact.Phone = number, true);
        }

        /// <summary>
        ///  Клонирует текущий экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <returns>Возвращает дубликат текущего экземпляра.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}