using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4.Classes
{
    internal class FileManager
    {
        private ISaveStrategy saveStrategy;
        private ILoadStrategy loadStrategy;
        
        public void SetSaveStrategy(ISaveStrategy saveStrategy)
        {
            this.saveStrategy = saveStrategy;
        }

        public void SetLoadStrategy(ILoadStrategy loadStrategy)
        {
            this.loadStrategy = loadStrategy;
        }

        public void Save(string path, BindingList<Scientist> scientists)
        {
            saveStrategy.Save(path, scientists);
        }

        public BindingList<Scientist> Load(string path)
        {
            return loadStrategy.Load(path);
        }
    }
}
