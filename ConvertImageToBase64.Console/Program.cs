using System;
using ConvertImageToBase64.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the path of the image:");
        string path = Console.ReadLine();

        Console.WriteLine($"Checking: {path}");

        if (Directory.Exists("/data"))
        {
            Console.WriteLine("🔍 /data contents:");
            foreach (var file in Directory.GetFiles("/data"))
            {
                Console.WriteLine(" - " + file);
            }
        }
        else
        {
            Console.WriteLine("❌ /data directory not found");
        }

        if (File.Exists(path))
        {
            string? base64 = ImageHelper.ConvertPngToBase64(path);

            if (base64 != null)
            {
                Console.WriteLine("\n✅ Base64 string:");
                Console.WriteLine(base64);
            }
            else
            {
                Console.WriteLine("❌ Failed to convert image to Base64.");
            }
        }
        else
        {
            Console.WriteLine("❌ File not found.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
