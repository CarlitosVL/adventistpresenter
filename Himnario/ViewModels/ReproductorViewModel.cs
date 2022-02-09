using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Himnario.ViewModels
{
    public class ReproductorViewModel : INotifyPropertyChanged
    {
        private Uri _uriHimno;
        private double _volumen;
        private PackIconKind _playStop = PackIconKind.Pause;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            
        }
        public PackIconKind PlayStopImage
        {
            get 
            { 
                return _playStop;
            }
            set
            {
                _playStop = value;
                OnPropertyChanged();
            }
        }
        public ReproductorViewModel(string path)
        {
            _uriHimno = new Uri(path);
            _volumen = 1;
        }
        public Uri Uri
        {
            get
            {
                return _uriHimno;
            }
        }
        public double Volumen
        {
            get 
            { 
                
                return _volumen;
            }
            set
            {
                _volumen = value;
                OnPropertyChanged();
            }
        }
    }
}
