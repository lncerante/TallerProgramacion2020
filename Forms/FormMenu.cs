using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Forms
{
    public partial class FormMenu : Form
    {
        readonly List<User> listaUsuarios = new List<User>();
        readonly bool admin;
        public FormMenu(bool adminUser)
        {
            InitializeComponent();
            admin = adminUser;
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
        
        private void DontShowGrids()
        {
            dataGridViewList.Visible = false;
            dataGridViewUsers.Visible = false;
        }

        private void FormManageLists_Load(object sender, EventArgs e)
        {
            InitializeUsersGrid();
            DontShowGrids();
            if (!admin)
            {
                buttonRegisterNewUser.Visible = false;
                buttonSeeRegistersUsers.Visible = false;
            }
        }

        private void ButtonSeeWatchList_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Visible = false;
            labelListTitle.Text = "My Watch List";
            dataGridViewList.Visible = true;
            //Aca tiene que aparecer la lista de seguimiento del usuario
            //y tiene que haber una columna donde se pueda eliminar de la lista
            // y una columna para la prioridad
            Media media = CrearMediaDePrueba();
            dataGridViewList.Rows.Add(media.ImdbID, media.Title);
        }

        private void ButtonSeeReviews_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Visible = false;
            labelListTitle.Text = "My Reviews";
            //Aca tienen que aparecer las peliculas que califique con su comentario, el comentario
            //deberia poder editarse desde aca
            // creo que con mostrar el titulo, tipo, comentario y calificacion  estaria
        }

        private void ButtonAddToList_Click(object sender, EventArgs e)
        {
            DontShowGrids();
            //aca tiene que ir al formulario de busqueda
            FormSearchMoviesOrSeries formSearchMoviesOrSeries = new FormSearchMoviesOrSeries();
            formSearchMoviesOrSeries.ShowDialog();
            //una vez que cierre este dialogo se podria actualizar el mostrar lista
          }

        private void ButtonSeeRegistersUsers_Click(object sender, EventArgs e)
        {
            dataGridViewList.Visible=false;
            //Aca deberiamos llamar a la lista de usuarios real, por ahora es una lista creada asi no mas.
            //Hay que validar que a esto solo lo pueda ver el usuario administrador, no cualquier usuario.
            ShowUsers();
        }

        private void ShowUsers()
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.Visible = true;
            foreach (var user in listaUsuarios)
            {
                dataGridViewUsers.Rows.Add(user.ID, user.UserName, user.PasswordHash, user.FullName, user.ProfilePhoto);
            }
        }

        private void InitializeUsersGrid()
        {
            User user1 = new User
            {
                ID = 1,
                FullName = "Pepito",
                UserName = "pepito1",
                PasswordHash = "sjsj8"
            };
            User user2 = new User
            {
                ID = 2,
                FullName = "Pepito perez",
                UserName = "pepito2",
                PasswordHash = "sjsj89"
            };
            User user3 = new User
            {
                ID = 3,
                FullName = "Juan perez",
                UserName = "pepito3",
                PasswordHash = "fde3sjsj89"
            };
            listaUsuarios.Add(user1);
            listaUsuarios.Add(user2);
            listaUsuarios.Add(user3);
        }

        private void ButtonRegisterNewUser_Click(object sender, EventArgs e)
        {
            DontShowGrids();
            FormRegisterUser formCreateUser = new FormRegisterUser();
            formCreateUser.ShowDialog();
        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Delete")
            {
                var idToDelete = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value;
                listaUsuarios.RemoveAt((int)idToDelete - 1);//ACA HAY QUE LLAMAR A LA ELIMINACION REAL DE USUARIOS
                ShowUsers();
            }
            else
            {

            }
        }

        private void DataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridViewList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "See more information")
            {
                FormSeeMoreInformation formSeeMoreInformation = new FormSeeMoreInformation();
                formSeeMoreInformation.ShowDialog();
            }
            else
            {

            }
        }
    }
}
