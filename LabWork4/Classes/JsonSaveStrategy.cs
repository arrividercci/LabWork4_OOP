using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;


namespace LabWork4.Classes
{
    internal class JsonSaveStrategy : ISaveStrategy
    {
        public void Save(string path, BindingList<Scientist> scientists)
        {
            if (!path.EndsWith("json")) throw new ArgumentException("Вказано не Json файл");
            var option = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            var serialized = JsonSerializer.Serialize(scientists, option);
            System.IO.File.WriteAllText(path, serialized);
        }
    }
}
