using Himnario.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using Himnario.Model;
using System.Windows.Forms;
using System.IO;
using MessageBox = System.Windows.MessageBox;

namespace Himnario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PlayerWindow Player;
        Library library;
        WpfScreen playerScreen;
        public MainWindow()
        {
            InitializeComponent();
            library = new Library();
            SerachList.DataContext = library;
            playerScreen = WpfScreen.GetScreenFrom(this);
        }
       

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            CargarHimno();
           // SerachList.Visibility = Visibility.Hidden;
        }
        void CargarHimno()
        {
            string path = tbBusqueda.Text;
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    int numero = 0;
                    if (int.TryParse(path, out numero))
                    {
                        path = string.Format("{0:D3}", numero);
                        string directory = File.ReadAllText("source.txt");
                        if (!string.IsNullOrEmpty(directory))
                        {
                            path = directory + @"\" + path + ".avi";
                            //path = @"Himnos\" + path + ".avi";

                            if (Player == null)
                            {
                                Player = new PlayerWindow(path, this);
                                Player.Show();
                            }
                            else
                            {
                                //Player.Close();
                                //Player = new PlayerWindow(path, this);
                                Player.CargarHimno(path);
                                Player.Show();
                            }
                            spControls.Visibility = Visibility.Visible;
                            imagePlay.DataContext = Player._viewMoldel;
                            sVolumen.DataContext = Player._viewMoldel;
                            listSuggest.Visibility = Visibility.Hidden;
                        }
                        else
                             System.Windows.MessageBox.Show("No se ha definido el directorio de los videos aun.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Ingrese un número de himno correcto.");
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.ToString());
                }
            }
        }
        public void OcultarControles()
        {
            spControls.Visibility = Visibility.Hidden;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Player != null)
                Player.Close();
            System.Windows.Application.Current.Shutdown();
        }

        private void tbBusqueda_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CargarHimno();
            }
            else if (e.Key == Key.Down)
            {
                if (listSuggest.Visibility == Visibility.Visible)
                {
                    SerachList.Focus();
                }
            }
           
            else
            {
                if (e.Key == Key.Escape)
                {
                    tbBusqueda.Text = "";
                }
                if (string.IsNullOrEmpty(tbBusqueda.Text))
                {
                    listSuggest.Visibility = Visibility.Hidden;
                }
                else
                {
                    library.aBuscar = tbBusqueda.Text;
                    SerachList.ItemsSource = library.Himnos;
                    listSuggest.Visibility = Visibility.Visible;
                }
            }

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (Player != null)
            {
                if (Player.reproductor != null)
                {
                    MediaState estado = Player.GetMediaState(Player.reproductor);
                    if (estado == MediaState.Stop || estado == MediaState.Pause)
                    {
                        Player.reproductor.Play();
                        imagePlay.Kind = MaterialDesignThemes.Wpf.PackIconKind.Pause;
                    }
                    else
                    {
                        Player.reproductor.Pause();
                        imagePlay.Kind = MaterialDesignThemes.Wpf.PackIconKind.Play;
                    }
                }
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (Player != null)
            {
                if (Player.reproductor != null)
                {
                    Player.reproductor.Stop();
                    imagePlay.Kind = MaterialDesignThemes.Wpf.PackIconKind.Play;
                }
            }
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btSettings_Click(object sender, RoutedEventArgs e)
        {
            Configuración configuración = new Configuración();
            configuración.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            configuración.ShowDialog();
        }

        private void SerachList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SerachList.SelectedItem != null)
            {
                HimnoModel himno = SerachList.SelectedItem as HimnoModel;

                tbBusqueda.Text = himno.NoHimno.ToString();
            }
        }

        private void SerachList_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                listSuggest.Visibility = Visibility.Hidden;
                tbBusqueda.Focus();
            }
            else if (e.Key == Key.Escape)
            {
                listSuggest.Visibility = Visibility.Hidden;
                tbBusqueda.Text = "";
                tbBusqueda.Focus();
            }
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            listSuggest.Visibility = Visibility.Hidden;
            tbBusqueda.Focus();
        }
    }
}
