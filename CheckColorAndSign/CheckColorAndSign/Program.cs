using System.Drawing;

#pragma warning disable

Console.Write(">>> Inter your picture path ");
///take your picture path (suggested type: png / jpg / jpeg)
string imagePath = Console.ReadLine().ToString();

Console.Write(">>> And whats your sign char ");
///take sign char (suggested: + or o)
string OutputChar = Console.ReadLine().ToString();

CheckEveryThirdPixel(imagePath, OutputChar);

static void CheckEveryThirdPixel(string imagePath, string OutputChar)
{
    try
    {
        using (Bitmap image = new Bitmap(imagePath))
        {
            Color BackPixel = image.GetPixel(1, 1);

            // lets sign your picture...
            for (int y = 0; y < image.Height; y += 2)
            {
                for (int x = 0; x < image.Width; x += 2)
                {
                    Color pixel = image.GetPixel(x, y);
                    if (pixel != BackPixel)
                    {
                        Console.Write(OutputChar);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"error msg: {ex.Message}");
    }
}