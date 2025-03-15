using System.Text;
using System.Windows;
using System;
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

            // Get the current directory of the system
            string currentDirectory = Directory.GetCurrentDirectory();

            // Combine the current directory with the relative path of the image
            string filePath = Path.Combine(currentDirectory, "Image.png");
            string base64String = ImageHelper.ConvertPngToBase64(filePath);

            if (base64String != null)
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

    public static class ImageHelper
    {
        public static string ConvertPngToBase64(string filePath)
        {
            try
            {
                // Read the PNG file into a byte array
                byte[] imageBytes = File.ReadAllBytes(filePath);

                // Convert the byte array to a Base64 string
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
            catch (Exception ex)
            {
                // Handle potential exceptions, such as file not found or IO issues
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}