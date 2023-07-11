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
    /// <summary>
    /// Proporciona métodos útiles para realizar tareas comunes.
    /// </summary>
    public class Tools
    {
        /// <summary>
        /// Convierte un arreglo de bytes en una imagen.
        /// </summary>
        /// <param name="profilePhoto">Arreglo de bytes que representa la imagen.</param>
        /// <returns>Imagen convertida a partir del arreglo de bytes. Si el arreglo es nulo, se devuelve null.</returns>
        public static Image ConvertByteArrayToImage(byte[] profilePhoto)
        {
            if (profilePhoto == null) return null;
            MemoryStream ms = new MemoryStream(profilePhoto);
            Bitmap bm = new Bitmap(ms);
            return bm;
        }

        /// <summary>
        /// Convierte una imagen en un arreglo de bytes.
        /// </summary>
        /// <param name="imagePath">Ruta de la imagen a convertir.</param>
        /// <returns>Arreglo de bytes que representa la imagen. Si la ruta es nula, se devuelve null.</returns>
        public static byte[] ConvertImageToByteArray(string imagePath)
        {
            if (imagePath != null)
            {
                Image img = Image.FromFile(imagePath);
                return (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
            }
            return null;
        }

        /// <summary>
        /// Compara dos cadenas de texto, ignorando diferencias de mayúsculas, espacios en blanco y recortando los espacios en los extremos.
        /// </summary>
        /// <param name="s1">Primera cadena de texto.</param>
        /// <param name="s2">Segunda cadena de texto.</param>
        /// <returns>true si las cadenas son iguales después de aplicar las comparaciones, false de lo contrario.</returns>
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
