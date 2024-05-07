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

namespace stopwatch1
{
    /// <summary>
    /// Interaction logic for stopwatch.xaml
    /// </summary>
    public partial class stopwatch : Window
    {
         DateTime startingTime;
        public stopwatch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime endTime = DateTime.Now;
            TimeSpan elapsedTime = endTime - startingTime;

            Timer.Content = elapsedTime.TotalSeconds;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            startingTime = DateTime.Now;
           
        }
    }
}
