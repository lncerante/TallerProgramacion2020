using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Controllers;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.ToolsClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TallerProgramacion2020.Forms
{
    public partial class FormMediaPriority : Form
    {
        private int idMedia;
        protected WatchListItemDTO iWatchListItem { get; }

        public FormMediaPriority(int pIdMedia, WatchListItemDTO pWatchListItem = null)
        {
            idMedia = pIdMedia;
            iWatchListItem = pWatchListItem;
            InitializeComponent();
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

        private void FormMediaPriority_Load(object sender, EventArgs e)
        {
            if (iWatchListItem != null)
            {
                var priority = iWatchListItem.Priority.ToString();
                comboBoxPriority.Text = priority;
            }
        }
        
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Priority priority;
            try
            {
                switch (comboBoxPriority.Text)
                {
                    case "Low": priority = Priority.Low; break;
                    case "Normal": priority = Priority.Normal; break;
                    case "High": priority = Priority.High; break;
                    case "Highest": priority = Priority.Highest; break;
                    default: throw new Exception("Please pick a priority.");
                }
                if (iWatchListItem != null)
                {
                    new WatchListController().UpdateWatchListItem
                    (
                        (int)iWatchListItem.ID,
                        priority
                    );
                }
                else
                {
                    new WatchListController().CreateWatchListItem
                    (
                        idMedia,
                        priority
                    );
                }
                MessageBox.Show("WatchList item saved.");
                Close();
            }
            catch (Exception ex)
            {
                Tools.Log(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
