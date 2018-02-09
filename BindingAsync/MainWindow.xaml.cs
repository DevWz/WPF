using BindingAsync.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace BindingAsync
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        Manager manager = new Manager();

        public event PropertyChangedEventHandler PropertyChanged;

        string propriedade;

        public string Propriedade
        {
            get
            {
                return this.propriedade;
            }
            set
            {
                if (this.propriedade != value)
                {
                    this.propriedade = value;
                    if (this.PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Propriedade"));
                    }
                }
            }
        }

        async void FazAlgo()
        {
            Propriedade = await manager.AlgoAsync();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FazAlgo();
        }
    }
}
