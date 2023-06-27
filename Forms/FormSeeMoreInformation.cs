using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Forms
{
    public partial class FormSeeMoreInformation : Form
    {
        public string IdIMDB { get; }

        public FormSeeMoreInformation(string idIMDB)
        {
            InitializeComponent();
            IdIMDB = idIMDB;
        }

        //Allows to drag a form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void PanelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Aca tiene que venir un IMdB para mostrar la info correspondiente
        private void FormSeeMoreInformation_Load(object sender, EventArgs e)
        {
            List<String> listWriter = new List<String>();
            List<String> listDirector = new List<String>();
            List<String> listCast = new List<String>();
            List<String> listCountry = new List<String>();
            //llamar a la funcion de buscar pelicula por ImdbID
            //y que me traiga todos los datos
            // media = buscarMediaPorId(id) 
            Media media = CrearMediaDePrueba();
            labelTitle.Text = media.Title;
            labelType.Text = media.MediaType.ToString();
            labelRelaseDate.Text = media.ReleaseDate.ToString("dd/MM/yyyy");
            labelRuntime.Text = media.RuntimeInMin.ToString() + " min";
            richTextBoxGenre.Text = "Drama, Fantasia, Romance, Accion, Drama, Triller, Comedia, Aventuras, Animación, Musical, Terror, Suspenso";
            //ESTO LO DEBERIA HACER EL CONTROLADOR
            foreach (Person w in media.Writer)
            {
                listWriter.Add(w.FullName);
            }
            richTextBoxWriter.Text = String.Join(", ", listWriter);
            foreach (Person d in media.Director)
            {
                listDirector.Add(d.FullName);
            }
            richTextBoxDirector.Text = String.Join(", ", listDirector);
            foreach (Person c in media.Cast)
            {
                listCast.Add(c.FullName);
            }
            richTextBoxCast.Text= String.Join(", ", listCast);
            foreach (Country o in media.Origin)
            {
                listCountry.Add(o.Name);
            }
            labelCountry.Text = String.Join(", ", listCountry);
            labelImdb.Text = media.ImdbRating.ToString();
            pictureBoxPoster.ImageLocation = "https://m.media-amazon.com/images/M/MV5BZDRkOWQ5NGUtYTVmOS00ZjNhLWEwODgtOGI2MmUxNTBkMjU0XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg";
        }

        private Media CrearMediaDePrueba()
        {
            Director person1 = new Director("Steven Spielberg");
            List<Director> directors = new List<Director> { person1 };

            Writer person2 = new Writer("Menno Meyjes");
            Writer person3 = new Writer("Alice Walker");
            List<Writer> writers = new List<Writer> { person2, person3 };

            Actor person4 = new Actor("Danny Glover");
            Actor person5 = new Actor("Whoopi Goldberg");
            Actor person6 = new Actor("Oprah Winfrey");
            List<Actor> cast = new List<Actor> { person4, person5, person6 };

            Country country = new Country("United States");
            Country country2 = new Country("France");
            Country country3 = new Country("England");
            Country country4 = new Country("Argentina");
            List<Country> countries = new List<Country> { country, country2, country3, country4 };

            Media media1 = new Media
            {
                ImdbID = "tt0088939",
                Title = "The Color Purple",
                Year = "1985",
                MediaType = MediaType.Movie,
                ReleaseDate = new DateTime(1986, 2, 7),
                RuntimeInMin = 154,
                Director = directors,
                Writer = writers,
                Cast = cast,
                Origin = countries,
                ImdbRating = 7.7f
            };
            return media1;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
