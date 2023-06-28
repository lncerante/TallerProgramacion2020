using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TallerProgramacion2020.ToolsClass
{
    public class Tools
    {
        public static Image ConvertByteArrayToImage(byte[] profilePhoto)
        {
            if (profilePhoto == null) return null;
            MemoryStream ms = new MemoryStream(profilePhoto);
            Bitmap bm = new Bitmap(ms);
            return bm;
        }

        public static byte[] ConvertImageToByteArray(string imagePath)
        {
            if (imagePath != null)
            {
                Image img = Image.FromFile(imagePath);
                return (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
            }
            return null;
        }

        public static bool Equals(string s1, string s2)
        {
            return s1.ToLower().Trim() == s2.ToLower().Trim();
        }
    }
}
