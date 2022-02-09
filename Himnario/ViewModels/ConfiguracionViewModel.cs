using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Himnario.ViewModels
{
    public class ConfiguracionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
        public string _path;
       public ConfiguracionViewModel()
        {
            _path = File.ReadAllText("source.txt");
        }
        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                File.WriteAllText("source.txt", value);
                OnPropertyChanged();
            }
        }
    }
}
