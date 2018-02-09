using Microsoft.Maps.MapControl.WPF;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BingMaps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            map.Center = new Location(latitude: -22.761871, longitude: -47.396942);
            map.ZoomLevel = 14;
        }

        void Configuracoes_Click(object sender, RoutedEventArgs e)
        {
            if (!modalConfiguracoes.IsVisible)
            {
                modalConfiguracoes.Visibility = Visibility;
            }
            else
            {
                modalConfiguracoes.Visibility = Visibility.Collapsed;
            }
        }

    }
}
