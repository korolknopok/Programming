using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFactory
    {
        private static string AppDataPath = Application.UserAppDataPath;

        private static Random _random = new Random();

        /// <summary>
        /// Данные для генерации.
        /// </summary>
        private static dynamic _randomData = RandomDataJson();

        private static HttpClient _http = new HttpClient();

        private static dynamic RandomDataJson()
        {
            dynamic randomData;

            using (StreamReader reader = new StreamReader(AppDataPath + @"\RandomCustomerSerialize.json"))
            {
                randomData = JsonConvert.DeserializeObject(reader.ReadToEnd());
            }

            return randomData;
        }

        public static List<Customer> RandomGenerate(int count, string json)
        {
            try
            {
                var uri = $"https://api.randomdatatools.ru/?count={count}&unescaped=true&params=LastName,FirstName,FatherName,Address";
                var request = new HttpRequestMessage(HttpMethod.Get, uri);

                var response = _http.SendAsync(request).Result;

                var json1 = response.Content.ReadAsStringAsync().Result.ToString();
                return System.Text.Json.JsonSerializer.Deserialize<List<Customer>>(json1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static string BuildingRandomFullName(dynamic data, string key, string gender)
        {
            string name;

            while (true)
            {
                int index = _random.Next(0, 100);
                var item = data[index];
                string itemGender = item["Gender"];

                if (itemGender != gender) continue;

                name = item[key];
                break;
            }

            return name;
        }

        /// <summary>
        /// Создает покупателя.
        /// </summary>
        /// <returns>Возвращает объект Customer.</returns>
        public static Customer Randomize()
        {
            string gender = _random.Next(0, 2) == 1 ? "Мужчина" : "Женщина";
            string fullName = "";
            var addressJson = _randomData[_random.Next(0, 100)].Address.ToString();
            Console.WriteLine(addressJson);
            Address address = JsonConvert.DeserializeObject<Address>(addressJson); ;

            fullName += BuildingRandomFullName(_randomData, "LastName", gender) + " ";
            fullName += BuildingRandomFullName(_randomData, "FirstName", gender) + " ";
            fullName += BuildingRandomFullName(_randomData, "FatherName", gender) + " ";

            Customer customer = new Customer();
            customer.Fullname = fullName;
            customer.Address = address;

            return customer;
        }
    }
}
