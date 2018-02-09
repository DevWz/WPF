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
using NavigationOverview.Views;

// Tutorial do NavigationOverview
// https://docs.microsoft.com/en-us/dotnet/framework/wpf/app-development/navigation-overview

namespace NavigationOverview
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

        void Button_Click_View1(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new View1());
        }

        void Button_Click_View2(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new View2("I'm a param"));
        }

    }
}
