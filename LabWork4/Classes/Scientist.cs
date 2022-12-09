using System;
using System.Linq;
using System.Text;

namespace LabWork4.Classes
{
    internal class Scientist : ITxtConvertable
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronimyc { get; private set; }
        public string FullName { get; private set; }
        public string Faculty { get; private set; }
        public string Departament { get; private set; }
        public string Degree { get; private set; }
        public string AcademicRank { get; private set; }
        public void SetFullName()
        {
            FullName = Surname + " " + Name[0] + "." + Patronimyc[0] + ".";
        }
        
        public Scientist(string name, string surname, string patronimyc, string faculty, string departament, string degree, string academicRank)
        {
            if (name.Contains('_') || surname.Contains('_') || surname.Contains('_') || patronimyc.Contains('_') || faculty.Contains('_') || degree.Contains('_') || academicRank.Contains('_'))
            {
                throw new ArgumentException("Параметри не можуть містити символ '_'");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Ім'я не може бути пустим");
            }

            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException("Прізвище не може бути пустим");
            }

            if (string.IsNullOrWhiteSpace(patronimyc))
            {
                throw new ArgumentException("По батькові не може бути пустим");
            }

            if (string.IsNullOrWhiteSpace(faculty))
            {
                throw new ArgumentException("Факультет не може бути пустим");
            }

            if (string.IsNullOrWhiteSpace(departament))
            {
                throw new ArgumentException("Кафедра не може бути пустою");
            }

            if (string.IsNullOrWhiteSpace(degree))
            {
                throw new ArgumentException("Науковий ступінь не може бути пустим");
            }

            if (string.IsNullOrWhiteSpace(academicRank))
            {
                throw new ArgumentException("Вчене звання не може бути пустим");
            }
            Name = name;
            Surname = surname;
            Patronimyc = patronimyc;
            SetFullName();
            Faculty = faculty;
            Departament = departament;
            Degree = degree;
            AcademicRank = academicRank;
        }

        public string ConvertToTxtFormat() //ITxtConvertable method 
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append("_");
            stringBuilder.Append(Surname);
            stringBuilder.Append("_");
            stringBuilder.Append(Patronimyc);
            stringBuilder.Append("_");
            stringBuilder.Append(Faculty);
            stringBuilder.Append("_");
            stringBuilder.Append(Departament);
            stringBuilder.Append("_");
            stringBuilder.Append(Degree);
            stringBuilder.Append("_");
            stringBuilder.Append(AcademicRank);
            return stringBuilder.ToString();
        }
    }
}
