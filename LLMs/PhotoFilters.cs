using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs
{
    public class PhotoFilters
    {
        public PhotoFilters() { }

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness Applied");
        }


        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast Applied");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Photo Resized");
        }


    }
}
