namespace TallerProgramacion2020.Forms
{
    partial class FormManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.columId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProfilePhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buttonRegisterNewUser = new System.Windows.Forms.Button();
            this.buttonSeeRegistersUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columId,
            this.columUsername,
            this.columnPassword,
            this.columnaFullName,
            this.columnProfilePhoto,
            this.columnDelete});
            this.dataGridViewUsers.Location = new System.Drawing.Point(74, 115);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(644, 206);
            this.dataGridViewUsers.TabIndex = 6;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsers_CellContentClick);
            // 
            // columId
            // 
            this.columId.HeaderText = "Id";
            this.columId.Name = "columId";
            this.columId.ReadOnly = true;
            // 
            // columUsername
            // 
            this.columUsername.HeaderText = "Username";
            this.columUsername.Name = "columUsername";
            this.columUsername.ReadOnly = true;
            // 
            // columnPassword
            // 
            this.columnPassword.HeaderText = "Password";
            this.columnPassword.Name = "columnPassword";
            this.columnPassword.ReadOnly = true;
            // 
            // columnaFullName
            // 
            this.columnaFullName.HeaderText = "Full Name";
            this.columnaFullName.Name = "columnaFullName";
            this.columnaFullName.ReadOnly = true;
            // 
            // columnProfilePhoto
            // 
            this.columnProfilePhoto.HeaderText = "Profile Photo";
            this.columnProfilePhoto.Name = "columnProfilePhoto";
            this.columnProfilePhoto.ReadOnly = true;
            // 
            // columnDelete
            // 
            this.columnDelete.HeaderText = "Delete";
            this.columnDelete.Name = "columnDelete";
            this.columnDelete.ReadOnly = true;
            this.columnDelete.Text = "Delete";
            this.columnDelete.UseColumnTextForLinkValue = true;
            // 
            // buttonRegisterNewUser
            // 
            this.buttonRegisterNewUser.Location = new System.Drawing.Point(302, 67);
            this.buttonRegisterNewUser.Name = "buttonRegisterNewUser";
            this.buttonRegisterNewUser.Size = new System.Drawing.Size(216, 23);
            this.buttonRegisterNewUser.TabIndex = 5;
            this.buttonRegisterNewUser.Text = "Register new user";
            this.buttonRegisterNewUser.UseVisualStyleBackColor = true;
            this.buttonRegisterNewUser.Click += new System.EventHandler(this.ButtonRegisterNewUser_Click);
            // 
            // buttonSeeRegistersUsers
            // 
            this.buttonSeeRegistersUsers.Location = new System.Drawing.Point(302, 25);
            this.buttonSeeRegistersUsers.Name = "buttonSeeRegistersUsers";
            this.buttonSeeRegistersUsers.Size = new System.Drawing.Size(211, 23);
            this.buttonSeeRegistersUsers.TabIndex = 4;
            this.buttonSeeRegistersUsers.Text = "See registered users";
            this.buttonSeeRegistersUsers.UseVisualStyleBackColor = true;
            this.buttonSeeRegistersUsers.Click += new System.EventHandler(this.ButtonSeeRegistersUsers_Click);
            // 
            // FormManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.buttonRegisterNewUser);
            this.Controls.Add(this.buttonSeeRegistersUsers);
            this.Name = "FormManageUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonRegisterNewUser;
        private System.Windows.Forms.Button buttonSeeRegistersUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn columId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFullName;
        private System.Windows.Forms.DataGridViewImageColumn columnProfilePhoto;
        private System.Windows.Forms.DataGridViewLinkColumn columnDelete;
    }
}