using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;


namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        private string _name;

        private string _email;

        private long _phoneNumberNumber;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get => (_name == null) ? null : _name;
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email
        {
            get => (_email == null) ? null : _email;
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public long PhoneNumber
        {
            get => _phoneNumberNumber;
            set
            {
                _phoneNumberNumber = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="email">Электронная почта.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        public Contact(string name, string email, int phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}