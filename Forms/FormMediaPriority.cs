using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void FormMediaPriority_Load(object sender, EventArgs e)
        {

        }
        
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
