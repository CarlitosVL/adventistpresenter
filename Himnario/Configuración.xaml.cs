using Himnario.ViewModels;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Himnario
{
    /// <summary>
    /// Lógica de interacción para Configuración.xaml
    /// </summary>
    public partial class Configuración : Window
    {
        ConfiguracionViewModel viewModel;
        public Configuración()
        {
            InitializeComponent();
            viewModel = new ConfiguracionViewModel();
            this.DataContext = viewModel;

        }

        private void btCambiarPath_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.Description = "Directorio de himnos";
            openFileDialog.ShowNewFolderButton = true;
            openFileDialog.ShowDialog();
            if (openFileDialog.SelectedPath != "")
                viewModel.Path = openFileDialog.SelectedPath;
        }
    }
}
