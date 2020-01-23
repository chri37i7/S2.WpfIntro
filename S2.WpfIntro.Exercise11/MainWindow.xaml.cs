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
using System.IO;

namespace S2.WpfIntro.Exercise11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Path to users image folder
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public MainWindow()
        {
            InitializeComponent();

            // Array containing image names
            string[] imageArrayGallery = { "image_1.jpg", "image_2.png", "image_3.jpg", "image_4.png", "image_5.png" };

            // Path to image
            Uri uri = new Uri(@$"{path}\{imageArrayGallery[0]}");

            // Convert Uri to ImageSource
            ImageSource imgSource = new BitmapImage(uri);

            // Set image source
            canvasBackgroundImage.ImageSource = imgSource;
        }
    }
}
