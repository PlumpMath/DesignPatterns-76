using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    /// <summary>
    /// RealSubject
    /// </summary>
    public class HiResImage : IImage
    {
        public HiResImage(string filePath)
        {
            LoadImage(filePath);
        }

        public void ShowImage()
        {
            Console.WriteLine("Now showing HiRes-Image");
        }

        public void LoadImage(string filePath)
        {
            Console.WriteLine("Loading image and consuming huge amount of resources and time...");
        }
    }
}
