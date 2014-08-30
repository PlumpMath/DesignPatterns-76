using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    /// <summary>
    /// Proxy
    /// </summary>
    public class ProxyImage : IImage
    {
        IImage hiResImage;

        private readonly string _filePath;

        public ProxyImage(string filePath)
        {
            _filePath = filePath;
        }

        public void ShowImage()
        {
            // Use 'lazy initialization'
            if (hiResImage == null)
            {
                hiResImage = new HiResImage(_filePath);
            }
            hiResImage.ShowImage();
        }
    }
}
