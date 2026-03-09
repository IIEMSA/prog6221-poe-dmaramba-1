using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBotSecurity
{
    internal class ImageLoader
    {

        public void Show()
        {
            string imagePath = "Logo/chat-box.png"; // Change to your image path
            int width = 60; // Adjust as needed
            int height = 30; // Adjust as needed

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ConvertImageToAscii(imagePath, width, height);
        }


        private void ConvertImageToAscii(string imagePath, int newWidth, int newHeight)
        {
            Bitmap image = new Bitmap(imagePath);
            image = new Bitmap(image, new Size(newWidth, newHeight));

            // ASCII characters ordered by brightness
            string asciiChars = "@%#*+=-:. ";

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int grayValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // Convert to grayscale
                    int index = grayValue * (asciiChars.Length - 1) / 255; // Map to ASCII range
                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }
    }
}
