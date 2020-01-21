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

namespace S2.WpfIntro.Exercise10
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(passwordBoxInput.Password == "Ole" && textBoxUserNameInput.Text == "Ole")
            {
                textBlockMessage.Text = $"Hej {textBoxUserNameInput.Text}!";
            }
            else if(passwordBoxInput.Password == "MinHunErSød" && textBoxUserNameInput.Text == "MinHunErSød")
            {
                textBlockMessage.Text = $"Hej {textBoxUserNameInput.Text}!";
            }
            else if(passwordBoxInput.Password == "Brian" && textBoxUserNameInput.Text == "Brian")
            {
                textBlockMessage.Text = $"Hej {textBoxUserNameInput.Text}!";
            }
            else if(passwordBoxInput.Password == "Lastbil2006$Rød" && textBoxUserNameInput.Text == "Lastbil2006$Rød")
            {
                textBlockMessage.Text = $"Hej {textBoxUserNameInput.Text}!";
            }
            else
            {
                textBlockMessage.Text = "Fejl! Udfyld felterne.";
            }
        }
    }
}
