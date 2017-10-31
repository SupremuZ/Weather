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

namespace WeatherCast
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new Context()
            {
                Latitude = 50.8267,
                Longitude = 50.4234
            };
            InitializeComponent();
            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Context data = DataContext as Context;
            data.LoadWeather();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) 
        {
            double d = 0;
            e.Handled = Double.TryParse(e.Text, out d);
        }

    }
}
