using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
namespace BookList.Model
{
    /// <summary>
    /// Хранит сериализацию и десериализацию.
    /// </summary>
    public static class Serializer
    {

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        public static void Serialize(List<Book> books)
        {
            using (StreamWriter writer = new StreamWriter(InitialConstants.FilePath))
            {
                writer.Write(JsonConvert.SerializeObject(books));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию песен.</returns>
        public static List<Book> Deserialize()
        {
            var books = new List<Book>();

            try
            {
                using (StreamReader reader = new StreamReader(InitialConstants.FilePath))
                {
                    books = JsonConvert.DeserializeObject<List<Book>>(reader.ReadToEnd());
                }

                if (books == null) books = new List<Book>();
            }
            catch
            {
                return books;
            }

            return books;
        }
    }
}