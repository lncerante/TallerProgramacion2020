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

        /// <summary>
        /// Guarda en el archivo de log un mensaje
        /// </summary>
        /// <param name="pMessage">El mensaje a loguear</param>
        public static void Log(string pMessage)
        {
            Console.WriteLine(pMessage);
            var writer = new StreamWriter("./mediaFinderLog.txt", true);
            writer.WriteLine(pMessage);
            writer.Dispose();
        }

        /// <summary>
        /// Guarda en el archivo de log los datos de una excepción
        /// </summary>
        /// <param name="ex">La excepción a loguear</param>
        public static void Log(Exception ex)
        {
            var message =
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +
                "\n - Error: " + ex.Message +
                "\n - Source: " + ex.Source +
                "\n - Stack Trace: " + ex.StackTrace +
                "\n - Inner Exception: " + ex.InnerException +
                "\n - Target Site: " + ex.TargetSite;
            Console.WriteLine(message);
            var writer = new StreamWriter("./mediaFinderLog.txt", true);
            writer.WriteLine(message);
            writer.Dispose();
        }
    }
}
