using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerProgramacion2020.Forms
{
    public partial class FormMediaPriority : Form
    {
        private string idIMDB;

        public FormMediaPriority(string idIMDB)  
        {
            InitializeComponent();
            this.idIMDB = idIMDB;
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

        }
        
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //Acá vamos a mandar la priority del usuario a la db
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
