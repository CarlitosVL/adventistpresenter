using Himnario.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Himnario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        public ReproductorViewModel _viewMoldel;
        public MainWindow MainWindow;
        public PlayerWindow(string path, MainWindow mainWindow)
        {
            InitializeComponent();
            CargarHimno(path);
            MainWindow = mainWindow;
        }
        public void CargarHimno(string path)
        {
            
            _viewMoldel = new ReproductorViewModel(path);
            this.DataContext = _viewMoldel;
            reproductor.Play();
            _viewMoldel.Volumen = 1;
            imagePlay.Kind = MaterialDesignThemes.Wpf.PackIconKind.Pause;
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            MediaState estado = GetMediaState(reproductor);
            if (estado == MediaState.Stop || estado == MediaState.Pause)
            {
                reproductor.Play();
                _viewMoldel.PlayStopImage = MaterialDesignThemes.Wpf.PackIconKind.Pause;
            }
            else
            {
                reproductor.Pause();
                _viewMoldel.PlayStopImage = MaterialDesignThemes.Wpf.PackIconKind.Play;
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            reproductor.Stop();
            _viewMoldel.PlayStopImage = MaterialDesignThemes.Wpf.PackIconKind.Play;
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                imgRestore.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                imgRestore.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowRestore;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            reproductor.Stop();
            this.Close();
        }
        public MediaState GetMediaState(MediaElement myMedia)
        {
            FieldInfo hlp = typeof(MediaElement).GetField("_helper", BindingFlags.NonPublic | BindingFlags.Instance);
            object helperObject = hlp.GetValue(myMedia);
            FieldInfo stateField = helperObject.GetType().GetField("_currentState", BindingFlags.NonPublic | BindingFlags.Instance);
            MediaState state = (MediaState)stateField.GetValue(helperObject);
            return state;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(reproductor != null)
            reproductor.Close();
            MainWindow.OcultarControles();
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        internal MediaElement Reproductor
        {
            get { return reproductor; }
        }
    }
}
