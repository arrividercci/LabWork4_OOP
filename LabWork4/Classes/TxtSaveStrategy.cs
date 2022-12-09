using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabWork4.Classes
{
    internal class TxtSaveStrategy : ISaveStrategy
    {
        public void Save(string path, BindingList<Scientist> scientists)
        {
            if (!path.EndsWith("txt")) throw new ArgumentException("Вказано не Text файл");
            List<string> scientistsToTxt = new List<string>();
            foreach(var scientist in scientists)
            {
                scientistsToTxt.Add(scientist.ConvertToTxtFormat());
            }
            System.IO.File.WriteAllLines(path, scientistsToTxt);
        }
    }
}
