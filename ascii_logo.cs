using System;
using System.Drawing;

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class ascii_logo
    {//start of ascii_logo class
        public ascii_logo()
        {//start of a constructor

            //call the ascii method
            ascii();

        }//end of a constructor

        //ascii drawing method
        private void ascii()
        {
            try
            {
                //path of the logo [ where the logo is ]
                string path = string.Empty;

                //auto get the full path
                string fullpath = AppDomain.CurrentDomain.BaseDirectory;

                //now combine the paths
                path = fullpath.Replace(@"bin\Debug\", "logo.png");

                Bitmap image = new Bitmap(path);

                //resize for better console fit
                int width = 90;
                int height = 40; //(image.Height * width) / image.Width;
                Bitmap resized = new Bitmap(image, new Size(width, height));

                //adding color
                Console.ForegroundColor = ConsoleColor.Cyan;
                //default color , you can set yours before this line
                //symbols to draw the image
                string asciiChars = "@#$%?*+;:,. ";

                //start by the height
                for (int y = 0; y < resized.Height; y++)
                {
                    //then width
                    for (int x = 0; x < resized.Width; x++)
                    {
                        //color the pixel on x and y
                        Color pixel = resized.GetPixel(x, y);

                        //convert to grayscale
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;

                        //map grayscale to ASCII
                        int index = (gray * (asciiChars.Length - 1)) / 255;

                        Console.Write(asciiChars[index]);
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
            }
            catch (Exception)
            {
                //fallback if image is missing
                Console.WriteLine("******** CYBER BOT ********");
            }
        }

    }//end of ascii_logo class
}//end of namespace
