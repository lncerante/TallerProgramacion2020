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
    public partial class FormMenu : Form
    {
        readonly List<User> usersList = new List<User>();
        private List<Button> btns = new List<Button>();
        public FormMenu()
        {
            InitializeComponent();
        }

        private void DontShowGrids()
        {
            dataGridViewList.Visible = false;
            dataGridViewUsers.Visible = false;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            btns.Add(buttonAddToList);
            btns.Add(buttonProfile);
            btns.Add(buttonRegisterNewUser);
            btns.Add(buttonSeeRegistersUsers);
            btns.Add(buttonSeeReviews);
            btns.Add(buttonSeeWatchList);
            InitializeUsersGrid();
            DontShowGrids();
            //Aca vamos a tener que preguntar por el rol del usuario que haya iniciado sesion
            bool admin = true;
            if (!admin)
            {
                buttonRegisterNewUser.Visible = false;
                buttonSeeRegistersUsers.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (this.panelFormsContainer.Controls.Count > 0)
            {
                this.panelFormsContainer.Controls.RemoveAt(0);
            }
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelFormsContainer.Controls.Add(childForm);
            this.panelFormsContainer.Tag = childForm;
            childForm.Show();
        }

        private void ButtonSeeWatchList_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Visible = false;
            labelListTitle.Text = "My Watch List";
            dataGridViewList.Visible = true;
            ChangeButtonBackColor(buttonSeeWatchList); 
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
            ChangeButtonBackColor(buttonSeeReviews);
            //Aca tienen que aparecer las peliculas que califique con su comentario, el comentario
            //deberia poder editarse desde aca
            // creo que con mostrar el titulo, tipo, comentario y calificacion  estaria
        }

        private void ButtonAddToList_Click(object sender, EventArgs e)
        {
            DontShowGrids();
            ChangeButtonBackColor(buttonAddToList);
            OpenChildForm(new FormSearchMoviesOrSeries());
        }

        private void ButtonSeeRegistersUsers_Click(object sender, EventArgs e)
        {
            dataGridViewList.Visible=false;
            labelListTitle.Text = "Registers Users";
            ChangeButtonBackColor(buttonSeeRegistersUsers);
            //Aca deberiamos llamar a la lista de usuarios real, por ahora es una lista creada asi no mas.
            // Ejemlo:  List<User> list = controlador.AllUsers();
            ShowUsers();
        }

        private void ShowUsers()
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.Visible = true;
            foreach (var user in usersList)
            {
                Image imgProfile = ConvertByteArrayToImage(user.ProfilePhoto);
                dataGridViewUsers.Rows.Add(user.ID, user.UserName, user.PasswordHash, user.FullName, imgProfile);
            }
        }

        private Image ConvertByteArrayToImage(byte[] profilePhoto)
        {
            if (profilePhoto == null) return null;
            MemoryStream ms = new MemoryStream(profilePhoto);
            Bitmap bm = new Bitmap(ms);
            return bm;
        }

        private void ButtonRegisterNewUser_Click(object sender, EventArgs e)
        {
            DontShowGrids();
            ChangeButtonBackColor(buttonRegisterNewUser);
            OpenChildForm(new FormRegisterAdminUser());
        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Delete")
            {
                var idToDelete = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value;
                usersList.RemoveAt((int)idToDelete - 1);//ACA HAY QUE LLAMAR A LA ELIMINACION REAL DE USUARIOS
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
            else if (cell.Value.ToString() == "Rate")
            {
                FormRateMovieOrSeries formRateMovieOrSerie = new FormRateMovieOrSeries("aaa");
                formRateMovieOrSerie.ShowDialog();
            }else if(cell.Value.ToString() == "Delete") { }
        }
               
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMaximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonMaximized.Visible = false;
            buttonRestore.Visible = true;
        }

        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonRestore.Visible = false;
            buttonMaximized.Visible = true;
        }

        //METODOS QUE DESPUES HAY QUE ELIMINAR
        private void InitializeUsersGrid()
        { ///Convierto la foto a byte[]
            Image img = Image.FromFile("D:\\Downloads\\foto.jpeg");
            byte[] imgByte = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));

            User user1 = new User
            {
                ID = 1,
                FullName = "Pepito",
                UserName = "pepiFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFto1",
                PasswordHash = "sjsj8",
                ProfilePhoto = imgByte
            };
            User user2 = new User
            {
                ID = 2,
                FullName = "Pepito perez",
                UserName = "pepito2",
                PasswordHash = "sjsj89",
                ProfilePhoto = imgByte
            };
            User user3 = new User
            {
                ID = 3,
                FullName = "Juan perez",
                UserName = "pepito3",
                PasswordHash = "fde3sjsj89",
                ProfilePhoto = imgByte
            };
            usersList.Add(user1);
            usersList.Add(user2);
            usersList.Add(user3);
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
        private void ChangeButtonBackColor(Button btn)
        {
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            List<Button> btnList = btns;
            btnList.Remove(btn);
            foreach (Button button in btnList)
            {
                button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
