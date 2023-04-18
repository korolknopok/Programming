using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    /// <summary>
    /// Представляет реализацию по сериализации данных.
    /// </summary>
    public static class ContactSerializer
    {
        public static string MyDocumentsPath { get; set; } =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <param name="path">Путь десериализации.</param>
        /// <returns>Возвращает экземпляр класса <see cref="Contact"/>.</returns>
        public static void Serialize(Contact contact)
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(MyDocumentsPath));
            using (StreamWriter writer = new StreamWriter(MyDocumentsPath))
            {
                writer.Write(JsonConvert.SerializeObject(contact));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Объект типа <see cref="Store"/>.</returns>
        public static Contact Deserialize()
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(MyDocumentsPath));
            var contact = new Contact();
            try
            {
                using (StreamReader reader = new StreamReader(MyDocumentsPath))
                {
                    contact = JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd());
                }

                if (contact == null) contact = new Contact();
            }
            catch (FileNotFoundException e)
            {
                return contact;
            }

            return contact;
        }
    }
}