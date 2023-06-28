﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Controllers;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.Forms
{
    public partial class FormRateMovieOrSeries : Form
    {
        protected int idMedia { get; }
        protected ReviewDTO iReview { get; }

        public FormRateMovieOrSeries(int pIdMedia, ReviewDTO pReview = null)
        {
            idMedia = pIdMedia;
            iReview = pReview;
            InitializeComponent();
        }
        private void FormRateMovieOrSeries_Load(object sender, EventArgs e)
        {
            if (iReview != null)
            {
                var rating = "";
                switch (iReview.Rating)
                {
                    case Rating.Terrible: rating = "1 - Terrible"; break;
                    case Rating.Bad: rating = "2 - Bad"; break;
                    case Rating.Medium: rating = "3 - Medium"; break;
                    case Rating.Good: rating = "4 - Good"; break;
                    case Rating.Great: rating = "5 - Great"; break;
                }
                comboBoxRating.Text = rating;
                richTextBox1.Text = iReview.Comment;
            }
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Rating rating;
            try
            {
                switch (comboBoxRating.Text)
                {
                    case "1 - Terrible": rating = Rating.Terrible; break;
                    case "2 - Bad": rating = Rating.Bad; break;
                    case "3 - Medium": rating = Rating.Medium; break;
                    case "4 - Good": rating = Rating.Good; break;
                    case "5 - Great": rating = Rating.Great; break;
                    default: throw new Exception("Please pick a rating.");
                }
                if (iReview != null)
                {
                    new ReviewController().UpdateReview
                    (
                        (int)iReview.ID,
                        rating,
                        richTextBox1.Text
                    );
                }
                else
                {
                    new ReviewController().CreateReview
                    (
                        idMedia,
                        rating,
                        richTextBox1.Text
                    );
                }
                MessageBox.Show("Review saved.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
