using SkiaSharp;
using System;
using System.IO;

namespace OfficeOpenXml.Compatibility
{
    internal class ImageCompat
    {
        internal static byte[] GetImageAsByteArray(SKImage image)
        {
            return image.Encode().AsSpan().ToArray();
        }
    }
}
