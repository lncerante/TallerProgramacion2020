﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.ToolsClass;

namespace TallerProgramacion2020.Forms
{
    /// <summary>
    /// Formulario que muestra toda la información de una película o serie.
    /// </summary>
    public partial class FormSeeMoreInformation : Form
    {
        protected MediaDTO iMedia { get; }

        /// <summary>
        /// Crea una nueva instancia de la clase FormSeeMoreInformation.
        /// </summary>
        /// <param name="pMedia">Película o serie a mostrar.</param>
        public FormSeeMoreInformation(MediaDTO pMedia)
        {
            iMedia = pMedia;
            InitializeComponent();
        }

        //Permite arrastrar elformulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void PanelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Se ejecuta al cargar el formulario y muestra la información detallada de la película o serie.
        /// </summary>
        private void FormSeeMoreInformation_Load(object sender, EventArgs e)
        {
            richTextBoxCast.Text = string.Join(", ", iMedia.Cast.Select(i => i.FullName));
            richTextBoxDirector.Text = string.Join(", ", iMedia.Director.Select(i => i.FullName));
            richTextBoxWriter.Text = string.Join(", ", iMedia.Writer.Select(i => i.FullName));
            richTextBoxGenres.Text = string.Join(", ", iMedia.Genres.Select(i => i.Name));
            richTextBoxOrigin.Text = string.Join(", ", iMedia.Origin.Select(i => i.Name));
            labelImdb.Text = iMedia.ImdbRating.ToString();
            labelRuntime.Text = iMedia.RuntimeInMin.ToString() + " min.";
            labelType.Text = iMedia.MediaType == MediaType.Movie ? "Movie" : "Series";
            labelReleaseDate.Text = iMedia.ReleaseDate?.ToLongDateString();
            labelTitle.Text = iMedia.Title;
            pictureBoxPoster.Image = Tools.ConvertByteArrayToImage(iMedia.Poster);
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
