using ConvertImageToBase64.Lib;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConvertImageToBase64.App;

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