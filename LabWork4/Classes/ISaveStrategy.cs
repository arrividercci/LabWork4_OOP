using System.ComponentModel;

namespace LabWork4.Classes
{
    internal interface ISaveStrategy
    {
        void Save(string path, BindingList<Scientist> scientists);
    }
}
