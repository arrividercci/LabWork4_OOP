using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4.Classes
{
    internal interface ILoadStrategy
    {
        BindingList<Scientist> Load(string path);
    }
}
