using System.Windows;
using System.IO;

namespace ConvertImageToBase64
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string filePath = @"C:\Projects\Image.png"; // Specify the path to your PNG file
            string? base64String = ImageHelper.ConvertPngToBase64(filePath);

            if (!string.IsNullOrEmpty(base64String))
            {
                Console.WriteLine("Base64 String: ");
                Console.WriteLine(base64String);
            }
            else
            {
                Console.WriteLine("Error occurred while converting PNG to Base64.");
            }
        }

    }

    
}