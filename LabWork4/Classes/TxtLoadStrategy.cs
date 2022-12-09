using System;
using System.ComponentModel;

namespace LabWork4.Classes
{
    internal class TxtLoadStrategy : ILoadStrategy
    {
        public BindingList<Scientist> Load(string path)
        {
            if (!path.EndsWith("txt")) throw new ArgumentException("Вказано не Text файл");
            string[] scientistsInTxt = System.IO.File.ReadAllLines(path);
            BindingList<Scientist> scientists = new BindingList<Scientist>();
            foreach(var scientistLine in scientistsInTxt)
            {
                var parsedScientistLine = scientistLine.Split('_');
                var name = parsedScientistLine[0];
                var surname = parsedScientistLine[1];
                var patronimyc = parsedScientistLine[2];
                var faculty = parsedScientistLine[3];
                var departament = parsedScientistLine[4];
                var degree = parsedScientistLine[5];
                var academicRank = parsedScientistLine[6];
                scientists.Add(new Scientist(name, surname, patronimyc, faculty, departament, degree, academicRank));
            }
            return scientists;
        }
    }
}
