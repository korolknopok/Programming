namespace Programming.Model
{
    using System;
    
    public class Contact
    {
        private string _number;

        public Contact()
        {
        }

        public Contact(string firstname,
            string surname,
            string number)
        {
            Firstname = firstname;
            Surname = surname;
            Number = number;
        }

        public string Firstname { get; set; }
        
        public string Surname { get; set; }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (!long.TryParse(value, out long num))
                {
                    throw new ArgumentException(
                        "the value of the Number field must consist of digits only");
                }

                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        "the value of the Number field must consist of 11 digits");
                }

                _number = value;
            }
        }
    }
}