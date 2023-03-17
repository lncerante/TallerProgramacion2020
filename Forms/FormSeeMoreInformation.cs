using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Forms
{
    public partial class FormSeeMoreInformation : Form
    {
        public FormSeeMoreInformation()
        {
            InitializeComponent();
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
            foreach (Person w in media.Writer)
            {
                listWriter.Add(w.FullName);
            }
            labelWriter.Text = String.Join(", ", listWriter);
            foreach (Person d in media.Director)
            {
                listDirector.Add(d.FullName);
            }
            labelDirector.Text = String.Join(", ", listDirector);
            foreach (Person c in media.Cast)
            {
                listCast.Add(c.FullName);
            }
            labelCast.Text= String.Join(", ", listCast);
            foreach (Country o in media.Origin)
            {
                listCountry.Add(o.Name);
            }
            labelCountry.Text = String.Join(", ", listCountry);
            labelImdb.Text = media.ImdbRating.ToString();
            pictureBox1.ImageLocation = "https://m.media-amazon.com/images/M/MV5BZDRkOWQ5NGUtYTVmOS00ZjNhLWEwODgtOGI2MmUxNTBkMjU0XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg";
        }

        private Media CrearMediaDePrueba()
        {
            Person person1 = new Person("Steven Spielberg");
            List<Person> directors = new List<Person> { person1 };

            Person person2 = new Person("Menno Meyjes");
            Person person3 = new Person("Alice Walker");
            List<Person> writers = new List<Person> { person2, person3 };

            Person person4 = new Person("Danny Glover");
            Person person5 = new Person("Whoopi Goldberg");
            Person person6 = new Person("Oprah Winfrey");
            List<Person> cast = new List<Person> { person4, person5, person6 };

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
    }
}
