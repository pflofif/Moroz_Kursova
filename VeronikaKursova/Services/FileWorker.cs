using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeronikaKursova.Services
{
    internal class FileWorker
    {
        public static void WriteToFile<T>(string path, T collection)
        {
            JsonSerializerSettings settings = new()
            {
                TypeNameHandling = TypeNameHandling.Objects
            };
            File.WriteAllText(path, JsonConvert.SerializeObject(collection, settings));
        }

        public static T ReadFromFile<T>(string path)
        {
            JsonSerializerSettings settings = new()
            {
                TypeNameHandling = TypeNameHandling.Objects
            };
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path), settings)!;
        }
    }
}
