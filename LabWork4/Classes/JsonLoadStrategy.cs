using System;
using System.ComponentModel;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace LabWork4.Classes
{
    internal class JsonLoadStrategy : ILoadStrategy
    {
        public BindingList<Scientist> Load(string path)
        {
            if (!path.EndsWith("json")) throw new ArgumentException("Вказано не Json файл");
            var deserialized = System.IO.File.ReadAllText(path);
            var option = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            var scientists = JsonSerializer.Deserialize<BindingList<Scientist>>(deserialized, option) ?? throw new NullReferenceException("file is empty");
            return scientists;
        }
    }
}
