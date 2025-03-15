# Convert Image to Base64

This is a simple C# WPF application that converts a PNG image to a Base64 string.

## Features

- Convert a PNG image (`Image.png`) located in the current directory to a Base64 string.
- Display the Base64 string in the console if the conversion is successful.
- Handles errors such as file not found or other IO issues.

## Requirements

- .NET Framework or .NET Core (for building WPF applications)
- A PNG image (`Image.png`) located in the current working directory

## How to Use

1. Clone the repository:
   ```bash
   git clone https://github.com/potatoscript/ConvertImageToBase64.git
   ```

2. Place an image named `Image.png` in the root directory of the project.

3. Open the solution in Visual Studio or your preferred IDE that supports WPF projects.

4. Build and run the project.

5. The Base64 string of the image will be printed in the console output.

## Example Output

If the `Image.png` is found and successfully converted, you will see output similar to:

```
Base64 String: 
iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAQAAAC1HAwCAAAAmElEQVR42mP8/wcAAwAB/0bxykFCybNSsW40kbbUsa9hf39xxnK7Z1Z...
```

## Code Explanation

- **MainWindow.xaml.cs**: The main logic that gets the current directory, finds the `Image.png`, and calls the `ConvertPngToBase64` method to convert it to a Base64 string.
- **ImageHelper.cs**: Contains the `ConvertPngToBase64` method, which reads the PNG image into a byte array and then converts it to a Base64 string.

## Error Handling

If there is an error while reading the file or converting it to Base64, an error message is displayed in the console.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```
