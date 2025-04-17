using System;
using System.IO;

namespace ConvertImageToBase64.Lib;

public static class ImageHelper
{
    public static string? ConvertPngToBase64(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
        {
            Console.WriteLine("File path is null or empty.");
            return null;
        }

        try
        {
            byte[]? imageBytes = ReadFile(filePath);
            return imageBytes != null ? ConvertToBase64(imageBytes) : null;
        }
        catch (Exception ex)
        {
            HandleError(ex);
            return null;
        }
    }

    public static byte[]? ReadFile(string filePath)
    {
        try
        {
            return File.Exists(filePath) ? File.ReadAllBytes(filePath) : null;
        }
        catch (Exception ex)
        {
            HandleError(ex);
            return null;
        }
    }


    public static string ConvertToBase64(byte[] imageBytes)
    {
        return Convert.ToBase64String(imageBytes);
    }

    private static void HandleError(Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

