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

namespace S2.WpfIntro.Exercise04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totalCount;
        int pressCount;

        public MainWindow()
        {
            InitializeComponent();

            ArrowUp.Content = char.ConvertFromUtf32(0x2191);
            ArrowDown.Content = char.ConvertFromUtf32(0x2193); 
        }

        private void ArrowUp_Click(object sender, RoutedEventArgs e)
        {
            totalCount++;
            CurrentCounter.Text = totalCount.ToString();

            pressCount++;
            PressCounter.Text = pressCount.ToString();
        }

        private void ArrowDown_Click(object sender, RoutedEventArgs e)
        {
            totalCount++;
            CurrentCounter.Text = totalCount.ToString();

            pressCount--;
            PressCounter.Text = pressCount.ToString();
        }
    }
}
