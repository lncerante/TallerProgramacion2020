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
    public partial class Form1 : Form
    {
        readonly List<User> usersList = new List<User>();
        private int LX, LY;
        //private List<Button> btns = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        //Esto me permite mover la ventana
        private void PanelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DontShowGrids()
        {
            dataGridViewList.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DontShowGrids();
            //Aca vamos a tener que preguntar por el rol del usuario que haya iniciado sesion
            bool admin = true;
            if (!admin)
            {
                buttonManageUsers.Visible = false;
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
            labelListTitle.Text = "My Watch List";
            dataGridViewList.Visible = true;
            //ChangeButtonBackColor(buttonSeeWatchList);
            //Aca tiene que aparecer la lista de seguimiento del usuario
            //y tiene que haber una columna donde se pueda eliminar de la lista
            // y una columna para la prioridad
            Media media = CrearMediaDePrueba();
            dataGridViewList.Rows.Add(media.ImdbID, media.Title);
        }

        private void ButtonSeeReviews_Click(object sender, EventArgs e)
        {
            labelListTitle.Text = "My Reviews";
            //ChangeButtonBackColor(buttonSeeReviews);
            //Aca tienen que aparecer las peliculas que califique con su comentario, el comentario
            //deberia poder editarse desde aca
            // creo que con mostrar el titulo, tipo, comentario y calificacion  estaria
        }

        private void ButtonAddToList_Click(object sender, EventArgs e)
        {
            DontShowGrids();
            //ChangeButtonBackColor(buttonAddToList);
            OpenChildForm(new FormSearchMoviesOrSeries());
        }

        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            DontShowGrids();
            OpenChildForm(new FormProfile());
        }

        private void ButtonManageUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUsers());
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Waring", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //private void DataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridViewList.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //    if (cell.Value.ToString() == "See more information")
        //    {
        //        FormSeeMoreInformation formSeeMoreInformation = new FormSeeMoreInformation();
        //        formSeeMoreInformation.ShowDialog();
        //    }
        //    else if (cell.Value.ToString() == "Rate")
        //    {
        //        FormRateMovieOrSeries formRateMovieOrSerie = new FormRateMovieOrSeries("aaa");
        //        formRateMovieOrSerie.ShowDialog();
        //    }
        //    else if (cell.Value.ToString() == "Delete") { }
        //}

        private void ButtonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMaximized_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            buttonMaximized.Visible = false;
            buttonRestore.Visible = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to close the application?","Waring",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 650);
            this.Location = new Point(LX, LY);
            buttonRestore.Visible = false;
            buttonMaximized.Visible = true;
        }

        //METODOS QUE DESPUES HAY QUE ELIMINAR
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
        //private void ChangeButtonBackColor(Button btn)
        //{
        //    btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
        //    List<Button> btnList = btns;
        //    btnList.Remove(btn);
        //    foreach (Button button in btnList)
        //    {
        //        button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
        //    }
        //}
    }
}
